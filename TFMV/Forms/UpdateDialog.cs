using System;
using System.Windows.Forms;

namespace TFMV.Forms
{
    public partial class UpdateDialog : Form
    {
        public enum UpdateDialogResult { Download, Later }

        public UpdateDialogResult Result { get; private set; } = UpdateDialogResult.Later;

        // Final state of the "Check for updates on startup" checkbox at dialog close.
        // Mirrors the Settings-tab checkbox of the same name; caller writes it back.
        public bool CheckOnStartup { get { return cbCheckOnStartup.Checked; } }

        public UpdateDialog(Version currentVersion, string remoteTag, string releaseNotes, bool checkOnStartupInitial)
        {
            InitializeComponent();

            // keep initial focus on Download so the read-only notes box doesn't auto-select its text
            this.ActiveControl = btnDownload;

            versionsLabel.Text = string.Format("Current:  {0}\r\nLatest:   {1}", currentVersion, remoteTag);
            notesBox.Text = string.IsNullOrEmpty(releaseNotes)
                ? "(no release notes provided)"
                : releaseNotes.Replace("\n", "\r\n").Replace("\r\r\n", "\r\n");

            cbCheckOnStartup.Checked = checkOnStartupInitial;

            btnDownload.Click += (s, e) =>
            {
                Result = UpdateDialogResult.Download;
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            btnLater.Click += (s, e) =>
            {
                Result = UpdateDialogResult.Later;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
        }
    }
}
