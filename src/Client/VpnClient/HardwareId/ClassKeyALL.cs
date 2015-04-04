namespace HardwareInstallKey
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ClassKeyALL : ClassKeyBase
    {
        #region Constructors

        public ClassKeyALL(string sw)
        {
            InternalList.Add(new InstallIdentifier(string.Empty, sw));
        }

        #endregion Constructors

        #region Methods

        public override void FillKey()
        {
            ClassKeyBIOS bios = new ClassKeyBIOS();
            ClassKeyCPU cpu = new ClassKeyCPU();
            ClassKeyHD hd = new ClassKeyHD();
            //ClassKeyMAC mac = new ClassKeyMAC();

            InternalList.AddRange(bios.InternalList);
            InternalList.AddRange(cpu.InternalList);
            InternalList.AddRange(hd.InternalList);
            //InternalList.AddRange(mac.InternalList);
        }

        #endregion Methods
    }
}