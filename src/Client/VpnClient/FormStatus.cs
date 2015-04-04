namespace VpnClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Net.NetworkInformation;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public partial class FormStatus : Form
    {
        #region Fields

        private const string STR_Userinfox = "userinfo.xyz";

        private HardwareInstallKey.KeyHasher key = new HardwareInstallKey.KeyHasher("XPSOFT_OPENVPN_1");
        private bool programIsRunning = true;
        private LinkStatus status = new LinkStatus();
        private UserInfo userinfo = new UserInfo();

        #endregion Fields

        #region Constructors

        public FormStatus()
        {
            LoadConfig();

            InitializeComponent();

            this.backgroundWorkerCheck.RunWorkerAsync();
            this.backgroundWorkerTelnet.RunWorkerAsync();

            WinHide();

            if (!status.GuiPasswordAvailable)
                buttonSetOptions_Click(null, null);
        }

        #endregion Constructors

        #region Methods

        private void FormStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            WinHide();
            if (programIsRunning)
                e.Cancel = true;
        }

        private void LoadConfig()
        {
            userinfo = UserInfo.Deserialize(STR_Userinfox);
            userinfo.Username = key.MachineIdStr + "#" + userinfo.Email;

            status.GuiPasswordAvailable = !string.IsNullOrEmpty(userinfo.Email);
        }

        private void SaveConfig()
        {
            if (userinfo.GuiSavePassword)
            {
                userinfo.Serialize(STR_Userinfox);
            }
            else
            {
                string password = userinfo.Password;

                userinfo.Password = string.Empty;
                userinfo.Serialize(STR_Userinfox);
                userinfo.Password = password;
            }
        }

        private void WinHide()
        {
            this.Hide();
            this.WindowState = FormWindowState.Minimized;
        }

        private void WinShow()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void backgroundWorkerCheck_DoWork(object sender, DoWorkEventArgs e)
        {
            Ping ping = new Ping();
            do
            {
                if (!string.IsNullOrEmpty(userinfo.HostToPing))
                {
                    PingReply reply = ping.Send(userinfo.HostToPing, 2000);

                    this.backgroundWorkerCheck.ReportProgress(0, reply);
                }

                Thread.Sleep(4000);

            } while (!this.backgroundWorkerCheck.CancellationPending);
        }

        private void backgroundWorkerCheck_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PingReply reply = e.UserState as PingReply;

            if (reply != null)
            {
                if (reply.Status == IPStatus.Success)
                {
                    this.labelInfo.Text = "Status: LINK OK";
                    this.notifyIconStatus.Icon = Properties.Resources.bullet_ball_green;
                    status.VpnConnected = true;
                }
                else
                {
                    this.labelInfo.Text = "Status: NO LINK";
                    this.notifyIconStatus.Icon = Properties.Resources.bullet_ball_red;
                    status.VpnConnected = false;
                }
            }
        }

        private void backgroundWorkerTelnet_DoWork(object sender, DoWorkEventArgs e)
        {
            TcpClient client = null;
            Telnet telnet = null;

            do
            {
                while (telnet == null && !this.backgroundWorkerTelnet.CancellationPending)
                {
                    try
                    {
                        client = new TcpClient("127.0.0.1", 7000);
                        telnet = new Telnet(client.GetStream());
                    }
                    catch (SocketException)
                    {
                        client = null;
                        telnet = null;

                        Thread.Sleep(1000);
                    }
                }

                if (telnet != null)
                {
                    Thread.Sleep(1000);

                    this.backgroundWorkerTelnet.ReportProgress(0, "--- CONNECTED ---");

                    telnet.WriteLine("log on");

                    telnet.WriteLine("state on");

                    telnet.WriteLine("bytecount 6");
                }

                while (telnet != null && !this.backgroundWorkerTelnet.CancellationPending)
                {
                    try
                    {
                        if (!client.Connected)
                        {
                            this.backgroundWorkerTelnet.ReportProgress(0, "Disconnected, exit loop");
                            break;
                        }

                        string line = telnet.GetLine();

                        if (!string.IsNullOrEmpty(line))
                        {
                            this.backgroundWorkerTelnet.ReportProgress(0, line);

                            if (line.Contains(">HOLD:Waiting for hold release"))
                            {
                                status.VpnWaitOnHold = true;
                            }

                            if (line.Contains(">PASSWORD:Need 'Auth' username/password"))
                            {
                                status.VpnWaitForAuthPassword = true;
                            }

                            if (line.Contains(">PASSWORD:Need 'Private Key' password"))
                            {
                                status.VpnWaitForPrivateKeyPassword = true;
                            }

                            if (line.StartsWith(">BYTECOUNT:"))
                            {
                                string[] str = line.Split(new char[]{':', ','}, StringSplitOptions.RemoveEmptyEntries);
                                if (str.Length == 3)
                                {
                                    long tbin, tbout;
                                    if (long.TryParse(str[1], out tbin) && long.TryParse(str[2], out tbout))
                                    {
                                        status.ByteCountOut = tbout;
                                        status.ByteCountIn = tbin;
                                    }
                                }
                            }
                        }

                        if (status.VpnWaitOnHold && status.GuiPasswordAvailable && status.GuiConnect)
                        {
                            status.VpnWaitOnHold = false;

                            telnet.WriteLine("hold release");

                            this.backgroundWorkerTelnet.ReportProgress(0, "--- HOLD RELEASED ---");
                        }

                        if (status.VpnWaitForAuthPassword && status.GuiPasswordAvailable && status.GuiConnect)
                        {
                            status.VpnWaitForAuthPassword = false;

                            telnet.WriteLine("hold release");

                            telnet.WriteLine("username Auth " + userinfo.Username);

                            telnet.WriteLine("password Auth " + userinfo.Password);

                            this.backgroundWorkerTelnet.ReportProgress(0, "--- AUTH PASSWORD ENTERED ---");
                            this.backgroundWorkerTelnet.ReportProgress(0, "--- " + userinfo.Username + " ---");
                            this.backgroundWorkerTelnet.ReportProgress(0, "--- " + userinfo.Password + " ---");
                            this.backgroundWorkerTelnet.ReportProgress(0, "--- " + userinfo.Email + " ---");
                            this.backgroundWorkerTelnet.ReportProgress(0, "--- --- --- --- --- ---");
                        }

                        if (status.VpnWaitForPrivateKeyPassword && status.GuiPasswordAvailable && status.GuiConnect)
                        {
                            status.VpnWaitForPrivateKeyPassword = false;

                            telnet.WriteLine("hold release");

                            telnet.WriteLine("password 'Private Key' " + userinfo.PrivateKeyPassword);

                            this.backgroundWorkerTelnet.ReportProgress(0, "--- PRIVATE KEY PASSWORD ENTERED ---");
                            this.backgroundWorkerTelnet.ReportProgress(0, "--- " + userinfo.Username + " ---");
                            this.backgroundWorkerTelnet.ReportProgress(0, "--- " + userinfo.Password + " ---");
                            this.backgroundWorkerTelnet.ReportProgress(0, "--- " + userinfo.Email + " ---");
                            this.backgroundWorkerTelnet.ReportProgress(0, "--- --- --- --- --- ---");
                        }

                        if (status.GuiDisconnect)
                        {
                            status.GuiDisconnect = false;
                            status.GuiConnect = false;

                            // deve essere sicuro di essere online
                            // altrimenti openvpn scoppia ...

                            telnet.WriteLine("hold on");

                            telnet.WriteLine("forget-passwords");

                            telnet.WriteLine("signal SIGHUP");

                            this.backgroundWorkerTelnet.ReportProgress(0, "--- LOG OFF ---");
                        }

                        if (status.GuiResetLink)
                        {
                            status.GuiResetLink = false;

                            telnet.WriteLine("signal SIGHUP");

                            this.backgroundWorkerTelnet.ReportProgress(0, "--- RESET LINK ---");
                        }
                    }
                    catch (Exception)
                    {
                        telnet = null;
                    }

                    Thread.Sleep(100);
                }

            } while (!this.backgroundWorkerTelnet.CancellationPending);
        }

        private void backgroundWorkerTelnet_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string line = e.UserState as string;
            if (!string.IsNullOrEmpty(line))
            {
                if (this.textBoxInfo.Text.Length > 10000)
                    this.textBoxInfo.Text = string.Empty;

                this.textBoxInfo.Text += Environment.NewLine + line;
                this.textBoxInfo.SelectionStart = this.textBoxInfo.Text.Length;
                this.textBoxInfo.ScrollToCaret();
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            status.GuiConnect = true;
            status.GuiDisconnect = false;
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            status.GuiDisconnect = true;
            status.GuiConnect = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            status.GuiResetLink = true;
        }

        private void buttonSetOptions_Click(object sender, EventArgs e)
        {
            FormAskPassword password = new FormAskPassword();
            password.Init(userinfo);

            if (password.ShowDialog(this) == DialogResult.OK)
            {
                userinfo.Username = userinfo.Email;
                status.GuiPasswordAvailable = true;

                SaveConfig();
            }
        }

        private void configuraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            programIsRunning = false;
            Application.Exit();
        }

        private void notifyIconStatus_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            WinShow();
        }

        private void timerTick_Tick(object sender, EventArgs e)
        {
            if (status.GuiPasswordAvailable)
            {
                this.labelPassword.Text = "Registered to: " + userinfo.Email;

                if (status.VpnConnected)
                {
                    // SONO CONNESSO
                    this.buttonConnect.Enabled = false;
                    this.buttonDisconnect.Enabled = !status.GuiDisconnect;
                    this.buttonReset.Enabled = false;
                }
                else
                {
                    // NON SONO CONNESSO
                    this.buttonConnect.Enabled = !status.GuiConnect;
                    this.buttonDisconnect.Enabled = false;
                    this.buttonReset.Enabled = true;
                }
            }
            else
            {
                if (status.VpnConnected)
                    this.labelPassword.Text = "no password set, but you are already connected ...";
                else
                    this.labelPassword.Text = "Please, enter password to start the connection.";

                this.buttonConnect.Enabled = false;
                this.buttonDisconnect.Enabled = false;
                this.buttonReset.Enabled = false;
            }
        }

        #endregion Methods

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}