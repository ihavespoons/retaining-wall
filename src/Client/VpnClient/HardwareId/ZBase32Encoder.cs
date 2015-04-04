namespace System.Text
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ZBase32Encoder : Base32Encoder
    {
        #region Fields

        //zBase32 encoding table: See http://zooko.com/repos/z-base-32/base32/DESIGN
        private const string DEF_ENCODING_TABLE = "ybndrfg8ejkmcpqxot1uwisza345h769";
        private const char DEF_PADDING = '=';

        #endregion Fields

        #region Constructors

        public ZBase32Encoder()
            : base(DEF_ENCODING_TABLE, DEF_PADDING)
        {
        }

        #endregion Constructors

        #region Methods

        public override byte[] Decode(string data)
        {
            //Guess the original data size
            int expectedOrigSize = Convert.ToInt32 (Math.Floor (data.Length / 1.6));
            int expectedPaddedLength = 8 * Convert.ToInt32 (Math.Ceiling (expectedOrigSize / 5.0));
            string base32Data = data.PadRight (expectedPaddedLength, DEF_PADDING).ToLower ();

            return base.Decode (base32Data);
        }

        public override string Encode(byte[] input)
        {
            var encoded = base.Encode (input);
            return encoded.TrimEnd (DEF_PADDING);
        }

        #endregion Methods
    }
}