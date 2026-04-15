using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using Ionic.Zip;

namespace TFMV.Functions
{
    public static class Updater
    {
        private const string GITHUB_LATEST_RELEASE_URL = "https://api.github.com/repos/NeoDement/TFMV/releases/latest";
        private const string USER_AGENT = "TFMV-Updater";

        public class ReleaseInfo
        {
            public Version RemoteVersion;
            public string TagName;
            public string Body;
            public string ZipDownloadUrl;
            public string ZipAssetName;
        }

        // Fetch latest release metadata. Returns null if network fails or parse fails.
        public static ReleaseInfo FetchLatestRelease()
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent", USER_AGENT);
                    client.Headers.Add("Accept", "application/vnd.github+json");

                    string json = client.DownloadString(GITHUB_LATEST_RELEASE_URL);

                    var serializer = new JavaScriptSerializer();
                    serializer.MaxJsonLength = 10 * 1024 * 1024;
                    var data = serializer.Deserialize<Dictionary<string, object>>(json);

                    if (data == null) return null;

                    string tagName = data.ContainsKey("tag_name") ? (data["tag_name"] as string) ?? "" : "";
                    string body = data.ContainsKey("body") ? (data["body"] as string) ?? "" : "";

                    // strip leading 'v' if present (defensive)
                    string versionString = tagName.TrimStart('v', 'V').Trim();

                    Version remoteVer;
                    if (!Version.TryParse(versionString, out remoteVer)) return null;

                    // find first .zip asset
                    string zipUrl = null;
                    string zipName = null;
                    if (data.ContainsKey("assets"))
                    {
                        System.Collections.ArrayList assets = data["assets"] as System.Collections.ArrayList;
                        if (assets != null)
                        {
                            foreach (var asset in assets)
                            {
                                Dictionary<string, object> assetDict = asset as Dictionary<string, object>;
                                if (assetDict == null) continue;

                                string name = assetDict.ContainsKey("name") ? assetDict["name"] as string : "";
                                string url = assetDict.ContainsKey("browser_download_url") ? assetDict["browser_download_url"] as string : "";
                                if (!string.IsNullOrEmpty(name) && name.EndsWith(".zip", StringComparison.OrdinalIgnoreCase))
                                {
                                    zipUrl = url;
                                    zipName = name;
                                    break;
                                }
                            }
                        }
                    }

                    if (string.IsNullOrEmpty(zipUrl)) return null;

                    return new ReleaseInfo
                    {
                        RemoteVersion = remoteVer,
                        TagName = tagName,
                        Body = body,
                        ZipDownloadUrl = zipUrl,
                        ZipAssetName = zipName
                    };
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("[Updater] FetchLatestRelease failed: " + ex.Message);
                return null;
            }
        }

        public static Version GetCurrentVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            Version v;
            if (Version.TryParse(fvi.FileVersion, out v)) return v;
            return new Version(0, 0);
        }

        // Downloads the ZIP to %TEMP%\tfmv_update\, extracts it, and launches TFMV_Updater.exe
        // Returns true if the updater was launched successfully (caller should exit the app).
        public static bool DownloadAndLaunchUpdater(ReleaseInfo release)
        {
            try
            {
                string tempRoot = Path.Combine(Path.GetTempPath(), "tfmv_update");

                // clear any stale update dir
                if (Directory.Exists(tempRoot))
                {
                    try { Directory.Delete(tempRoot, true); } catch { }
                }
                Directory.CreateDirectory(tempRoot);

                string zipPath = Path.Combine(tempRoot, release.ZipAssetName ?? "update.zip");
                string extractDir = Path.Combine(tempRoot, "extracted");
                Directory.CreateDirectory(extractDir);

                // download
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                using (WebClient client = new WebClient())
                {
                    client.Headers.Add("User-Agent", USER_AGENT);
                    client.DownloadFile(release.ZipDownloadUrl, zipPath);
                }

                // extract
                using (ZipFile zip = ZipFile.Read(zipPath))
                {
                    zip.ExtractAll(extractDir, ExtractExistingFileAction.OverwriteSilently);
                }

                // The zip should contain a single root folder (e.g. "TFMV_Neo/"). Source for the copy
                // is either that inner folder or extractDir itself if files are at the top level.
                string srcDir = extractDir;
                var topDirs = Directory.GetDirectories(extractDir);
                var topFiles = Directory.GetFiles(extractDir);
                if (topDirs.Length == 1 && topFiles.Length == 0)
                {
                    srcDir = topDirs[0];
                }

                string installDir = AppDomain.CurrentDomain.BaseDirectory.TrimEnd('\\', '/');
                string updaterExe = Path.Combine(installDir, "tools", "TFMV_Updater.exe");

                if (!File.Exists(updaterExe))
                {
                    MessageBox.Show(
                        "Could not find the updater at:\n" + updaterExe +
                        "\n\nDownloaded files are at:\n" + extractDir +
                        "\n\nYou can manually copy them over your install folder.",
                        "Updater Missing");
                    return false;
                }

                int currentPid = Process.GetCurrentProcess().Id;
                string args = string.Format("\"{0}\" \"{1}\" \"{2}\"", currentPid, srcDir, installDir);

                Process.Start(new ProcessStartInfo
                {
                    FileName = updaterExe,
                    Arguments = args,
                    UseShellExecute = true
                });

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Failed to download or prepare the update:\n\n" + ex.Message,
                    "Update Error");
                return false;
            }
        }
    }
}
