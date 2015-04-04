namespace VpnClient
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;

    public partial class FormAskPassword : Form
    {
        #region Fields

        private UserInfo m_Info;

        #endregion Fields

        #region Constructors

        public FormAskPassword()
        {
            InitializeComponent();
        }

        #endregion Constructors

        #region Methods

        public void Init(UserInfo info)
        {
            m_Info = info;

            this.textBoxHost.Text = m_Info.HostToPing;
            this.textBoxPrivateKey.Text = m_Info.PrivateKeyPassword;
            this.textBoxPassword.Text = m_Info.Password;
            this.textBoxEmail.Text = m_Info.Email;
            this.checkBoxSave.Checked = m_Info.GuiSavePassword;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            m_Info.HostToPing = this.textBoxHost.Text;
            m_Info.PrivateKeyPassword = this.textBoxPrivateKey.Text;
            m_Info.Password = this.textBoxPassword.Text;
            m_Info.Email = this.textBoxEmail.Text;
            m_Info.GuiSavePassword = this.checkBoxSave.Checked;

            DialogResult = DialogResult.OK;
        }

        #endregion Methods

        private void FormAskPassword_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}