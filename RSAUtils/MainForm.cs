using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
                //ignored
            }
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
    }
}