namespace VpnClient
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Text;

    public class LinkStatus
    {
        #region Fields

        private long m_byteCountIn;
        private long m_byteCountOut;
        private bool m_guiConnect;
        private bool m_guiDisconnect;
        private bool m_guiPasswordAvailable;
        private bool m_guiResetLink;
        private bool m_vpnConnected;
        private bool m_vpnWaitForAuthPassword;
        private bool m_vpnWaitForPrivateKeyPassword;
        private bool m_vpnWaitOnHold;

        #endregion Fields

        #region Properties

        public long ByteCountIn
        {
            get { return m_byteCountIn; }
            set
            {
                m_byteCountIn = value;
            }
        }

        public long ByteCountOut
        {
            get { return m_byteCountOut; }
            set
            {
                m_byteCountOut = value;
            }
        }

        public bool GuiConnect
        {
            get { return m_guiConnect; }
            set
            {
                m_guiConnect = value;
            }
        }

        public bool GuiDisconnect
        {
            get { return m_guiDisconnect; }
            set
            {
                m_guiDisconnect = value;
            }
        }

        public bool GuiPasswordAvailable
        {
            get { return m_guiPasswordAvailable; }
            set
            {
                m_guiPasswordAvailable = value;
            }
        }

        public bool GuiResetLink
        {
            get { return m_guiResetLink; }
            set
            {
                m_guiResetLink = value;
            }
        }

        public bool VpnConnected
        {
            get { return m_vpnConnected; }
            set
            {
                m_vpnConnected = value;
            }
        }

        public bool VpnWaitForAuthPassword
        {
            get { return m_vpnWaitForAuthPassword; }
            set
            {
                m_vpnWaitForAuthPassword = value;
            }
        }

        public bool VpnWaitForPrivateKeyPassword
        {
            get { return m_vpnWaitForPrivateKeyPassword; }
            set
            {
                m_vpnWaitForPrivateKeyPassword = value;
            }
        }

        public bool VpnWaitOnHold
        {
            get { return m_vpnWaitOnHold; }
            set
            {
                m_vpnWaitOnHold = value;
            }
        }

        #endregion Properties
    }
}