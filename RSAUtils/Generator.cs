using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAUtils
{
    internal class Generator
    {
        public BigInteger result;

        public void randomGenerator()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            Random rnd = new Random(rng.GetHashCode());
            do
            {
                result = rnd.Next(1000, 1500);
            } while (!isSimple(result));
        }

        public BigInteger NextBigInteger(BigInteger start, BigInteger end)
        {
            if (start == end) return start;

            BigInteger res = end;
            if (start > end)
            {
                end = start;
                start = res;
                res = end - start;
            }
            else
                res -= start;

            byte[] bs = res.ToByteArray();

            int bits = 8;
            byte mask = 0x7F;
            while ((bs[bs.Length - 1] & mask) == bs[bs.Length - 1])
            {
                bits--;
                mask >>= 1;
            }
            bits += 8 * bs.Length;
            return ((NextBigInteger(bits + 1) * res) / BigInteger.Pow(2, bits + 1)) + start;
        }

        public BigInteger NextBigInteger(int bitLength)
        {
            if (bitLength < 1) return BigInteger.Zero;

            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            Random rnd = new Random(rng.GetHashCode());
            int bytes = bitLength / 8;
            int bits = bitLength % 8;

            // Generates enough random bytes to cover our bits.
            byte[] bs = new byte[bytes + 1];
            rnd.NextBytes(bs);

            // Mask out the unnecessary bits.
            byte mask = (byte)(0xFF >> (8 - bits));
            bs[bs.Length - 1] &= mask;

            return new BigInteger(bs);
        }

        public void eGenerator(BigInteger f)
        {
            do
            {
                result = NextBigInteger(1, f);
            } while (GCD(result, f) != 1);
        }

        private BigInteger GCD(BigInteger a, BigInteger b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }
            return a == 0 ? b : a;
        }

        private bool isSimple(BigInteger N)
        {
            for (int i = 2; i <= N / 2; i++)
            {
                if (N % i == 0)
                    return false;
            }
            return true;
        }

        public bool MillerRabinTest(BigInteger k)               //primality test

        {
            if (result == 2 || result == 3)

                return true;

            if (result < 2 || result % 2 == 0)

                return false;

            BigInteger d = result - 1;

            int s = 0;

            while (d % 2 == 0)

            {
                d /= 2;

                s += 1;
            }

            for (int i = 0; i < k; i++)

            {
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();

                byte[] _a = new byte[result.ToByteArray().Length];

                BigInteger a;

                do

                {
                    rng.GetBytes(_a);

                    a = new BigInteger(_a);
                }

                while (a < 2 || a >= result - 2);

                BigInteger x = BigInteger.ModPow(a, d, result);

                if (x == 1 || x == result - 1)

                    continue;

                for (int r = 1; r < s; r++)

                {
                    x = BigInteger.ModPow(x, 2, result);

                    if (x == 1)

                        return false;

                    if (x == result - 1)

                        break;
                }

                if (x != result - 1)

                    return false;
            }

            return true;
        }

        public void GetNearestPrime()                  //get the next prime

        {
            while (MillerRabinTest(10) == false)
            {
                result++;
            }
        }

        public void EulerFunction(BigInteger p, BigInteger q)          //euler function: f(n) = (p-1)(q-1)
        {
            BigInteger m = p - 1;

            BigInteger n = q - 1;

            result = (m * n);
        }

        private static Tuple<BigInteger, BigInteger, BigInteger> ExtendedEuclideanAlgorithm(BigInteger a, BigInteger n)
        {
            if (n == 0) return new Tuple<BigInteger, BigInteger, BigInteger>(a, 1, 0);

            var res = ExtendedEuclideanAlgorithm(n, a % n);
            return new Tuple<BigInteger, BigInteger, BigInteger>(res.Item1, res.Item3, res.Item2 - BigInteger.Divide(a, n) * res.Item3);
        }

        public void getPrivateKey(BigInteger e, BigInteger f)
        {
            Tuple<BigInteger, BigInteger, BigInteger> temp = ExtendedEuclideanAlgorithm(f, e);

            result = (temp.Item3 + f) % f;
        }
    }
}