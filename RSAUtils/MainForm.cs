using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAUtils
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public static MainForm MainFornLink;

        private void Form1_Load(object sender, EventArgs e)
        {
            MainFornLink = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                BigInteger m;
                if (!BigInteger.TryParse(OriginalInputTBox.Text, out m))
                {
                    MessageBox.Show("Недопустимые входные данные параметра (m)");
                    OriginalInputTBox.Clear();
                    return;
                };
                var items = GenParams.GenerateParams(m);

                EncryptDataLView.Items.Clear();
                EncryptDataLView.Items.AddRange(items.ToList().ConvertAll(i => new ListViewItem() { Text = i.Key, SubItems = { i.Value.ToString() } }).ToArray());
                if (UseKnownСBox.Checked)
                {
                    UseKnownСBox_CheckedChanged(null, EventArgs.Empty);
                }
            }
            catch (Exception)
            {
                // ignored
            }
        }

        private Thread crackThread;

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MainFornLink.GTabControl.Enabled = false;
                MainFornLink.CancelPanel.Visible = true;
                BigInteger c;
                BigInteger exp;
                BigInteger n;
                if (!BigInteger.TryParse(EncryptInputTBox.Text, out c))
                {
                    MessageBox.Show("Недопустимые входные данные параметра (c)");
                    EncryptInputTBox.Clear();
                    return;
                };

                if (!BigInteger.TryParse(EInputTBox.Text, out exp))
                {
                    MessageBox.Show("Недопустимые входные данные параметра (e)");
                    EInputTBox.Clear();
                    return;
                };

                if (!BigInteger.TryParse(NInputTBox.Text, out n))
                {
                    MessageBox.Show("Недопустимые входные данные параметра (n)");
                    NInputTBox.Clear();
                    return;
                };

                Task.Factory.StartNew(() =>
                {
                    var items = CyclicCrack.Crack(c, exp, n);
                    MainFornLink.BeginInvoke(new Action(() =>
                    {
                        CrackDataLView.Items.Clear();
                        CrackDataLView.Items.AddRange(items.ToList().ConvertAll(i => new ListViewItem() { Text = i.Key, SubItems = { i.Value.ToString() } }).ToArray());
                        MainFornLink.GTabControl.Enabled = true;
                        MainFornLink.CancelPanel.Visible = false;
                    }));
                });
            }
            catch (Exception)
            {
                MainFornLink.GTabControl.Enabled = true;
                MainFornLink.CancelPanel.Visible = false;
                //ignored
            }
        }

        private void KeyFilter(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ShowAttention(Control e, string text)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(e, text);
        }

        private void OriginalInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(OriginalInputTBox, "Можно вводить только целые числа длинны меньше 7");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void EncryptInputTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyFilter(e);
        }

        private void EncryptInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(EncryptInputTBox, "Можно вводить только целые числа");
        }

        private void NInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(NInputTBox, "Можно вводить только целые числа");
        }

        private void EInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(EInputTBox, "Можно вводить только целые числа");
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
                    if (GenParams.Encrypt == null || GenParams.Exp == null || GenParams.N == 0)
                    {
                        MessageBox.Show("Сначала сгенерируйте параметры.");
                        UseKnownСBox.Checked = false;
                        return;
                    }
                    EncryptInputTBox.Enabled = EInputTBox.Enabled = NInputTBox.Enabled = false;
                    EncryptInputTBox.Text = GenParams.Encrypt.c.ToString();
                    EInputTBox.Text = GenParams.Exp.result.ToString();
                    NInputTBox.Text = GenParams.N.ToString();
                    break;

                case false:
                    EncryptInputTBox.Enabled = EInputTBox.Enabled = NInputTBox.Enabled = true;
                    EncryptInputTBox.Clear();
                    EInputTBox.Clear();
                    NInputTBox.Clear();
                    break;
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CancelOperation = true;
        }

        public static bool CancelOperation;

        private void CancelPanel_VisibleChanged(object sender, EventArgs e)
        {
            CancelOperation = false;
        }

        private void KnownCrackBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MainFornLink.GTabControl.Enabled = false;
                MainFornLink.CancelPanel.Visible = true;
                BigInteger exp;
                BigInteger n;
                if (!BigInteger.TryParse(KnownEInputTBox.Text, out exp))
                {
                    MessageBox.Show("Недопустимые входные данные параметра (e)");
                    EInputTBox.Clear();
                    return;
                };

                if (!BigInteger.TryParse(KnownNInputTBox.Text, out n))
                {
                    MessageBox.Show("Недопустимые входные данные параметра (n)");
                    NInputTBox.Clear();
                    return;
                };
                int start = (int)StartBorderUpDown.Value;
                int last = (int)LastBorderUpDown.Value;
                string encryptText = KnownEncryptRichTBox.Text;
                Regex regex = new Regex(@"\D");
                encryptText = regex.Replace(encryptText, " ");
                var encryptChars = encryptText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList().ConvertAll(BigInteger.Parse);
                KnownDecryptRichTBox.Clear();
                Task.Factory.StartNew(() =>
                {
                    Dictionary<BigInteger, char> encrypt = KnownCrack.Crack(start, last, exp, n);
                    bool isunknown = false;
                    List<BigInteger> unknown = new List<BigInteger>();
                    foreach (var big in encryptChars)
                    {
                        if (encrypt.TryGetValue(big, out char ch))
                        {
                            MainFornLink.BeginInvoke(new Action(() =>
                            {
                                KnownDecryptRichTBox.AppendText(ch.ToString());
                            }));
                        }
                        else
                        {
                            unknown.Add(big);
                            isunknown = true;
                        }
                    }
                    if (isunknown)
                    {
                        MessageBox.Show($"Не удалось расшифровать символы :\n{string.Join("\n", unknown)}\nПопробуйте увеличить границы перебора символов.");
                    }
                    MainFornLink.BeginInvoke(new Action(() =>
                    {
                        MainFornLink.GTabControl.Enabled = true;
                        MainFornLink.CancelPanel.Visible = false;
                    }));
                });
            }
            catch (Exception)
            {
                MainFornLink.GTabControl.Enabled = true;
                MainFornLink.CancelPanel.Visible = false;
                //ignored
            }
        }

        private void KnownEInputTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyFilter(e);
        }

        private void KnownNInputTBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyFilter(e);
        }

        private void RemoveSalt_Click(object sender, EventArgs e)
        {
            var row = KnownDecryptRichTBox.Text;
            KnownDecryptRichTBox.Clear();
            for (int i = 0; i < row.Length; i++)
            {
                KnownDecryptRichTBox.AppendText(((char)(row[i] - i)).ToString());
            }
        }

        private void KnownEInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(EInputTBox, "Можно вводить только целые числа");
        }

        private void KnownNInputTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(EInputTBox, "Можно вводить только целые числа");
        }

        private void DelimeterTBox_MouseHover(object sender, EventArgs e)
        {
            ShowAttention(EInputTBox, "Введите разделитель для текста.\nЕсли текст разделяется только переносом строки,\nто оставлте поле пустым.");
        }
    }
}