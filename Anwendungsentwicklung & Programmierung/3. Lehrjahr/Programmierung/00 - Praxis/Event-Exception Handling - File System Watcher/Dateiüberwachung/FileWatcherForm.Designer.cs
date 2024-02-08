
namespace Dateiüberwachung
{
    partial class FileWatcherForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPfad = new System.Windows.Forms.Label();
            this.txtPfad = new System.Windows.Forms.TextBox();
            this.chkSubFolder = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.fsWatcher = new System.IO.FileSystemWatcher();
            this.fbDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_fbDialog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPfad
            // 
            this.lblPfad.AutoSize = true;
            this.lblPfad.Location = new System.Drawing.Point(12, 9);
            this.lblPfad.MinimumSize = new System.Drawing.Size(232, 13);
            this.lblPfad.Name = "lblPfad";
            this.lblPfad.Size = new System.Drawing.Size(232, 13);
            this.lblPfad.TabIndex = 0;
            this.lblPfad.Text = "Bitte geben Sie den Pfad zur Überwachung ein!";
            this.lblPfad.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPfad
            // 
            this.txtPfad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPfad.Location = new System.Drawing.Point(15, 25);
            this.txtPfad.MinimumSize = new System.Drawing.Size(200, 20);
            this.txtPfad.Name = "txtPfad";
            this.txtPfad.Size = new System.Drawing.Size(396, 20);
            this.txtPfad.TabIndex = 1;
            // 
            // chkSubFolder
            // 
            this.chkSubFolder.AutoSize = true;
            this.chkSubFolder.Location = new System.Drawing.Point(15, 68);
            this.chkSubFolder.Name = "chkSubFolder";
            this.chkSubFolder.Size = new System.Drawing.Size(176, 17);
            this.chkSubFolder.TabIndex = 2;
            this.chkSubFolder.Text = "Unterverzeichnisse einbeziehen";
            this.chkSubFolder.UseVisualStyleBackColor = true;
            this.chkSubFolder.Click += new System.EventHandler(this.chkSubFolder_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(15, 110);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(125, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "St&arte Überwachung";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(367, 110);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(125, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "St&oppe Überwachung";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lstFiles
            // 
            this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.Location = new System.Drawing.Point(15, 153);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(477, 199);
            this.lstFiles.TabIndex = 5;
            // 
            // btnBeenden
            // 
            this.btnBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeenden.Location = new System.Drawing.Point(367, 366);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(125, 23);
            this.btnBeenden.TabIndex = 6;
            this.btnBeenden.Text = "B&eenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // fsWatcher
            // 
            this.fsWatcher.SynchronizingObject = this;
            this.fsWatcher.Changed += new System.IO.FileSystemEventHandler(this.fsWatcher_Changed);
            this.fsWatcher.Created += new System.IO.FileSystemEventHandler(this.fsWatcher_Created);
            this.fsWatcher.Deleted += new System.IO.FileSystemEventHandler(this.fsWatcher_Deleted);
            this.fsWatcher.Renamed += new System.IO.RenamedEventHandler(this.fsWatcher_Renamed);
            // 
            // btn_fbDialog
            // 
            this.btn_fbDialog.Location = new System.Drawing.Point(417, 25);
            this.btn_fbDialog.Name = "btn_fbDialog";
            this.btn_fbDialog.Size = new System.Drawing.Size(75, 23);
            this.btn_fbDialog.TabIndex = 7;
            this.btn_fbDialog.Text = "...";
            this.btn_fbDialog.UseVisualStyleBackColor = true;
            this.btn_fbDialog.Click += new System.EventHandler(this.btn_fbDialog_Click);
            // 
            // FileWatcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 401);
            this.Controls.Add(this.btn_fbDialog);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.chkSubFolder);
            this.Controls.Add(this.txtPfad);
            this.Controls.Add(this.lblPfad);
            this.Name = "FileWatcherForm";
            this.Text = "Überwachen eines Ordners";
            ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPfad;
        private System.Windows.Forms.TextBox txtPfad;
        private System.Windows.Forms.CheckBox chkSubFolder;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnBeenden;
        private System.IO.FileSystemWatcher fsWatcher;
        private System.Windows.Forms.Button btn_fbDialog;
        private System.Windows.Forms.FolderBrowserDialog fbDialog;
    }
}

