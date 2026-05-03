using System;
using System.Windows.Forms;

namespace TFMV.Forms
{
    public partial class UpdateDialog : Form
    {
        public enum UpdateDialogResult { Download, Skip, Later }

        public UpdateDialogResult Result { get; private set; } = UpdateDialogResult.Later;

        public UpdateDialog(Version currentVersion, string remoteTag, string releaseNotes)
        {
            InitializeComponent();

            // keep initial focus on Download so the read-only notes box doesn't auto-select its text
            this.ActiveControl = btnDownload;

            versionsLabel.Text = string.Format("Current:  {0}\r\nLatest:   {1}", currentVersion, remoteTag);
            notesBox.Text = string.IsNullOrEmpty(releaseNotes)
                ? "(no release notes provided)"
                : releaseNotes.Replace("\n", "\r\n").Replace("\r\r\n", "\r\n");

            btnDownload.Click += (s, e) =>
            {
                Result = UpdateDialogResult.Download;
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            btnSkip.Click += (s, e) =>
            {
                Result = UpdateDialogResult.Skip;
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
