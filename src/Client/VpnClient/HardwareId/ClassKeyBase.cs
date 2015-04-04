namespace HardwareInstallKey
{
    using System;
    using System.Collections.Generic;
    using System.Management;
    using System.Text;

    public abstract class ClassKeyBase
    {
        #region Fields

        private List<InstallIdentifier> internalList = new List<InstallIdentifier>();

        #endregion Fields

        #region Constructors

        public ClassKeyBase()
        {
            FillKey();
        }

        #endregion Constructors

        #region Properties

        public List<InstallIdentifier> InternalList
        {
            get
            {
                return internalList;
            }
        }

        #endregion Properties

        #region Methods

        public abstract void FillKey();

        public byte[] HashHall()
        {
            int len = 6;
            byte[] val = new byte[len];

            foreach (InstallIdentifier installIdentifier in InternalList)
            {
                byte[] hb = installIdentifier.HashedValueByte;
                for (int i = 0; i < hb.Length; i++)
                {
                    val[i%len] ^= hb[i];
                }
            }

            return val;
        }

        protected internal List<string> Query(string key)
        {
            string str2 = key.Substring(7, key.IndexOf(" ", 7) - 7);
            List<string> list = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(key);
            using (searcher)
            {
                ManagementObjectCollection objects = searcher.Get();
                using (objects)
                {
                    foreach (ManagementObject obj2 in objects)
                    {
                        string item = obj2[str2].ToString().Trim();
                        if ((item.Length > 0) && !list.Contains(item))
                        {
                            list.Add(item);
                        }
                    }
                    return list;
                }
            }
        }

        #endregion Methods
    }
}