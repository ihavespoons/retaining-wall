namespace HardwareInstallKey
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class KeyHasher
    {
        #region Fields

        private byte[] machineId;
        private string machineIdStr;
        private string softwareId;

        #endregion Fields

        #region Constructors

        public KeyHasher(string sw)
        {
            softwareId = sw;
            ClassKeyALL all = new ClassKeyALL(softwareId);

            machineId = all.HashHall();
            machineIdStr = GetStr(machineId);
        }

        #endregion Constructors

        #region Properties

        public string MachineIdStr
        {
            get
            {
                return machineIdStr;
            }
        }

        #endregion Properties

        #region Methods

        // Costruisce il codice di autorizzazione per la macchina indicata in "codice"
        public string GetAuthCode(string codice)
        {
            byte[] array = GetArray(codice);
            if (array == null)
                return string.Empty;

            machineId = array;
            machineIdStr = string.Empty;

            return GetAuthCode();
        }

        // Costruisce il codice di autorizzazione per la macchina indicata in machineId
        public string GetAuthCode()
        {
            InstallIdentifier keysw = new InstallIdentifier(string.Empty, softwareId);
            byte[] array = new byte[machineId.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] ^= machineId[i];
                array[i] ^= keysw.HashedValueByte[i % keysw.HashedValueByte.Length];
            }

            return GetStr(array);
        }

        public bool VerifyAuthCode(string codice)
        {
            byte[] array = GetArray(codice);
            if (array == null)
                return false;

            if (array.Length == machineId.Length)
            {
                InstallIdentifier keysw = new InstallIdentifier(string.Empty, softwareId);

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] ^= machineId[i];
                    array[i] ^= keysw.HashedValueByte[i % keysw.HashedValueByte.Length];
                    if (array[i] != 0)
                        return false;
                }

                return true;
            }

            return false;
        }

        private static byte[] GetArray(string codice)
        {
            try
            {
                if (string.IsNullOrEmpty(codice))
                    return null;

                codice = codice.Replace("-", string.Empty);
                codice = codice.Replace(".", string.Empty);
                codice = codice.Replace("_", string.Empty);

                ZBase32Encoder decoder = new ZBase32Encoder();
                return decoder.Decode(codice);
            }
            catch (Exception)
            {
                return null;
            }

            //codice = codice.Replace(".", string.Empty);
            //int len = codice.Length;
            //codice = codice + "0000";

            //List<byte> valori = new List<byte>();

            //for (int i = 0; i < len; i += 2)
            //{
            //    string val = codice.Substring(i, 2);
            //    byte bb = 0;
            //    if (byte.TryParse(val, System.Globalization.NumberStyles.HexNumber, null, out bb))
            //        valori.Add(bb);
            //}

            //byte[] array = valori.ToArray();
            //return array;
        }

        private static string GetStr(byte[] array)
        {
            ZBase32Encoder encoder = new ZBase32Encoder();
            string result = encoder.Encode(array);

            return result.ToUpper();
            //string str = string.Empty;
            //foreach (byte b in array)
            //{
            //    str += string.Format("{0:x2}", b);
            //    if (str.Length == 4 || str.Length == 9)
            //        str += ".";
            //}
            //return str;
        }

        #endregion Methods
    }
}