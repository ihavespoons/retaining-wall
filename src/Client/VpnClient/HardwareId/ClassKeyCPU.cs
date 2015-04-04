namespace HardwareInstallKey
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ClassKeyCPU : ClassKeyBase
    {
        #region Fields

        private string a = "SELECT ProcessorId FROM Win32_Processor WHERE ProcessorId IS NOT NULL";

        #endregion Fields

        #region Methods

        public override void FillKey()
        {
            InternalList.Clear();
            foreach (string str in base.Query(this.a))
            {
                InstallIdentifier item = new InstallIdentifier("ProcessorID", str);
                InternalList.Add(item);
            }
        }

        #endregion Methods
    }
}