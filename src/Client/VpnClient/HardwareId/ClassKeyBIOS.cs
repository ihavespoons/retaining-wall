namespace HardwareInstallKey
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ClassKeyBIOS : ClassKeyBase
    {
        #region Fields

        private string a = "SELECT Version FROM Win32_BIOS WHERE Version IS NOT NULL";

        #endregion Fields

        #region Methods

        public override void FillKey()
        {
            InternalList.Clear();
            foreach (string str in base.Query(this.a))
            {
                InstallIdentifier item = new InstallIdentifier("BIOSVersion", str);
                InternalList.Add(item);
            }
        }

        #endregion Methods
    }
}