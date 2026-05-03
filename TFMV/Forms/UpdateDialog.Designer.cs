namespace TFMV.Forms
{
    partial class UpdateDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateDialog));
            this.header = new System.Windows.Forms.Label();
            this.versionsLabel = new System.Windows.Forms.Label();
            this.notesBox = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnLater = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.header.Location = new System.Drawing.Point(16, 16);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(257, 20);
            this.header.TabIndex = 0;
            this.header.Text = "A new version of TFMV is available!";
            // 
            // versionsLabel
            // 
            this.versionsLabel.AutoSize = true;
            this.versionsLabel.Location = new System.Drawing.Point(16, 48);
            this.versionsLabel.Name = "versionsLabel";
            this.versionsLabel.Size = new System.Drawing.Size(0, 13);
            this.versionsLabel.TabIndex = 1;
            // 
            // notesBox
            // 
            this.notesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notesBox.Location = new System.Drawing.Point(16, 48);
            this.notesBox.Multiline = true;
            this.notesBox.Name = "notesBox";
            this.notesBox.ReadOnly = true;
            this.notesBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notesBox.Size = new System.Drawing.Size(737, 298);
            this.notesBox.TabIndex = 3;
            this.notesBox.Text = resources.GetString("notesBox.Text");
            //
            // btnDownload
            //
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnDownload.Location = new System.Drawing.Point(383, 359);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(120, 28);
            this.btnDownload.TabIndex = 4;
            this.btnDownload.Text = "Download Update";
            this.btnDownload.UseVisualStyleBackColor = true;
            //
            // btnSkip
            //
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnSkip.Location = new System.Drawing.Point(511, 359);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(130, 28);
            this.btnSkip.TabIndex = 5;
            this.btnSkip.Text = "Skip This Version";
            this.btnSkip.UseVisualStyleBackColor = true;
            //
            // btnLater
            //
            this.btnLater.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnLater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btnLater.Location = new System.Drawing.Point(649, 359);
            this.btnLater.Name = "btnLater";
            this.btnLater.Size = new System.Drawing.Size(104, 28);
            this.btnLater.TabIndex = 6;
            this.btnLater.Text = "Not Now";
            this.btnLater.UseVisualStyleBackColor = true;
            // 
            // UpdateDialog
            // 
            this.AcceptButton = this.btnDownload;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.CancelButton = this.btnLater;
            this.ClientSize = new System.Drawing.Size(770, 398);
            this.Controls.Add(this.btnLater);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.notesBox);
            this.Controls.Add(this.versionsLabel);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TFMV Update Available";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label versionsLabel;
        private System.Windows.Forms.TextBox notesBox;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnLater;
    }
}
