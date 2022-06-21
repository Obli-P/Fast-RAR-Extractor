namespace Fast_RAR_Extractor
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.backgroundWorkerMain = new System.ComponentModel.BackgroundWorker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.obtainFilePath = new System.Windows.Forms.OpenFileDialog();
            this.labelStatus = new System.Windows.Forms.Label();
            this.btnSelectDestinationFolder = new System.Windows.Forms.Button();
            this.obtainDestinationFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.btnStart = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(706, 48);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // backgroundWorkerMain
            // 
            this.backgroundWorkerMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMain_DoWork);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(648, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(58, 48);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMinimize.Location = new System.Drawing.Point(590, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(58, 48);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.Text = "-";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.btnStart);
            this.panelMain.Controls.Add(this.btnSelectDestinationFolder);
            this.panelMain.Controls.Add(this.labelStatus);
            this.panelMain.Controls.Add(this.btnSelectFile);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 48);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(706, 456);
            this.panelMain.TabIndex = 1;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelectFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFile.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelectFile.Location = new System.Drawing.Point(12, 16);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(276, 76);
            this.btnSelectFile.TabIndex = 2;
            this.btnSelectFile.Text = "SELECT ZIP OR RAR FILE";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // obtainFilePath
            // 
            this.obtainFilePath.FileName = "openFileDialog1";
            // 
            // labelStatus
            // 
            this.labelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelStatus.Font = new System.Drawing.Font("Lato", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelStatus.Location = new System.Drawing.Point(0, 387);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(706, 69);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "...";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectDestinationFolder
            // 
            this.btnSelectDestinationFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSelectDestinationFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelectDestinationFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectDestinationFolder.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectDestinationFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelectDestinationFolder.Location = new System.Drawing.Point(418, 16);
            this.btnSelectDestinationFolder.Name = "btnSelectDestinationFolder";
            this.btnSelectDestinationFolder.Size = new System.Drawing.Size(276, 76);
            this.btnSelectDestinationFolder.TabIndex = 4;
            this.btnSelectDestinationFolder.Text = "SELECT DESTINATION FOLDER";
            this.btnSelectDestinationFolder.UseVisualStyleBackColor = true;
            this.btnSelectDestinationFolder.Click += new System.EventHandler(this.btnSelectDestinationFolder_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.Location = new System.Drawing.Point(215, 173);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(276, 124);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(59)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(706, 504);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMain;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.OpenFileDialog obtainFilePath;
        private System.Windows.Forms.Button btnSelectDestinationFolder;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.FolderBrowserDialog obtainDestinationFolder;
        private System.Windows.Forms.Button btnStart;
    }
}

