namespace VpnClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;

    [Serializable]
    public class UserInfo
    {
        #region Fields

        private string m_email;
        private bool m_guiSavePassword;
        private string m_hostToPing;
        private string m_password;
        private string m_privateKeyPassword;
        private string m_username;

        #endregion Fields

        #region Properties

        public string Email
        {
            get { return m_email; }
            set
            {
                m_email = value;
            }
        }

        public bool GuiSavePassword
        {
            get { return m_guiSavePassword; }
            set
            {
                m_guiSavePassword = value;
            }
        }

        public string HostToPing
        {
            get { return m_hostToPing; }
            set
            {
                m_hostToPing = value;
            }
        }

        public string Password
        {
            get { return m_password; }
            set
            {
                m_password = value;
            }
        }

        public string PrivateKeyPassword
        {
            get { return m_privateKeyPassword; }
            set
            {
                m_privateKeyPassword = value;
            }
        }

        public string Username
        {
            get { return m_username; }
            set
            {
                m_username = value;
            }
        }

        #endregion Properties

        #region Methods

        public static UserInfo Deserialize(string filename)
        {
            if (!File.Exists(filename))
                return new UserInfo();

            Stream stream = File.Open(filename, FileMode.Open);
            BinaryFormatter bformatter = new BinaryFormatter();

            UserInfo mp = (UserInfo)bformatter.Deserialize(stream);
            stream.Close();

            return mp;
        }

        public void Serialize(string filename)
        {
            Stream stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();

            bformatter.Serialize(stream, this);
            stream.Close();
        }

        #endregion Methods
    }
}