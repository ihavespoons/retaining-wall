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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configuraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerTick = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerCheck = new System.ComponentModel.BackgroundWorker();
            this.buttonSetOptions = new System.Windows.Forms.Button();
            this.backgroundWorkerTelnet = new System.ComponentModel.BackgroundWorker();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPassword = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconStatus
            // 
            this.notifyIconStatus.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIconStatus.Text = "VpnClient";
            this.notifyIconStatus.Visible = true;
            this.notifyIconStatus.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconStatus_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 48);
            // 
            // configuraToolStripMenuItem
            // 
            this.configuraToolStripMenuItem.Name = "configuraToolStripMenuItem";
            this.configuraToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.configuraToolStripMenuItem.Text = "Configura";
            this.configuraToolStripMenuItem.Click += new System.EventHandler(this.configuraToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            this.buttonSetOptions.Location = new System.Drawing.Point(745, 50);
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
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.buttonDisconnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDisconnect.BackgroundImage")));
            this.buttonDisconnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.FlatAppearance.BorderSize = 0;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Location = new System.Drawing.Point(375, 61);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(57, 56);
            this.buttonDisconnect.TabIndex = 7;
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.textBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxInfo.Location = new System.Drawing.Point(239, 12);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(496, 492);
            this.textBoxInfo.TabIndex = 8;
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.buttonConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonConnect.BackgroundImage")));
            this.buttonConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonConnect.Enabled = false;
            this.buttonConnect.FlatAppearance.BorderSize = 0;
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Location = new System.Drawing.Point(667, 139);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(46, 49);
            this.buttonConnect.TabIndex = 9;
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Firebrick;
            this.label1.Location = new System.Drawing.Point(571, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "CONNECT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(545, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Disconnect";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.labelPassword);
            this.panel3.Controls.Add(this.buttonReset);
            this.panel3.Location = new System.Drawing.Point(364, 169);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 89);
            this.panel3.TabIndex = 17;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(88, 39);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(35, 13);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "label1";
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.buttonReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonReset.BackgroundImage")));
            this.buttonReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonReset.Enabled = false;
            this.buttonReset.FlatAppearance.BorderSize = 0;
            this.buttonReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReset.Location = new System.Drawing.Point(28, 26);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(39, 39);
            this.buttonReset.TabIndex = 6;
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.labelInfo);
            this.panel4.Location = new System.Drawing.Point(424, 264);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(215, 80);
            this.panel4.TabIndex = 16;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(84, 19);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(40, 13);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Status:";
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(30)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(785, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.buttonSetOptions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FormStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retaining|Wall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormStatus_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconStatus;
        private System.Windows.Forms.Timer timerTick;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCheck;
        private System.Windows.Forms.Button buttonSetOptions;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorkerTelnet;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ToolStripMenuItem configuraToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelInfo;
    }
}

