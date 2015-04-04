namespace HardwareInstallKey
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ClassKeyHD : ClassKeyBase
    {
        #region Fields

        private string a = "SELECT SerialNumber FROM Win32_PhysicalMedia WHERE SerialNumber IS NOT NULL";
        private string b = "SELECT VolumeSerialNumber FROM Win32_LogicalDisk WHERE VolumeSerialNumber IS NOT NULL";

        #endregion Fields

        #region Methods

        public override void FillKey()
        {
            InstallIdentifier identifier;
            //List<string> list = base.Query(this.a);
            InternalList.Clear();
            foreach (string str in base.Query(this.a))
            {
                identifier = new InstallIdentifier("HardDiskSerial", str);
                InternalList.Add(identifier);
            }
            if (InternalList.Count == 0)
            {
                foreach (string str2 in base.Query(this.b))
                {
                    identifier = new InstallIdentifier("VolumeSerial", str2);
                    InternalList.Add(identifier);
                }
            }
        }

        #endregion Methods
    }
}