using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAUtils
{
    internal class CyclicCrack
    {
        public static Dictionary<string, BigInteger> Crack(BigInteger c, BigInteger e, BigInteger n)
        {
            try
            {
                var items = new Dictionary<string, BigInteger>();
                BigInteger current = c;
                BigInteger last = c;
                int k = 0;
                do
                {
                    k++;
                    last = current;
                    current = BigInteger.ModPow(current, e, n);
                } while (!MainForm.CancelOperation && current != c);
                items.Clear();
                items.Add("Количество итераций (k)", k);

                if (!MainForm.CancelOperation)
                    items.Add("Исходное число (m)", last);
                return items;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                throw;
            }
        }
    }
}