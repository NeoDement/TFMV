using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace TFMV
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            // Route every uncaught throw — startup, runtime, UI thread, background thread —
            // through one log-and-display path. Without this, exceptions during the form
            // constructor or in event handlers exit the process silently with no feedback.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            Application.ThreadException += (s, e) => log_crash("UI thread", e.Exception);
            AppDomain.CurrentDomain.UnhandledException += (s, e) => log_crash("background thread", e.ExceptionObject as Exception);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                Application.Run(new Main());
            }
            catch (Exception ex)
            {
                log_crash("startup", ex);
            }
        }

        // Pop a dialog when an uncaught exception escapes. The crash.log file-write path
        // is commented out for now — the dialog alone is enough.
        static void log_crash(string source, Exception ex)
        {
            if (ex == null) { return; }

            //try
            //{
            //    string log_dir = Application.StartupPath + "\\config\\";
            //    Directory.CreateDirectory(log_dir);
            //    string log_path = log_dir + "crash.log";
            //
            //    StringBuilder sb = new StringBuilder();
            //    sb.AppendLine();
            //    sb.AppendLine("===============================================");
            //    sb.AppendLine("[" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "] " + source);
            //    sb.AppendLine("===============================================");
            //
            //    Exception cur = ex;
            //    int depth = 0;
            //    while (cur != null)
            //    {
            //        sb.AppendLine("--- inner " + depth + " ---");
            //        sb.AppendLine(cur.GetType().FullName + ": " + cur.Message);
            //        sb.AppendLine(cur.StackTrace ?? "(no stack)");
            //        cur = cur.InnerException;
            //        depth++;
            //    }
            //
            //    File.AppendAllText(log_path, sb.ToString());
            //}
            //catch { /* nothing useful to do if logging fails */ }

            try
            {
                MessageBox.Show(
                    "TFMV crashed (" + source + "): " + ex.GetType().Name + "\n\n"
                    + ex.Message,
                    "TFMV crash",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch { /* if even the dialog fails there's nothing else to do */ }
        }
    }
}
