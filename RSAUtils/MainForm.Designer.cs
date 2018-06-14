namespace RSAUtils
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EncryptBtn = new System.Windows.Forms.Button();
            this.CrackBtn = new System.Windows.Forms.Button();
            this.EncryptDataLView = new System.Windows.Forms.ListView();
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OriginalInputTBox = new System.Windows.Forms.TextBox();
            this.GTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OriginalInputLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.UseKnownСBox = new System.Windows.Forms.CheckBox();
            this.CrackDataLView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EInputLabel = new System.Windows.Forms.Label();
            this.NInputLabel = new System.Windows.Forms.Label();
            this.EncryptInputLabel = new System.Windows.Forms.Label();
            this.EInputTBox = new System.Windows.Forms.TextBox();
            this.NInputTBox = new System.Windows.Forms.TextBox();
            this.EncryptInputTBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TextIsNumberCBox = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveSalt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.StartBorderUpDown = new System.Windows.Forms.NumericUpDown();
            this.KnownEInputTBox = new System.Windows.Forms.TextBox();
            this.KnownNInputTBox = new System.Windows.Forms.TextBox();
            this.KnownCrackBtn = new System.Windows.Forms.Button();
            this.KnownDecryptRichTBox = new System.Windows.Forms.RichTextBox();
            this.KnownEncryptRichTBox = new System.Windows.Forms.RichTextBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.CancelPanel = new System.Windows.Forms.Panel();
            this.RemoveSalt2 = new System.Windows.Forms.Button();
            this.GTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastBorderUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartBorderUpDown)).BeginInit();
            this.CancelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EncryptBtn
            // 
            this.EncryptBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.EncryptBtn.Location = new System.Drawing.Point(6, 359);
            this.EncryptBtn.Name = "EncryptBtn";
            this.EncryptBtn.Size = new System.Drawing.Size(85, 23);
            this.EncryptBtn.TabIndex = 0;
            this.EncryptBtn.Text = "Зашифровать";
            this.EncryptBtn.UseVisualStyleBackColor = true;
            this.EncryptBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrackBtn
            // 
            this.CrackBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CrackBtn.Location = new System.Drawing.Point(6, 359);
            this.CrackBtn.Name = "CrackBtn";
            this.CrackBtn.Size = new System.Drawing.Size(85, 23);
            this.CrackBtn.TabIndex = 20;
            this.CrackBtn.Text = "Взломать";
            this.CrackBtn.UseVisualStyleBackColor = true;
            this.CrackBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // EncryptDataLView
            // 
            this.EncryptDataLView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptDataLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Type,
            this.Value});
            this.EncryptDataLView.Location = new System.Drawing.Point(6, 45);
            this.EncryptDataLView.Name = "EncryptDataLView";
            this.EncryptDataLView.Size = new System.Drawing.Size(393, 308);
            this.EncryptDataLView.TabIndex = 21;
            this.EncryptDataLView.UseCompatibleStateImageBehavior = false;
            this.EncryptDataLView.View = System.Windows.Forms.View.Details;
            this.EncryptDataLView.DoubleClick += new System.EventHandler(this.EncryptDataLView_DoubleClick);
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 150;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 150;
            // 
            // OriginalInputTBox
            // 
            this.OriginalInputTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OriginalInputTBox.Location = new System.Drawing.Point(6, 19);
            this.OriginalInputTBox.MaxLength = 6;
            this.OriginalInputTBox.Name = "OriginalInputTBox";
            this.OriginalInputTBox.Size = new System.Drawing.Size(393, 20);
            this.OriginalInputTBox.TabIndex = 22;
            this.OriginalInputTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.OriginalInputTBox.MouseHover += new System.EventHandler(this.OriginalInputTBox_MouseHover);
            // 
            // GTabControl
            // 
            this.GTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GTabControl.Controls.Add(this.tabPage1);
            this.GTabControl.Controls.Add(this.tabPage2);
            this.GTabControl.Controls.Add(this.tabPage3);
            this.GTabControl.Location = new System.Drawing.Point(13, 13);
            this.GTabControl.Name = "GTabControl";
            this.GTabControl.SelectedIndex = 0;
            this.GTabControl.Size = new System.Drawing.Size(413, 414);
            this.GTabControl.TabIndex = 23;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OriginalInputLabel);
            this.tabPage1.Controls.Add(this.EncryptDataLView);
            this.tabPage1.Controls.Add(this.OriginalInputTBox);
            this.tabPage1.Controls.Add(this.EncryptBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Генерация параметров";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OriginalInputLabel
            // 
            this.OriginalInputLabel.AutoSize = true;
            this.OriginalInputLabel.Location = new System.Drawing.Point(6, 3);
            this.OriginalInputLabel.Name = "OriginalInputLabel";
            this.OriginalInputLabel.Size = new System.Drawing.Size(105, 13);
            this.OriginalInputLabel.TabIndex = 23;
            this.OriginalInputLabel.Text = "Исходное число (m)";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.UseKnownСBox);
            this.tabPage2.Controls.Add(this.CrackDataLView);
            this.tabPage2.Controls.Add(this.EInputLabel);
            this.tabPage2.Controls.Add(this.NInputLabel);
            this.tabPage2.Controls.Add(this.EncryptInputLabel);
            this.tabPage2.Controls.Add(this.EInputTBox);
            this.tabPage2.Controls.Add(this.NInputTBox);
            this.tabPage2.Controls.Add(this.EncryptInputTBox);
            this.tabPage2.Controls.Add(this.CrackBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Циклический взлом";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UseKnownСBox
            // 
            this.UseKnownСBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UseKnownСBox.AutoSize = true;
            this.UseKnownСBox.Location = new System.Drawing.Point(97, 363);
            this.UseKnownСBox.Name = "UseKnownСBox";
            this.UseKnownСBox.Size = new System.Drawing.Size(193, 17);
            this.UseKnownСBox.TabIndex = 30;
            this.UseKnownСBox.Text = "Использовать сгенерированные";
            this.UseKnownСBox.UseVisualStyleBackColor = true;
            this.UseKnownСBox.CheckedChanged += new System.EventHandler(this.UseKnownСBox_CheckedChanged);
            // 
            // CrackDataLView
            // 
            this.CrackDataLView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CrackDataLView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.CrackDataLView.Location = new System.Drawing.Point(6, 123);
            this.CrackDataLView.Name = "CrackDataLView";
            this.CrackDataLView.Size = new System.Drawing.Size(393, 230);
            this.CrackDataLView.TabIndex = 29;
            this.CrackDataLView.UseCompatibleStateImageBehavior = false;
            this.CrackDataLView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Value";
            this.columnHeader2.Width = 150;
            // 
            // EInputLabel
            // 
            this.EInputLabel.AutoSize = true;
            this.EInputLabel.Location = new System.Drawing.Point(6, 81);
            this.EInputLabel.Name = "EInputLabel";
            this.EInputLabel.Size = new System.Drawing.Size(168, 13);
            this.EInputLabel.TabIndex = 28;
            this.EInputLabel.Text = "Компонент открытого ключа (e)";
            // 
            // NInputLabel
            // 
            this.NInputLabel.AutoSize = true;
            this.NInputLabel.Location = new System.Drawing.Point(6, 42);
            this.NInputLabel.Name = "NInputLabel";
            this.NInputLabel.Size = new System.Drawing.Size(168, 13);
            this.NInputLabel.TabIndex = 27;
            this.NInputLabel.Text = "Компонент открытого ключа (n)";
            // 
            // EncryptInputLabel
            // 
            this.EncryptInputLabel.AutoSize = true;
            this.EncryptInputLabel.Location = new System.Drawing.Point(6, 3);
            this.EncryptInputLabel.Name = "EncryptInputLabel";
            this.EncryptInputLabel.Size = new System.Drawing.Size(125, 13);
            this.EncryptInputLabel.TabIndex = 26;
            this.EncryptInputLabel.Text = "Шифрованное число (c)";
            // 
            // EInputTBox
            // 
            this.EInputTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EInputTBox.Location = new System.Drawing.Point(6, 97);
            this.EInputTBox.Name = "EInputTBox";
            this.EInputTBox.Size = new System.Drawing.Size(393, 20);
            this.EInputTBox.TabIndex = 25;
            this.EInputTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EInputTBox_KeyPress);
            this.EInputTBox.MouseHover += new System.EventHandler(this.EInputTBox_MouseHover);
            // 
            // NInputTBox
            // 
            this.NInputTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NInputTBox.Location = new System.Drawing.Point(6, 58);
            this.NInputTBox.Name = "NInputTBox";
            this.NInputTBox.Size = new System.Drawing.Size(393, 20);
            this.NInputTBox.TabIndex = 24;
            this.NInputTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NInputTBox_KeyPress);
            this.NInputTBox.MouseHover += new System.EventHandler(this.NInputTBox_MouseHover);
            // 
            // EncryptInputTBox
            // 
            this.EncryptInputTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptInputTBox.Location = new System.Drawing.Point(6, 19);
            this.EncryptInputTBox.Name = "EncryptInputTBox";
            this.EncryptInputTBox.Size = new System.Drawing.Size(393, 20);
            this.EncryptInputTBox.TabIndex = 23;
            this.EncryptInputTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EncryptInputTBox_KeyPress);
            this.EncryptInputTBox.MouseHover += new System.EventHandler(this.EncryptInputTBox_MouseHover);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RemoveSalt2);
            this.tabPage3.Controls.Add(this.TextIsNumberCBox);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.RemoveSalt);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.LastBorderUpDown);
            this.tabPage3.Controls.Add(this.StartBorderUpDown);
            this.tabPage3.Controls.Add(this.KnownEInputTBox);
            this.tabPage3.Controls.Add(this.KnownNInputTBox);
            this.tabPage3.Controls.Add(this.KnownCrackBtn);
            this.tabPage3.Controls.Add(this.KnownDecryptRichTBox);
            this.tabPage3.Controls.Add(this.KnownEncryptRichTBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(405, 388);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ограниченое число команд";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TextIsNumberCBox
            // 
            this.TextIsNumberCBox.AutoSize = true;
            this.TextIsNumberCBox.Location = new System.Drawing.Point(220, 80);
            this.TextIsNumberCBox.Name = "TextIsNumberCBox";
            this.TextIsNumberCBox.Size = new System.Drawing.Size(179, 17);
            this.TextIsNumberCBox.TabIndex = 35;
            this.TextIsNumberCBox.Text = "Заштфрованный текст - число";
            this.TextIsNumberCBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Расшифрованный текст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Зашифрованный текст";
            // 
            // RemoveSalt
            // 
            this.RemoveSalt.Location = new System.Drawing.Point(314, 359);
            this.RemoveSalt.Name = "RemoveSalt";
            this.RemoveSalt.Size = new System.Drawing.Size(85, 23);
            this.RemoveSalt.TabIndex = 32;
            this.RemoveSalt.Text = "Убрать соль";
            this.RemoveSalt.UseVisualStyleBackColor = true;
            this.RemoveSalt.Click += new System.EventHandler(this.RemoveSalt_Click);
            this.RemoveSalt.MouseHover += new System.EventHandler(this.RemoveSalt_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Компонент открытого ключа (n)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Компонент открытого ключа (e)";
            // 
            // LastBorderUpDown
            // 
            this.LastBorderUpDown.Location = new System.Drawing.Point(154, 362);
            this.LastBorderUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.LastBorderUpDown.Name = "LastBorderUpDown";
            this.LastBorderUpDown.Size = new System.Drawing.Size(51, 20);
            this.LastBorderUpDown.TabIndex = 8;
            this.LastBorderUpDown.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // StartBorderUpDown
            // 
            this.StartBorderUpDown.Location = new System.Drawing.Point(97, 362);
            this.StartBorderUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.StartBorderUpDown.Name = "StartBorderUpDown";
            this.StartBorderUpDown.Size = new System.Drawing.Size(51, 20);
            this.StartBorderUpDown.TabIndex = 7;
            // 
            // KnownEInputTBox
            // 
            this.KnownEInputTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KnownEInputTBox.Location = new System.Drawing.Point(6, 19);
            this.KnownEInputTBox.Name = "KnownEInputTBox";
            this.KnownEInputTBox.Size = new System.Drawing.Size(393, 20);
            this.KnownEInputTBox.TabIndex = 5;
            this.KnownEInputTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KnownEInputTBox_KeyPress);
            this.KnownEInputTBox.MouseHover += new System.EventHandler(this.KnownEInputTBox_MouseHover);
            // 
            // KnownNInputTBox
            // 
            this.KnownNInputTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KnownNInputTBox.Location = new System.Drawing.Point(6, 58);
            this.KnownNInputTBox.Name = "KnownNInputTBox";
            this.KnownNInputTBox.Size = new System.Drawing.Size(393, 20);
            this.KnownNInputTBox.TabIndex = 4;
            this.KnownNInputTBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KnownNInputTBox_KeyPress);
            this.KnownNInputTBox.MouseHover += new System.EventHandler(this.KnownNInputTBox_MouseHover);
            // 
            // KnownCrackBtn
            // 
            this.KnownCrackBtn.Location = new System.Drawing.Point(6, 359);
            this.KnownCrackBtn.Name = "KnownCrackBtn";
            this.KnownCrackBtn.Size = new System.Drawing.Size(85, 23);
            this.KnownCrackBtn.TabIndex = 3;
            this.KnownCrackBtn.Text = "Взломать";
            this.KnownCrackBtn.UseVisualStyleBackColor = true;
            this.KnownCrackBtn.Click += new System.EventHandler(this.KnownCrackBtn_Click);
            // 
            // KnownDecryptRichTBox
            // 
            this.KnownDecryptRichTBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KnownDecryptRichTBox.Location = new System.Drawing.Point(6, 198);
            this.KnownDecryptRichTBox.Name = "KnownDecryptRichTBox";
            this.KnownDecryptRichTBox.Size = new System.Drawing.Size(393, 155);
            this.KnownDecryptRichTBox.TabIndex = 1;
            this.KnownDecryptRichTBox.Text = "";
            // 
            // KnownEncryptRichTBox
            // 
            this.KnownEncryptRichTBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KnownEncryptRichTBox.Location = new System.Drawing.Point(6, 97);
            this.KnownEncryptRichTBox.Name = "KnownEncryptRichTBox";
            this.KnownEncryptRichTBox.Size = new System.Drawing.Size(393, 82);
            this.KnownEncryptRichTBox.TabIndex = 0;
            this.KnownEncryptRichTBox.Text = "";
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Location = new System.Drawing.Point(8, 3);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(399, 26);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "Досрочно прервать взлом";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // CancelPanel
            // 
            this.CancelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelPanel.Controls.Add(this.CancelBtn);
            this.CancelPanel.Location = new System.Drawing.Point(12, 394);
            this.CancelPanel.Name = "CancelPanel";
            this.CancelPanel.Size = new System.Drawing.Size(414, 33);
            this.CancelPanel.TabIndex = 24;
            this.CancelPanel.Visible = false;
            this.CancelPanel.VisibleChanged += new System.EventHandler(this.CancelPanel_VisibleChanged);
            // 
            // RemoveSalt2
            // 
            this.RemoveSalt2.Location = new System.Drawing.Point(223, 359);
            this.RemoveSalt2.Name = "RemoveSalt2";
            this.RemoveSalt2.Size = new System.Drawing.Size(85, 23);
            this.RemoveSalt2.TabIndex = 36;
            this.RemoveSalt2.Text = "Убрать соль";
            this.RemoveSalt2.UseVisualStyleBackColor = true;
            this.RemoveSalt2.Click += new System.EventHandler(this.RemoveSalt2_Click);
            this.RemoveSalt2.MouseHover += new System.EventHandler(this.RemoveSalt2_MouseHover);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 439);
            this.Controls.Add(this.GTabControl);
            this.Controls.Add(this.CancelPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LastBorderUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartBorderUpDown)).EndInit();
            this.CancelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EncryptBtn;
        private System.Windows.Forms.Button CrackBtn;
        private System.Windows.Forms.ListView EncryptDataLView;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.TextBox OriginalInputTBox;
        private System.Windows.Forms.TabControl GTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label OriginalInputLabel;
        private System.Windows.Forms.ListView CrackDataLView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label EInputLabel;
        private System.Windows.Forms.Label NInputLabel;
        private System.Windows.Forms.Label EncryptInputLabel;
        private System.Windows.Forms.TextBox EInputTBox;
        private System.Windows.Forms.TextBox NInputTBox;
        private System.Windows.Forms.TextBox EncryptInputTBox;
        private System.Windows.Forms.CheckBox UseKnownСBox;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Panel CancelPanel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox KnownEInputTBox;
        private System.Windows.Forms.TextBox KnownNInputTBox;
        private System.Windows.Forms.Button KnownCrackBtn;
        private System.Windows.Forms.RichTextBox KnownDecryptRichTBox;
        private System.Windows.Forms.RichTextBox KnownEncryptRichTBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LastBorderUpDown;
        private System.Windows.Forms.NumericUpDown StartBorderUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveSalt;
        private System.Windows.Forms.CheckBox TextIsNumberCBox;
        private System.Windows.Forms.Button RemoveSalt2;
    }
}

