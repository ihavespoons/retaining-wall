namespace AuthVerify
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    class Program
    {
        #region Methods

        static int Main(string[] args)
        {
            int retValue = 1;

            if (args.Length == 1)
            {
                StreamReader file = File.OpenText(args[0]);
                string username = file.ReadLine();
                string password = file.ReadLine();

                if (username == "admin" && password == "google")
                    retValue = 0;
            }

            return retValue;
        }

        #endregion Methods
    }
}