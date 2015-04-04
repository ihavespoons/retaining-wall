namespace HardwareInstallKey
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;
    using System.Text;

    public class InstallIdentifier
    {
        #region Fields

        private string type;
        private string value;
        private byte[] valueByte;

        #endregion Fields

        #region Constructors

        public InstallIdentifier()
        {
            this.type = string.Empty;
            this.value = string.Empty;
        }

        public InstallIdentifier(string identifierType, string unhashedValue)
        {
            this.type = identifierType;
            this.SetHashedValue(unhashedValue);
        }

        #endregion Constructors

        #region Properties

        public string HashedValue
        {
            get
            {
                return this.value;
            }
        }

        public byte[] HashedValueByte
        {
            get
            {
                return this.valueByte;
            }
        }

        public string IdentifierType
        {
            get
            {
                return this.type;
            }
        }

        #endregion Properties

        #region Methods

        private byte[] ComputeHashToBytes(string str)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] list = Encoding.Unicode.GetBytes(str);

            return algorithm.ComputeHash(list);
        }

        private void SetHashedValue(string unhashedValue)
        {
            valueByte = ComputeHashToBytes(type + "/" + unhashedValue);
            value = Convert.ToBase64String(valueByte);
        }

        #endregion Methods
    }
}