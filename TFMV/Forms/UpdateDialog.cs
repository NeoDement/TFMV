using System;
using System.Drawing;
using System.Windows.Forms;

namespace TFMV.Forms
{
    public class UpdateDialog : Form
    {
        public enum UpdateDialogResult { Download, Later }

        public UpdateDialogResult Result { get; private set; } = UpdateDialogResult.Later;

        public UpdateDialog(Version currentVersion, string remoteTag, string releaseNotes)
        {
            this.Text = "TFMV Update Available";
            this.Width = 560;
            this.Height = 480;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowInTaskbar = false;

            Label header = new Label
            {
                Text = "A new version of TFMV is available!",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(16, 16)
            };
            this.Controls.Add(header);

            Label versions = new Label
            {
                Text = string.Format("Current:  {0}\r\nLatest:   {1}", currentVersion, remoteTag),
                AutoSize = true,
                Location = new Point(16, 48)
            };
            this.Controls.Add(versions);

            Label notesLabel = new Label
            {
                Text = "Release notes:",
                AutoSize = true,
                Location = new Point(16, 96)
            };
            this.Controls.Add(notesLabel);

            TextBox notesBox = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                ScrollBars = ScrollBars.Vertical,
                Location = new Point(16, 120),
                Size = new Size(512, 250),
                Text = string.IsNullOrEmpty(releaseNotes) ? "(no release notes provided)" : releaseNotes.Replace("\n", "\r\n").Replace("\r\r\n", "\r\n"),
                Font = new Font("Consolas", 9F)
            };
            this.Controls.Add(notesBox);

            Button btnDownload = new Button
            {
                Text = "Download Update",
                Location = new Point(296, 390),
                Size = new Size(120, 28)
            };
            btnDownload.Click += (s, e) =>
            {
                Result = UpdateDialogResult.Download;
                this.DialogResult = DialogResult.OK;
                this.Close();
            };
            this.Controls.Add(btnDownload);
            this.AcceptButton = btnDownload;

            Button btnLater = new Button
            {
                Text = "Later",
                Location = new Point(424, 390),
                Size = new Size(104, 28)
            };
            btnLater.Click += (s, e) =>
            {
                Result = UpdateDialogResult.Later;
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };
            this.Controls.Add(btnLater);
            this.CancelButton = btnLater;
        }
    }
}
