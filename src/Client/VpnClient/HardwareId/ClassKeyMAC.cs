namespace HardwareInstallKey
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ClassKeyMAC : ClassKeyBase
    {
        #region Fields

        private string a = "SELECT MACAddress FROM Win32_NetworkAdapter WHERE AdapterTypeId IS NOT NULL AND AdapterTypeId = 0 AND MACAddress IS NOT NULL AND Name <> 'Packet Scheduler Miniport'";

        #endregion Fields

        #region Methods

        public override void FillKey()
        {
            InternalList.Clear();
            foreach (string str in base.Query(this.a))
            {
                InstallIdentifier item = new InstallIdentifier("MACAddress", str);
                InternalList.Add(item);
            }
        }

        #endregion Methods
    }
}