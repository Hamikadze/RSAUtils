using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAUtils
{
    internal class GenParams
    {
        public static Generator P;

        public static Generator Q;

        public static Generator Exp;

        public static Generator F;

        public static Generator priv_key;

        public static Crypt Encrypt;

        public static Crypt Plain;

        public static BigInteger N = 0;

        public static Dictionary<string, BigInteger> GenerateParams(BigInteger m)
        {
            try
            {
                var items = new Dictionary<string, BigInteger>();
                P = new Generator();
                Q = new Generator();
                Exp = new Generator();
                F = new Generator();
                priv_key = new Generator();
                Encrypt = new Crypt();
                Plain = new Crypt();
                P.randomGenerator();

                Q.randomGenerator();

                //P.result = 61;
                //Q.result = 53;
                if (P.MillerRabinTest(10) && Q.MillerRabinTest(10))
                {
                    N = P.result * Q.result;
                }
                else
                {
                    P.GetNearestPrime();
                    Q.GetNearestPrime();
                    N = P.result * Q.result;
                }
                F.EulerFunction(P.result, Q.result);
                Exp.eGenerator(F.result);

                //Exp.result = 17;

                priv_key.getPrivateKey(Exp.result, F.result);

                Encrypt.Encrypt(m, Exp.result, N);

                Plain.Decrypt(Encrypt.c, priv_key.result, N);

                items.Clear();
                items.Add("p", P.result);
                items.Add("q", Q.result);
                items.Add("n", N);
                items.Add("f", F.result);
                items.Add("Публичный ключ (e)", Exp.result);
                items.Add("Приватный ключ (d)", priv_key.result);
                items.Add("Зашифрованное число (c)", Encrypt.c);
                items.Add("Расшифрованное число (m)", Plain.m);
                return items;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
    }
}