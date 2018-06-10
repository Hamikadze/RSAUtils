using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAUtils
{
    internal class KnownCrack
    {
        public static Dictionary<BigInteger, char> Crack(int start, int end, BigInteger e, BigInteger n)
        {
            try
            {
                Dictionary<BigInteger, char> encrypt = new Dictionary<BigInteger, char>();
                Crypt Encrypt = new Crypt();
                for (int i = start; !MainForm.CancelOperation && i < end; i++)
                {
                    Encrypt.Encrypt(i, e, n);
                    if (!encrypt.ContainsKey(Encrypt.c))
                        encrypt.Add(Encrypt.c, (char)i);
                }
                List<char> additionalChars = new List<char>() { '—', '–' };
                foreach (var ch in additionalChars)
                {
                    Encrypt.Encrypt((int)ch, e, n);
                    if (!encrypt.ContainsKey(Encrypt.c))
                        encrypt.Add(Encrypt.c, ch);
                }
                return encrypt;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }
    }
}