namespace VpnClient
{
    partial class FormStatus
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatus));
            this.notifyIconStatus = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerCheck = new System.ComponentModel.BackgroundWorker();
            this.buttonSetOptions = new System.Windows.Forms.Button();
            this.backgroundWorkerTelnet = new System.ComponentModel.BackgroundWorker();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buttonConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonReset = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mynotifyicon = new System.Windows.Forms.NotifyIcon(this.components);
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonMinimise = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIconStatus
            // 
            this.notifyIconStatus.Text = "VpnClient";
            this.notifyIconStatus.Visible = true;
            this.notifyIconStatus.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconStatus_MouseDoubleClick);
            // 
            // timerTick
            // 
            this.timerTick.Enabled = true;
            this.timerTick.Interval = 500;
            this.timerTick.Tick += new System.EventHandler(this.timerTick_Tick);
            // 
            // backgroundWorkerCheck
            // 
            this.backgroundWorkerCheck.WorkerReportsProgress = true;
            this.backgroundWorkerCheck.WorkerSupportsCancellation = true;
            this.backgroundWorkerCheck.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerCheck_DoWork);
            this.backgroundWorkerCheck.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerCheck_ProgressChanged);
            // 
            // buttonSetOptions
            // 
            this.buttonSetOptions.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSetOptions.BackgroundImage")));
            this.buttonSetOptions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSetOptions.FlatAppearance.BorderSize = 0;
            this.buttonSetOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetOptions.Location = new System.Drawing.Point(707, 12);
            this.buttonSetOptions.Name = "buttonSetOptions";
            this.buttonSetOptions.Size = new System.Drawing.Size(28, 29);
            this.buttonSetOptions.TabIndex = 0;
            this.buttonSetOptions.UseVisualStyleBackColor = true;
            this.buttonSetOptions.Click += new System.EventHandler(this.buttonSetOptions_Click);
            // 
            // backgroundWorkerTelnet
            // 
            this.backgroundWorkerTelnet.WorkerReportsProgress = true;
            this.backgroundWorkerTelnet.WorkerSupportsCancellation = true;
            this.backgroundWorkerTelnet.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerTelnet_DoWork);
            this.backgroundWorkerTelnet.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerTelnet_ProgressChanged);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(17)))));
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxInfo.Location = new System.Drawing.Point(12, 90);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(761, 414);
            this.textBoxInfo.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(741, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonConnect,
            this.buttonDisconnect,
            this.buttonReset});
            this.menuStrip1.Location = new System.Drawing.Point(12, 58);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(245, 29);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(79, 25);
            this.buttonConnect.Text = "Connect";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisconnect.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(98, 25);
            this.buttonDisconnect.Text = "Disconnect";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(60, 25);
            this.buttonReset.Text = "Reset";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 43);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Retaining|Wall";
            // 
            // mynotifyicon
            // 
            this.mynotifyicon.Icon = ((System.Drawing.Icon)(resources.GetObject("mynotifyicon.Icon")));
            this.mynotifyicon.Text = "Retaining|Wall";
            this.mynotifyicon.Visible = true;
            this.mynotifyicon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelInfo.Location = new System.Drawing.Point(201, 31);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(0, 13);
            this.labelInfo.TabIndex = 21;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelPassword.Location = new System.Drawing.Point(586, 58);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(0, 13);
            this.labelPassword.TabIndex = 22;
            // 
            // buttonMinimise
            // 
            this.buttonMinimise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.buttonMinimise.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimise.BackgroundImage")));
            this.buttonMinimise.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimise.FlatAppearance.BorderSize = 0;
            this.buttonMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimise.Location = new System.Drawing.Point(676, 14);
            this.buttonMinimise.Name = "buttonMinimise";
            this.buttonMinimise.Size = new System.Drawing.Size(25, 27);
            this.buttonMinimise.TabIndex = 23;
            this.buttonMinimise.UseVisualStyleBackColor = false;
            this.buttonMinimise.Click += new System.EventHandler(this.buttonMinimise_Click);
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(785, 516);
            this.Controls.Add(this.buttonMinimise);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetOptions);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retaining|Wall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStatus_FormClosing);
            this.Load += new System.EventHandler(this.FormStatus_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconStatus;
        private System.Windows.Forms.Timer timerTick;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCheck;
        private System.Windows.Forms.Button buttonSetOptions;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTelnet;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buttonConnect;
        private System.Windows.Forms.ToolStripMenuItem buttonDisconnect;
        private System.Windows.Forms.ToolStripMenuItem buttonReset;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon mynotifyicon;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonMinimise;
    }
}

