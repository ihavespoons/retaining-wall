namespace VpnClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Sockets;
    using System.Text;

    public class Telnet
    {
        #region Fields

        StringBuilder buffer = new StringBuilder();
        LinkedList<string> linee = new LinkedList<string>();
        NetworkStream m_NetStream;

        #endregion Fields

        #region Constructors

        public Telnet(NetworkStream netStream)
        {
            m_NetStream = netStream;
            m_NetStream.ReadTimeout = 1000;
        }

        #endregion Constructors

        #region Methods

        public string GetLine()
        {
            while (m_NetStream.DataAvailable)
            {
                int singlebyte = m_NetStream.ReadByte();
                if (singlebyte >= 0)
                {
                    if (singlebyte == 10 || singlebyte == 13)
                    {
                        if (buffer.Length > 0)
                        {
                            linee.AddLast(buffer.ToString());
                            buffer = new StringBuilder();
                        }
                    }
                    else
                        buffer.Append(Convert.ToChar((byte)singlebyte));
                }
            }

            if (linee.Count > 0)
            {
                string str = linee.First.Value;
                linee.RemoveFirst();

                return str;
            }

            return null;
        }

        public void WriteLine(string line)
        {
            line = line + Environment.NewLine;
            byte[] array = System.Text.Encoding.Default.GetBytes(line);
            m_NetStream.Write(
                array, 0, array.Length);
        }

        #endregion Methods
    }
}