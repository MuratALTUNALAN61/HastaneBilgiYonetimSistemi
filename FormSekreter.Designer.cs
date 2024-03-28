namespace HBYS
{
    partial class FormSekreter
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
            buttonKayitEkle = new Button();
            textBoxHtc = new TextBox();
            textBoxHsoyisim = new TextBox();
            textBoxHisim = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dateTimePickerHDogunT = new DateTimePicker();
            tabControlSekreter = new TabControl();
            tabPage1 = new TabPage();
            maskedTextBoxHtel = new MaskedTextBox();
            comboBoxHcinsiyet = new ComboBox();
            tabPage2 = new TabPage();
            buttonHepsiniGöster = new Button();
            dataGridView1 = new DataGridView();
            buttonKayitAra = new Button();
            textBoxAramaTc = new TextBox();
            label7 = new Label();
            tabPage3 = new TabPage();
            button1 = new Button();
            textBox1 = new TextBox();
            label14 = new Label();
            buttonKayitSil = new Button();
            maskedTextBoxGuncelleTel = new MaskedTextBox();
            comboBoxGuncelleCinsiyet = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            dateTimePickerGuncelleDt = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBoxGuncelleIsim = new TextBox();
            textBoxGuncelleSoyisim = new TextBox();
            buttonKayitGuncelle = new Button();
            textBoxGuncelleTc = new TextBox();
            tabPage5 = new TabPage();
            dateTimePickerRancevuTarih = new DateTimePicker();
            comboBoxRandevuDoktor = new ComboBox();
            comboBoxRandevuPolikinlik = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            buttonRandevuOlustur = new Button();
            textBoxRandevuTc = new TextBox();
            tabPage6 = new TabPage();
            button2 = new Button();
            textBoxRandevuAraTc = new TextBox();
            label15 = new Label();
            tabPage7 = new TabPage();
            buttonRandevuSil = new Button();
            buttonRandevuGuncelleAra = new Button();
            textBoxRandevuGuncelleTc = new TextBox();
            label24 = new Label();
            dateTimePickerRandevuGuncelle = new DateTimePicker();
            comboBoxRandevuGuncelleDoktor = new ComboBox();
            comboBoxRandevuGuncellePolikinlik = new ComboBox();
            label20 = new Label();
            label21 = new Label();
            label23 = new Label();
            buttonRandevuGuncelle = new Button();
            tabControlSekreter.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage3.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            SuspendLayout();
            // 
            // buttonKayitEkle
            // 
            buttonKayitEkle.Location = new Point(399, 258);
            buttonKayitEkle.Name = "buttonKayitEkle";
            buttonKayitEkle.Size = new Size(100, 32);
            buttonKayitEkle.TabIndex = 14;
            buttonKayitEkle.Text = "KAYIT EKLE";
            buttonKayitEkle.UseVisualStyleBackColor = true;
            buttonKayitEkle.Click += buttonKayitEkle_Click;
            // 
            // textBoxHtc
            // 
            textBoxHtc.Location = new Point(356, 127);
            textBoxHtc.MaxLength = 11;
            textBoxHtc.Name = "textBoxHtc";
            textBoxHtc.Size = new Size(187, 23);
            textBoxHtc.TabIndex = 3;
            textBoxHtc.KeyPress += textBoxHtc_KeyPress;
            // 
            // textBoxHsoyisim
            // 
            textBoxHsoyisim.Location = new Point(356, 98);
            textBoxHsoyisim.Name = "textBoxHsoyisim";
            textBoxHsoyisim.Size = new Size(187, 23);
            textBoxHsoyisim.TabIndex = 2;
            textBoxHsoyisim.KeyPress += textBoxHsoyisim_KeyPress;
            // 
            // textBoxHisim
            // 
            textBoxHisim.Location = new Point(356, 69);
            textBoxHisim.Name = "textBoxHisim";
            textBoxHisim.Size = new Size(187, 23);
            textBoxHisim.TabIndex = 1;
            textBoxHisim.KeyPress += textBoxHisim_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(268, 190);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefon No : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(283, 219);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyet : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 164);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 135);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "T.C. Kimlik No :  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 106);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 77);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim : ";
            // 
            // dateTimePickerHDogunT
            // 
            dateTimePickerHDogunT.Location = new Point(356, 158);
            dateTimePickerHDogunT.Name = "dateTimePickerHDogunT";
            dateTimePickerHDogunT.Size = new Size(187, 23);
            dateTimePickerHDogunT.TabIndex = 4;
            // 
            // tabControlSekreter
            // 
            tabControlSekreter.Appearance = TabAppearance.Buttons;
            tabControlSekreter.Controls.Add(tabPage1);
            tabControlSekreter.Controls.Add(tabPage2);
            tabControlSekreter.Controls.Add(tabPage3);
            tabControlSekreter.Controls.Add(tabPage5);
            tabControlSekreter.Controls.Add(tabPage6);
            tabControlSekreter.Controls.Add(tabPage7);
            tabControlSekreter.Location = new Point(12, 12);
            tabControlSekreter.Name = "tabControlSekreter";
            tabControlSekreter.SelectedIndex = 0;
            tabControlSekreter.Size = new Size(864, 371);
            tabControlSekreter.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(maskedTextBoxHtel);
            tabPage1.Controls.Add(comboBoxHcinsiyet);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dateTimePickerHDogunT);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(textBoxHisim);
            tabPage1.Controls.Add(textBoxHsoyisim);
            tabPage1.Controls.Add(buttonKayitEkle);
            tabPage1.Controls.Add(textBoxHtc);
            tabPage1.Location = new Point(4, 27);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(856, 340);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hasta Kaydı Oluşturma";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxHtel
            // 
            maskedTextBoxHtel.Location = new Point(356, 187);
            maskedTextBoxHtel.Mask = "(999) 000-0000";
            maskedTextBoxHtel.Name = "maskedTextBoxHtel";
            maskedTextBoxHtel.Size = new Size(187, 23);
            maskedTextBoxHtel.TabIndex = 16;
            // 
            // comboBoxHcinsiyet
            // 
            comboBoxHcinsiyet.FormattingEnabled = true;
            comboBoxHcinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBoxHcinsiyet.Location = new Point(356, 216);
            comboBoxHcinsiyet.Name = "comboBoxHcinsiyet";
            comboBoxHcinsiyet.Size = new Size(187, 23);
            comboBoxHcinsiyet.TabIndex = 15;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonHepsiniGöster);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(buttonKayitAra);
            tabPage2.Controls.Add(textBoxAramaTc);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 27);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(856, 340);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Hasta Görüntüleme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonHepsiniGöster
            // 
            buttonHepsiniGöster.Location = new Point(438, 51);
            buttonHepsiniGöster.Name = "buttonHepsiniGöster";
            buttonHepsiniGöster.Size = new Size(112, 23);
            buttonHepsiniGöster.TabIndex = 4;
            buttonHepsiniGöster.Text = "HEPSİNİ GÖSTER";
            buttonHepsiniGöster.UseVisualStyleBackColor = true;
            buttonHepsiniGöster.Click += buttonHepsiniGöster_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 228);
            dataGridView1.TabIndex = 3;
            // 
            // buttonKayitAra
            // 
            buttonKayitAra.Location = new Point(335, 51);
            buttonKayitAra.Name = "buttonKayitAra";
            buttonKayitAra.Size = new Size(75, 23);
            buttonKayitAra.TabIndex = 2;
            buttonKayitAra.Text = "KAYIT ARA";
            buttonKayitAra.UseVisualStyleBackColor = true;
            buttonKayitAra.Click += buttonKayitAra_Click;
            // 
            // textBoxAramaTc
            // 
            textBoxAramaTc.Location = new Point(153, 52);
            textBoxAramaTc.MaxLength = 11;
            textBoxAramaTc.Name = "textBoxAramaTc";
            textBoxAramaTc.Size = new Size(141, 23);
            textBoxAramaTc.TabIndex = 1;
            textBoxAramaTc.TextChanged += textBoxAramaTc_TextChanged;
            textBoxAramaTc.KeyPress += textBoxAramaTc_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 55);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 0;
            label7.Text = "T.C. Kimlik No : ";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(textBox1);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(buttonKayitSil);
            tabPage3.Controls.Add(maskedTextBoxGuncelleTel);
            tabPage3.Controls.Add(comboBoxGuncelleCinsiyet);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(dateTimePickerGuncelleDt);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(textBoxGuncelleIsim);
            tabPage3.Controls.Add(textBoxGuncelleSoyisim);
            tabPage3.Controls.Add(buttonKayitGuncelle);
            tabPage3.Controls.Add(textBoxGuncelleTc);
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(856, 340);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hasta Kaydı Güncelleme - Silme";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(365, 33);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 33;
            button1.Text = "KAYIT ARA";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 34);
            textBox1.MaxLength = 11;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 32;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(66, 37);
            label14.Name = "label14";
            label14.Size = new Size(91, 15);
            label14.TabIndex = 31;
            label14.Text = "T.C. Kimlik No : ";
            // 
            // buttonKayitSil
            // 
            buttonKayitSil.Location = new Point(288, 256);
            buttonKayitSil.Name = "buttonKayitSil";
            buttonKayitSil.Size = new Size(75, 38);
            buttonKayitSil.TabIndex = 30;
            buttonKayitSil.Text = "KAYIT SİL";
            buttonKayitSil.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxGuncelleTel
            // 
            maskedTextBoxGuncelleTel.Location = new Point(176, 227);
            maskedTextBoxGuncelleTel.Mask = "(999) 000-0000";
            maskedTextBoxGuncelleTel.Name = "maskedTextBoxGuncelleTel";
            maskedTextBoxGuncelleTel.Size = new Size(187, 23);
            maskedTextBoxGuncelleTel.TabIndex = 29;
            // 
            // comboBoxGuncelleCinsiyet
            // 
            comboBoxGuncelleCinsiyet.FormattingEnabled = true;
            comboBoxGuncelleCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBoxGuncelleCinsiyet.Location = new Point(176, 198);
            comboBoxGuncelleCinsiyet.Name = "comboBoxGuncelleCinsiyet";
            comboBoxGuncelleCinsiyet.Size = new Size(187, 23);
            comboBoxGuncelleCinsiyet.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(123, 85);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 17;
            label8.Text = "İsim : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(74, 172);
            label9.Name = "label9";
            label9.Size = new Size(87, 15);
            label9.TabIndex = 22;
            label9.Text = "Doğum Tarihi : ";
            // 
            // dateTimePickerGuncelleDt
            // 
            dateTimePickerGuncelleDt.Location = new Point(176, 166);
            dateTimePickerGuncelleDt.Name = "dateTimePickerGuncelleDt";
            dateTimePickerGuncelleDt.Size = new Size(187, 23);
            dateTimePickerGuncelleDt.TabIndex = 24;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(103, 201);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 25;
            label10.Text = "Cinsiyet : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(67, 143);
            label11.Name = "label11";
            label11.Size = new Size(94, 15);
            label11.TabIndex = 20;
            label11.Text = "T.C. Kimlik No :  ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(88, 230);
            label12.Name = "label12";
            label12.Size = new Size(73, 15);
            label12.TabIndex = 26;
            label12.Text = "Telefon No : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(104, 114);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 18;
            label13.Text = "Soyisim : ";
            // 
            // textBoxGuncelleIsim
            // 
            textBoxGuncelleIsim.Location = new Point(176, 77);
            textBoxGuncelleIsim.Name = "textBoxGuncelleIsim";
            textBoxGuncelleIsim.Size = new Size(187, 23);
            textBoxGuncelleIsim.TabIndex = 19;
            textBoxGuncelleIsim.KeyPress += textBoxGuncelleIsim_KeyPress;
            // 
            // textBoxGuncelleSoyisim
            // 
            textBoxGuncelleSoyisim.Location = new Point(176, 106);
            textBoxGuncelleSoyisim.Name = "textBoxGuncelleSoyisim";
            textBoxGuncelleSoyisim.Size = new Size(187, 23);
            textBoxGuncelleSoyisim.TabIndex = 21;
            textBoxGuncelleSoyisim.TextChanged += textBoxGuncelleSoyisim_TextChanged;
            textBoxGuncelleSoyisim.KeyPress += textBoxGuncelleSoyisim_KeyPress;
            // 
            // buttonKayitGuncelle
            // 
            buttonKayitGuncelle.Location = new Point(176, 256);
            buttonKayitGuncelle.Name = "buttonKayitGuncelle";
            buttonKayitGuncelle.Size = new Size(75, 38);
            buttonKayitGuncelle.TabIndex = 27;
            buttonKayitGuncelle.Text = "KAYIT GÜNCELLE";
            buttonKayitGuncelle.UseVisualStyleBackColor = true;
            // 
            // textBoxGuncelleTc
            // 
            textBoxGuncelleTc.Location = new Point(176, 135);
            textBoxGuncelleTc.MaxLength = 11;
            textBoxGuncelleTc.Name = "textBoxGuncelleTc";
            textBoxGuncelleTc.Size = new Size(187, 23);
            textBoxGuncelleTc.TabIndex = 23;
            textBoxGuncelleTc.KeyPress += textBoxGuncelleTc_KeyPress;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(dateTimePickerRancevuTarih);
            tabPage5.Controls.Add(comboBoxRandevuDoktor);
            tabPage5.Controls.Add(comboBoxRandevuPolikinlik);
            tabPage5.Controls.Add(label16);
            tabPage5.Controls.Add(label17);
            tabPage5.Controls.Add(label18);
            tabPage5.Controls.Add(label19);
            tabPage5.Controls.Add(buttonRandevuOlustur);
            tabPage5.Controls.Add(textBoxRandevuTc);
            tabPage5.Location = new Point(4, 27);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(856, 340);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Randevu Oluşturma";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerRancevuTarih
            // 
            dateTimePickerRancevuTarih.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerRancevuTarih.Format = DateTimePickerFormat.Custom;
            dateTimePickerRancevuTarih.Location = new Point(357, 128);
            dateTimePickerRancevuTarih.Name = "dateTimePickerRancevuTarih";
            dateTimePickerRancevuTarih.Size = new Size(187, 23);
            dateTimePickerRancevuTarih.TabIndex = 32;
            dateTimePickerRancevuTarih.Value = new DateTime(2024, 3, 26, 12, 31, 0, 0);
            // 
            // comboBoxRandevuDoktor
            // 
            comboBoxRandevuDoktor.FormattingEnabled = true;
            comboBoxRandevuDoktor.Location = new Point(357, 189);
            comboBoxRandevuDoktor.Name = "comboBoxRandevuDoktor";
            comboBoxRandevuDoktor.Size = new Size(187, 23);
            comboBoxRandevuDoktor.TabIndex = 31;
            // 
            // comboBoxRandevuPolikinlik
            // 
            comboBoxRandevuPolikinlik.FormattingEnabled = true;
            comboBoxRandevuPolikinlik.Location = new Point(357, 160);
            comboBoxRandevuPolikinlik.Name = "comboBoxRandevuPolikinlik";
            comboBoxRandevuPolikinlik.Size = new Size(187, 23);
            comboBoxRandevuPolikinlik.TabIndex = 30;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(255, 134);
            label16.Name = "label16";
            label16.Size = new Size(87, 15);
            label16.TabIndex = 22;
            label16.Text = "Doğum Tarihi : ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(278, 163);
            label17.Name = "label17";
            label17.Size = new Size(64, 15);
            label17.TabIndex = 25;
            label17.Text = "Polikinlik : ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(248, 105);
            label18.Name = "label18";
            label18.Size = new Size(94, 15);
            label18.TabIndex = 20;
            label18.Text = "T.C. Kimlik No :  ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(290, 192);
            label19.Name = "label19";
            label19.Size = new Size(52, 15);
            label19.TabIndex = 26;
            label19.Text = "Doktor : ";
            // 
            // buttonRandevuOlustur
            // 
            buttonRandevuOlustur.Location = new Point(400, 228);
            buttonRandevuOlustur.Name = "buttonRandevuOlustur";
            buttonRandevuOlustur.Size = new Size(100, 39);
            buttonRandevuOlustur.TabIndex = 27;
            buttonRandevuOlustur.Text = "RANDEVU OLUŞTUR";
            buttonRandevuOlustur.UseVisualStyleBackColor = true;
            // 
            // textBoxRandevuTc
            // 
            textBoxRandevuTc.Location = new Point(357, 97);
            textBoxRandevuTc.MaxLength = 11;
            textBoxRandevuTc.Name = "textBoxRandevuTc";
            textBoxRandevuTc.Size = new Size(187, 23);
            textBoxRandevuTc.TabIndex = 23;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(button2);
            tabPage6.Controls.Add(textBoxRandevuAraTc);
            tabPage6.Controls.Add(label15);
            tabPage6.Location = new Point(4, 27);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(856, 340);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Randevu Görüntüleme";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(349, 53);
            button2.Name = "button2";
            button2.Size = new Size(75, 40);
            button2.TabIndex = 5;
            button2.Text = "RANDEVU ARA";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBoxRandevuAraTc
            // 
            textBoxRandevuAraTc.Location = new Point(170, 63);
            textBoxRandevuAraTc.MaxLength = 11;
            textBoxRandevuAraTc.Name = "textBoxRandevuAraTc";
            textBoxRandevuAraTc.Size = new Size(141, 23);
            textBoxRandevuAraTc.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(50, 66);
            label15.Name = "label15";
            label15.Size = new Size(91, 15);
            label15.TabIndex = 3;
            label15.Text = "T.C. Kimlik No : ";
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(buttonRandevuSil);
            tabPage7.Controls.Add(buttonRandevuGuncelleAra);
            tabPage7.Controls.Add(textBoxRandevuGuncelleTc);
            tabPage7.Controls.Add(label24);
            tabPage7.Controls.Add(dateTimePickerRandevuGuncelle);
            tabPage7.Controls.Add(comboBoxRandevuGuncelleDoktor);
            tabPage7.Controls.Add(comboBoxRandevuGuncellePolikinlik);
            tabPage7.Controls.Add(label20);
            tabPage7.Controls.Add(label21);
            tabPage7.Controls.Add(label23);
            tabPage7.Controls.Add(buttonRandevuGuncelle);
            tabPage7.Location = new Point(4, 27);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(856, 340);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Randevu Güncelleme - Silme";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // buttonRandevuSil
            // 
            buttonRandevuSil.Location = new Point(486, 217);
            buttonRandevuSil.Name = "buttonRandevuSil";
            buttonRandevuSil.Size = new Size(91, 39);
            buttonRandevuSil.TabIndex = 45;
            buttonRandevuSil.Text = "RANDEVU SİL";
            buttonRandevuSil.UseVisualStyleBackColor = true;
            // 
            // buttonRandevuGuncelleAra
            // 
            buttonRandevuGuncelleAra.Location = new Point(587, 37);
            buttonRandevuGuncelleAra.Name = "buttonRandevuGuncelleAra";
            buttonRandevuGuncelleAra.Size = new Size(75, 40);
            buttonRandevuGuncelleAra.TabIndex = 44;
            buttonRandevuGuncelleAra.Text = "RANDEVU ARA";
            buttonRandevuGuncelleAra.UseVisualStyleBackColor = true;
            // 
            // textBoxRandevuGuncelleTc
            // 
            textBoxRandevuGuncelleTc.Location = new Point(408, 47);
            textBoxRandevuGuncelleTc.MaxLength = 11;
            textBoxRandevuGuncelleTc.Name = "textBoxRandevuGuncelleTc";
            textBoxRandevuGuncelleTc.Size = new Size(141, 23);
            textBoxRandevuGuncelleTc.TabIndex = 43;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(288, 50);
            label24.Name = "label24";
            label24.Size = new Size(91, 15);
            label24.TabIndex = 42;
            label24.Text = "T.C. Kimlik No : ";
            // 
            // dateTimePickerRandevuGuncelle
            // 
            dateTimePickerRandevuGuncelle.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerRandevuGuncelle.Format = DateTimePickerFormat.Custom;
            dateTimePickerRandevuGuncelle.Location = new Point(389, 116);
            dateTimePickerRandevuGuncelle.Name = "dateTimePickerRandevuGuncelle";
            dateTimePickerRandevuGuncelle.Size = new Size(187, 23);
            dateTimePickerRandevuGuncelle.TabIndex = 41;
            dateTimePickerRandevuGuncelle.Value = new DateTime(2024, 3, 26, 12, 31, 0, 0);
            // 
            // comboBoxRandevuGuncelleDoktor
            // 
            comboBoxRandevuGuncelleDoktor.FormattingEnabled = true;
            comboBoxRandevuGuncelleDoktor.Location = new Point(389, 177);
            comboBoxRandevuGuncelleDoktor.Name = "comboBoxRandevuGuncelleDoktor";
            comboBoxRandevuGuncelleDoktor.Size = new Size(187, 23);
            comboBoxRandevuGuncelleDoktor.TabIndex = 40;
            // 
            // comboBoxRandevuGuncellePolikinlik
            // 
            comboBoxRandevuGuncellePolikinlik.FormattingEnabled = true;
            comboBoxRandevuGuncellePolikinlik.Location = new Point(389, 148);
            comboBoxRandevuGuncellePolikinlik.Name = "comboBoxRandevuGuncellePolikinlik";
            comboBoxRandevuGuncellePolikinlik.Size = new Size(187, 23);
            comboBoxRandevuGuncellePolikinlik.TabIndex = 39;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(287, 122);
            label20.Name = "label20";
            label20.Size = new Size(87, 15);
            label20.TabIndex = 34;
            label20.Text = "Doğum Tarihi : ";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(310, 151);
            label21.Name = "label21";
            label21.Size = new Size(64, 15);
            label21.TabIndex = 36;
            label21.Text = "Polikinlik : ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(322, 180);
            label23.Name = "label23";
            label23.Size = new Size(52, 15);
            label23.TabIndex = 37;
            label23.Text = "Doktor : ";
            // 
            // buttonRandevuGuncelle
            // 
            buttonRandevuGuncelle.Location = new Point(389, 217);
            buttonRandevuGuncelle.Name = "buttonRandevuGuncelle";
            buttonRandevuGuncelle.Size = new Size(91, 39);
            buttonRandevuGuncelle.TabIndex = 38;
            buttonRandevuGuncelle.Text = "RANDEVU GÜNCELLE";
            buttonRandevuGuncelle.UseVisualStyleBackColor = true;
            // 
            // FormSekreter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 602);
            Controls.Add(tabControlSekreter);
            Name = "FormSekreter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormSekreter_Load;
            tabControlSekreter.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBoxHtc;
        private TextBox textBoxHsoyisim;
        private TextBox textBoxHisim;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonKayitEkle;
        private Label label9;
        private Button buttonKayitAra;
        private TextBox textBoxTcArama;
        private Label label8;
        private Label label10;
        private Label label11;
        private DateTimePicker dateTimePickerHastaDt;
        private ListBox listBox1;
        private TabControl tabControlSekreter;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private ComboBox comboBoxCinsiyet;
        private MaskedTextBox maskedTextBoxHtel;
        private ComboBox comboBoxHcinsiyet;
        private DateTimePicker dateTimePickerHDogunT;
        private TextBox textBoxAramaTc;
        private Label label7;
        private MaskedTextBox maskedTextBoxGuncelleTel;
        private ComboBox comboBoxGuncelleCinsiyet;
        private DateTimePicker dateTimePickerGuncelleDt;
        private Label label12;
        private Label label13;
        private TextBox textBoxGuncelleIsim;
        private TextBox textBoxGuncelleSoyisim;
        private Button buttonKayitGuncelle;
        private TextBox textBoxGuncelleTc;
        private Button buttonKayitSil;
        private Button button1;
        private TextBox textBox1;
        private Label label14;
        private ComboBox comboBoxRandevuPolikinlik;
        private Label label16;
        private DateTimePicker dateTimePickerRancevuTarih;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button buttonRandevuOlustur;
        private TextBox textBoxRandevuTc;
        private ComboBox comboBoxRandevuDoktor;
        private Button button2;
        private TextBox textBoxRandevuAraTc;
        private Label label15;
        private Button buttonRandevuGuncelleAra;
        private TextBox textBoxRandevuGuncelleTc;
        private Label label24;
        private DateTimePicker dateTimePickerRandevuGuncelle;
        private ComboBox comboBoxRandevuGuncelleDoktor;
        private ComboBox comboBoxRandevuGuncellePolikinlik;
        private Label label20;
        private Label label21;
        private Label label23;
        private Button buttonRandevuGuncelle;
        private Button buttonRandevuSil;
        private DataGridView dataGridView1;
        private Button buttonHepsiniGöster;
    }
}