using System;
using System.Windows.Forms;

namespace TFMV.Forms
{
    public partial class UpdateProgressDialog : Form
    {
        public bool WasCancelled { get; private set; }
        public event EventHandler Cancelled;

        public UpdateProgressDialog()
        {
            InitializeComponent();

            cancelButton.Click += (s, e) =>
            {
                WasCancelled = true;
                cancelButton.Enabled = false;
                statusLabel.Text = "Cancelling...";
                Cancelled?.Invoke(this, EventArgs.Empty);
            };
        }

        // Safe to call from any thread.
        public void SetProgress(int percent, long bytesReceived, long totalBytes)
        {
            if (this.IsDisposed) return;
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(() => SetProgress(percent, bytesReceived, totalBytes)));
                return;
            }

            if (percent < 0) percent = 0;
            if (percent > 100) percent = 100;
            progressBar.Value = percent;

            if (totalBytes > 0)
            {
                statusLabel.Text = string.Format(
                    "Downloading update... {0} / {1} ({2}%)",
                    FormatBytes(bytesReceived), FormatBytes(totalBytes), percent);
            }
            else
            {
                statusLabel.Text = string.Format("Downloading update... {0}", FormatBytes(bytesReceived));
            }
        }

        public void CloseFromBackground()
        {
            if (this.IsDisposed) return;
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new Action(CloseFromBackground));
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private static string FormatBytes(long bytes)
        {
            const long KB = 1024;
            const long MB = KB * 1024;
            const long GB = MB * 1024;
            if (bytes >= GB) return string.Format("{0:0.00} GB", bytes / (double)GB);
            if (bytes >= MB) return string.Format("{0:0.0} MB", bytes / (double)MB);
            if (bytes >= KB) return string.Format("{0:0} KB", bytes / (double)KB);
            return bytes + " B";
        }
    }
}
