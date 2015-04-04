namespace VpnClient
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    static class Program
    {
        #region Methods

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormStatus());
        }

        #endregion Methods
    }
}