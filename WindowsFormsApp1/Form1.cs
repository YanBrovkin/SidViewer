using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ToBinaryFormButton_Click(object sender, EventArgs e)
        {
            var securityIdentifier = new SecurityIdentifier(this.sourceSidText.Text);
            var bytes = new byte[securityIdentifier.BinaryLength];
            securityIdentifier.GetBinaryForm(bytes, 0);
            //this.ResultText.Text = ConvertBytesToStringSid(bytes);
            this.ResultText.Text = ByteArrayToVarBinaryString(bytes);
        }

        private void ToStringFormButton_Click(object sender, EventArgs e)
        {
            var bytes = StringVarBinaryToByteArray(this.sourceSidText.Text);
            var securityIdentifier = new SecurityIdentifier(bytes, 0);
            this.ResultText.Text = securityIdentifier.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.sourceSidText.Clear();
            this.ResultText.Clear();
        }

        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern bool ConvertSidToStringSid(IntPtr Sid,ref IntPtr StringSid);

        [DllImport("advapi32", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool ConvertSidToStringSid([MarshalAs(UnmanagedType.LPArray)] byte[] pSID, out IntPtr ptrSid);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr LocalFree(IntPtr hMem);

        private byte[] StringVarBinaryToByteArray(string varBinaryData)
        {
            var byteList = new List<byte>();

            string hexPart = varBinaryData.Substring(2);
            for (int i = 0; i < hexPart.Length / 2; i++)
            {
                string hexNumber = hexPart.Substring(i * 2, 2);
                byteList.Add((byte)Convert.ToInt32(hexNumber, 16));
            }

            return byteList.ToArray();
        }

        private string ByteArrayToVarBinaryString(byte[] bytes)
        {
            return "0x" + BitConverter.ToString(bytes).Replace("-", string.Empty);
        }

        private string ConvertBytesToStringSid(byte[] sidBytes)
        {
            short sSubAuthorityCount = 0;
            StringBuilder strSid = new StringBuilder();
            strSid.Append("S-");
            try
            {
                // Add SID revision.
                strSid.Append(sidBytes[0].ToString());

                sSubAuthorityCount = Convert.ToInt16(sidBytes[1]);

                // Next six bytes are SID authority value.
                if (sidBytes[2] != 0 || sidBytes[3] != 0)
                {
                    string strAuth = String.Format("0x{0:2x}{1:2x}{2:2x}{3:2x}{4:2x}{5:2x}",
                                   (Int16)sidBytes[2],
                                   (Int16)sidBytes[3],
                                   (Int16)sidBytes[4],
                                   (Int16)sidBytes[5],
                                   (Int16)sidBytes[6],
                                   (Int16)sidBytes[7]);
                    strSid.Append("-");
                    strSid.Append(strAuth);
                }
                else
                {
                    Int64 iVal = sidBytes[7] +
                         (sidBytes[6] << 8) +
                         (sidBytes[5] << 16) +
                         (sidBytes[4] << 24);
                    strSid.Append("-");
                    strSid.Append(iVal.ToString());
                }

                // Get sub authority count...
                int idxAuth = 0;
                for (int i = 0; i < sSubAuthorityCount; i++)
                {
                    idxAuth = 8 + i * 4;
                    UInt32 iSubAuth = BitConverter.ToUInt32(sidBytes, idxAuth);
                    strSid.Append("-");
                    strSid.Append(iSubAuth.ToString());
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return strSid.ToString();
        }
    }
}
