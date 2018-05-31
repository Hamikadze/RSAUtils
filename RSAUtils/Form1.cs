using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Windows.Forms;

namespace RSAUtils
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private Generator P;

        private Generator Q;

        private Generator Exp;

        private Generator F;

        private Generator priv_key;

        private Crypt Encrypt;

        private Crypt Plain;

        private BigInteger N = 0;

        private void funk()
        {
            try
            {
                P = new Generator();
                Q = new Generator();
                Exp = new Generator();
                F = new Generator();
                priv_key = new Generator();
                Encrypt = new Crypt();
                Plain = new Crypt();
                Dictionary<string, string> items = new Dictionary<string, string>();
                string msg = OriginalInputTBox.Text;
                BigInteger m;
                if (!BigInteger.TryParse(msg, out m))
                {
                    MessageBox.Show("Недопустимые входные данные исходного числа.");
                    OriginalInputTBox.Clear();
                    return;
                };
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
                items.Add("p", P.result.ToString());
                items.Add("q", Q.result.ToString());
                items.Add("n", N.ToString());
                items.Add("f", F.result.ToString());
                items.Add("Публичный ключ (e)", Exp.result.ToString());
                items.Add("Приватный ключ (d)", priv_key.result.ToString());
                items.Add("Зашифрованное число (c)", Encrypt.c.ToString());
                items.Add("Расшифрованное число (m)", Plain.m.ToString());
                EncryptDataLView.Items.Clear();
                EncryptDataLView.Items.AddRange(items.ToList().ConvertAll(i => new ListViewItem() { Text = i.Key, SubItems = { i.Value } }).ToArray());
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funk();
        }

        private void Crack(BigInteger c, BigInteger e, BigInteger n)
        {
            Dictionary<string, string> items = new Dictionary<string, string>();
            int k = 0;

            do
            {
                k++;
            }
            while (BigInteger.ModPow(c, BigInteger.Pow(e, k), n) != c);
            items.Clear();
            items.Add("Количество итераций (k)", k.ToString());
            items.Add("Исходное число (m)", BigInteger.ModPow(c, BigInteger.Pow(e, k - 1), n).ToString());
            CrackDataLView.Items.Clear();
            CrackDataLView.Items.AddRange(items.ToList().ConvertAll(i => new ListViewItem() { Text = i.Key, SubItems = { i.Value } }).ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BigInteger c;
            BigInteger exp;
            BigInteger n;
            if (!BigInteger.TryParse(EncryptInputTBox.Text, out c))
            {
                MessageBox.Show("Недопустимые входные данные секретного ключа.");
                OriginalInputTBox.Clear();
                return;
            };

            if (!BigInteger.TryParse(EInputTBox.Text, out exp))
            {
                MessageBox.Show("Недопустимые входные данные e.");
                OriginalInputTBox.Clear();
                return;
            };

            if (!BigInteger.TryParse(NInputTBox.Text, out n))
            {
                MessageBox.Show("Недопустимые входные данные n.");
                OriginalInputTBox.Clear();
                return;
            };
            Crack(c, exp, n);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void KeyFilter(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ShowAttention(Control e, int lenght)
        {
            ToolTip toolTip = new ToolTip();
            string text = "Можно вводить только целые числа" + (lenght == -1 ? "" : $"длинны меньше {lenght}");
            toolTip.SetToolTip(e, text);
        }

        private void OriginalInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(OriginalInputTBox, 7);
        }

        private void CrackDataLView_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyFilter(e);
        }

        private void NInputTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyFilter(e);
        }

        private void EInputTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyFilter(e);
        }

        private void EncryptInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(EncryptInputTBox, -1);
        }

        private void NInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(NInputTBox, -1);
        }

        private void EInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(EInputTBox, -1);
        }

        private void EncryptDataLView_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(EncryptDataLView.SelectedItems[0].SubItems[1].Text);
        }

        private void UseKnownСBox_CheckedChanged(object sender, EventArgs e)
        {
            switch (UseKnownСBox.Checked)
            {
                case true:
                    if (Encrypt == null || Exp == null || N == 0)
                    {
                        MessageBox.Show("Сначала сгенерируйте параметры.");
                        UseKnownСBox.Checked = false;
                        return;
                    }
                    EncryptInputTBox.Enabled = EInputTBox.Enabled = NInputTBox.Enabled = false;
                    EncryptInputTBox.Text = Encrypt.c.ToString();
                    EInputTBox.Text = Exp.result.ToString();
                    NInputTBox.Text = N.ToString();
                    break;

                case false:
                    EncryptInputTBox.Enabled = EInputTBox.Enabled = NInputTBox.Enabled = true;
                    EncryptInputTBox.Clear();
                    EInputTBox.Clear();
                    NInputTBox.Clear();
                    break;
            }
        }
    }
}