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
            tabPage6 = new TabPage();
            buttonRandevuSil = new Button();
            buttonRandevuHepsiniAra = new Button();
            dataGridViewRandevu = new DataGridView();
            buttonRandevuAra = new Button();
            textBoxRandevuAraTc = new TextBox();
            label8 = new Label();
            tabPage5 = new TabPage();
            groupBoxRandevu = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            dateTimePickerRancevuTarih = new DateTimePicker();
            comboBoxRandevuDoktor = new ComboBox();
            comboBoxRandevuPolikinlik = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            buttonRandevuOlustur = new Button();
            textBoxRandevuTc = new TextBox();
            tabPage2 = new TabPage();
            buttonKayitSill = new Button();
            buttonKayıtGuncelle = new Button();
            buttonHepsiniGöster = new Button();
            dataGridView1 = new DataGridView();
            buttonKayitAra = new Button();
            textBoxAramaTc = new TextBox();
            label7 = new Label();
            tabPage1 = new TabPage();
            maskedTextBoxHtel = new MaskedTextBox();
            comboBoxHcinsiyet = new ComboBox();
            label1 = new Label();
            label4 = new Label();
            dateTimePickerHDogunT = new DateTimePicker();
            label5 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            textBoxHisim = new TextBox();
            textBoxHsoyisim = new TextBox();
            textBoxHtc = new TextBox();
            buttonKayitEkle = new Button();
            tabControlSekreter = new TabControl();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevu).BeginInit();
            tabPage5.SuspendLayout();
            groupBoxRandevu.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            tabControlSekreter.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(buttonRandevuSil);
            tabPage6.Controls.Add(buttonRandevuHepsiniAra);
            tabPage6.Controls.Add(dataGridViewRandevu);
            tabPage6.Controls.Add(buttonRandevuAra);
            tabPage6.Controls.Add(textBoxRandevuAraTc);
            tabPage6.Controls.Add(label8);
            tabPage6.Location = new Point(4, 27);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(856, 340);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Randevu Görüntüleme - Güncelleme - Silme";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // buttonRandevuSil
            // 
            buttonRandevuSil.Location = new Point(591, 23);
            buttonRandevuSil.Name = "buttonRandevuSil";
            buttonRandevuSil.Size = new Size(75, 42);
            buttonRandevuSil.TabIndex = 39;
            buttonRandevuSil.Text = "KAYIT SİL";
            buttonRandevuSil.UseVisualStyleBackColor = true;
            buttonRandevuSil.Click += buttonRandevuSil_Click;
            // 
            // buttonRandevuHepsiniAra
            // 
            buttonRandevuHepsiniAra.Location = new Point(476, 24);
            buttonRandevuHepsiniAra.Name = "buttonRandevuHepsiniAra";
            buttonRandevuHepsiniAra.Size = new Size(75, 42);
            buttonRandevuHepsiniAra.TabIndex = 37;
            buttonRandevuHepsiniAra.Text = "HEPSİNİ GÖSTER";
            buttonRandevuHepsiniAra.UseVisualStyleBackColor = true;
            buttonRandevuHepsiniAra.Click += buttonRandevuHepsiniAra_Click;
            // 
            // dataGridViewRandevu
            // 
            dataGridViewRandevu.BackgroundColor = SystemColors.Window;
            dataGridViewRandevu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRandevu.Location = new Point(55, 89);
            dataGridViewRandevu.Name = "dataGridViewRandevu";
            dataGridViewRandevu.Size = new Size(661, 228);
            dataGridViewRandevu.TabIndex = 36;
            // 
            // buttonRandevuAra
            // 
            buttonRandevuAra.Location = new Point(377, 24);
            buttonRandevuAra.Name = "buttonRandevuAra";
            buttonRandevuAra.Size = new Size(75, 41);
            buttonRandevuAra.TabIndex = 35;
            buttonRandevuAra.Text = "RANDEVU ARA";
            buttonRandevuAra.UseVisualStyleBackColor = true;
            buttonRandevuAra.Click += buttonRandevuAra_Click;
            // 
            // textBoxRandevuAraTc
            // 
            textBoxRandevuAraTc.Location = new Point(205, 35);
            textBoxRandevuAraTc.MaxLength = 11;
            textBoxRandevuAraTc.Name = "textBoxRandevuAraTc";
            textBoxRandevuAraTc.Size = new Size(141, 23);
            textBoxRandevuAraTc.TabIndex = 34;
            textBoxRandevuAraTc.TextChanged += textBoxRandevuAraTc_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(88, 38);
            label8.Name = "label8";
            label8.Size = new Size(91, 15);
            label8.TabIndex = 33;
            label8.Text = "T.C. Kimlik No : ";
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(groupBoxRandevu);
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
            tabPage5.Text = " Randevu Oluşturma";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBoxRandevu
            // 
            groupBoxRandevu.Controls.Add(radioButton1);
            groupBoxRandevu.Controls.Add(radioButton6);
            groupBoxRandevu.Controls.Add(radioButton2);
            groupBoxRandevu.Controls.Add(radioButton5);
            groupBoxRandevu.Controls.Add(radioButton3);
            groupBoxRandevu.Controls.Add(radioButton4);
            groupBoxRandevu.Location = new Point(497, 73);
            groupBoxRandevu.Name = "groupBoxRandevu";
            groupBoxRandevu.Size = new Size(268, 129);
            groupBoxRandevu.TabIndex = 39;
            groupBoxRandevu.TabStop = false;
            groupBoxRandevu.Text = "Randevu Saatleri";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(41, 31);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(52, 19);
            radioButton1.TabIndex = 33;
            radioButton1.TabStop = true;
            radioButton1.Text = "09:00";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(155, 85);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(52, 19);
            radioButton6.TabIndex = 38;
            radioButton6.TabStop = true;
            radioButton6.Text = "15:00";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(41, 56);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(52, 19);
            radioButton2.TabIndex = 34;
            radioButton2.TabStop = true;
            radioButton2.Text = "10:00";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(155, 56);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(52, 19);
            radioButton5.TabIndex = 37;
            radioButton5.TabStop = true;
            radioButton5.Text = "14:00";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(41, 85);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(52, 19);
            radioButton3.TabIndex = 35;
            radioButton3.TabStop = true;
            radioButton3.Text = "11:00";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(155, 31);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(52, 19);
            radioButton4.TabIndex = 36;
            radioButton4.TabStop = true;
            radioButton4.Text = "13:00";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // dateTimePickerRancevuTarih
            // 
            dateTimePickerRancevuTarih.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePickerRancevuTarih.Format = DateTimePickerFormat.Short;
            dateTimePickerRancevuTarih.Location = new Point(227, 179);
            dateTimePickerRancevuTarih.Name = "dateTimePickerRancevuTarih";
            dateTimePickerRancevuTarih.Size = new Size(187, 23);
            dateTimePickerRancevuTarih.TabIndex = 32;
            dateTimePickerRancevuTarih.Value = new DateTime(2024, 3, 26, 0, 0, 0, 0);
            dateTimePickerRancevuTarih.ValueChanged += dateTimePickerRancevuTarih_ValueChanged;
            // 
            // comboBoxRandevuDoktor
            // 
            comboBoxRandevuDoktor.FormattingEnabled = true;
            comboBoxRandevuDoktor.Location = new Point(227, 150);
            comboBoxRandevuDoktor.Name = "comboBoxRandevuDoktor";
            comboBoxRandevuDoktor.Size = new Size(187, 23);
            comboBoxRandevuDoktor.TabIndex = 31;
            comboBoxRandevuDoktor.SelectedValueChanged += comboBoxRandevuDoktor_SelectedValueChanged;
            // 
            // comboBoxRandevuPolikinlik
            // 
            comboBoxRandevuPolikinlik.FormattingEnabled = true;
            comboBoxRandevuPolikinlik.Location = new Point(227, 121);
            comboBoxRandevuPolikinlik.Name = "comboBoxRandevuPolikinlik";
            comboBoxRandevuPolikinlik.Size = new Size(187, 23);
            comboBoxRandevuPolikinlik.TabIndex = 30;
            comboBoxRandevuPolikinlik.SelectedValueChanged += comboBoxRandevuPolikinlik_SelectedValueChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(125, 185);
            label16.Name = "label16";
            label16.Size = new Size(90, 15);
            label16.TabIndex = 22;
            label16.Text = "Randevu Tarihi :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(148, 124);
            label17.Name = "label17";
            label17.Size = new Size(64, 15);
            label17.TabIndex = 25;
            label17.Text = "Polikinlik : ";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(118, 100);
            label18.Name = "label18";
            label18.Size = new Size(94, 15);
            label18.TabIndex = 20;
            label18.Text = "T.C. Kimlik No :  ";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(160, 153);
            label19.Name = "label19";
            label19.Size = new Size(52, 15);
            label19.TabIndex = 26;
            label19.Text = "Doktor : ";
            // 
            // buttonRandevuOlustur
            // 
            buttonRandevuOlustur.Location = new Point(270, 223);
            buttonRandevuOlustur.Name = "buttonRandevuOlustur";
            buttonRandevuOlustur.Size = new Size(100, 39);
            buttonRandevuOlustur.TabIndex = 27;
            buttonRandevuOlustur.Text = "RANDEVU OLUŞTUR";
            buttonRandevuOlustur.UseVisualStyleBackColor = true;
            buttonRandevuOlustur.Click += buttonRandevuOlustur_Click;
            // 
            // textBoxRandevuTc
            // 
            textBoxRandevuTc.Location = new Point(227, 92);
            textBoxRandevuTc.MaxLength = 11;
            textBoxRandevuTc.Name = "textBoxRandevuTc";
            textBoxRandevuTc.Size = new Size(187, 23);
            textBoxRandevuTc.TabIndex = 23;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonKayitSill);
            tabPage2.Controls.Add(buttonKayıtGuncelle);
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
            tabPage2.Text = "Hasta Görüntüleme - Güncelleme - Silme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonKayitSill
            // 
            buttonKayitSill.Location = new Point(527, 40);
            buttonKayitSill.Name = "buttonKayitSill";
            buttonKayitSill.Size = new Size(75, 42);
            buttonKayitSill.TabIndex = 32;
            buttonKayitSill.Text = "KAYIT SİL";
            buttonKayitSill.UseVisualStyleBackColor = true;
            buttonKayitSill.Click += buttonKayitSill_Click;
            // 
            // buttonKayıtGuncelle
            // 
            buttonKayıtGuncelle.Location = new Point(623, 41);
            buttonKayıtGuncelle.Name = "buttonKayıtGuncelle";
            buttonKayıtGuncelle.Size = new Size(75, 42);
            buttonKayıtGuncelle.TabIndex = 31;
            buttonKayıtGuncelle.Text = "KAYIT GÜNCELLE";
            buttonKayıtGuncelle.UseVisualStyleBackColor = true;
            buttonKayıtGuncelle.Click += buttonKayitGuncelle_Click;
            // 
            // buttonHepsiniGöster
            // 
            buttonHepsiniGöster.Location = new Point(424, 41);
            buttonHepsiniGöster.Name = "buttonHepsiniGöster";
            buttonHepsiniGöster.Size = new Size(75, 42);
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
            buttonKayitAra.Location = new Point(325, 41);
            buttonKayitAra.Name = "buttonKayitAra";
            buttonKayitAra.Size = new Size(75, 41);
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
            tabPage1.Controls.Add(textBoxHtc);
            tabPage1.Controls.Add(buttonKayitEkle);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 77);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim : ";
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
            // dateTimePickerHDogunT
            // 
            dateTimePickerHDogunT.Location = new Point(356, 158);
            dateTimePickerHDogunT.Name = "dateTimePickerHDogunT";
            dateTimePickerHDogunT.Size = new Size(187, 23);
            dateTimePickerHDogunT.TabIndex = 4;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 135);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "T.C. Kimlik No :  ";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 106);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim : ";
            // 
            // textBoxHisim
            // 
            textBoxHisim.Location = new Point(356, 69);
            textBoxHisim.Name = "textBoxHisim";
            textBoxHisim.Size = new Size(187, 23);
            textBoxHisim.TabIndex = 1;
            textBoxHisim.KeyPress += textBoxHisim_KeyPress;
            // 
            // textBoxHsoyisim
            // 
            textBoxHsoyisim.Location = new Point(356, 98);
            textBoxHsoyisim.Name = "textBoxHsoyisim";
            textBoxHsoyisim.Size = new Size(187, 23);
            textBoxHsoyisim.TabIndex = 2;
            textBoxHsoyisim.KeyPress += textBoxHsoyisim_KeyPress;
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
            // tabControlSekreter
            // 
            tabControlSekreter.Appearance = TabAppearance.Buttons;
            tabControlSekreter.Controls.Add(tabPage1);
            tabControlSekreter.Controls.Add(tabPage2);
            tabControlSekreter.Controls.Add(tabPage5);
            tabControlSekreter.Controls.Add(tabPage6);
            tabControlSekreter.Location = new Point(12, 12);
            tabControlSekreter.Name = "tabControlSekreter";
            tabControlSekreter.SelectedIndex = 0;
            tabControlSekreter.Size = new Size(864, 371);
            tabControlSekreter.TabIndex = 1;
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
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRandevu).EndInit();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            groupBoxRandevu.ResumeLayout(false);
            groupBoxRandevu.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabControlSekreter.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBoxTcArama;
        private DateTimePicker dateTimePickerHastaDt;
        private ListBox listBox1;
        private ComboBox comboBoxCinsiyet;
        private TextBox textBox2;
        private TextBox textBox3;
        private TabPage tabPage6;
        private TabPage tabPage5;
        private DateTimePicker dateTimePickerRancevuTarih;
        private ComboBox comboBoxRandevuDoktor;
        private ComboBox comboBoxRandevuPolikinlik;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button buttonRandevuOlustur;
        private TextBox textBoxRandevuTc;
        private TabPage tabPage2;
        private Button buttonKayitSill;
        private Button buttonKayıtGuncelle;
        private Button buttonHepsiniGöster;
        private DataGridView dataGridView1;
        private Button buttonKayitAra;
        private TextBox textBoxAramaTc;
        private Label label7;
        private TabPage tabPage1;
        private MaskedTextBox maskedTextBoxHtel;
        private ComboBox comboBoxHcinsiyet;
        private Label label1;
        private Label label4;
        private DateTimePicker dateTimePickerHDogunT;
        private Label label5;
        private Label label3;
        private Label label6;
        private Label label2;
        private TextBox textBoxHisim;
        private TextBox textBoxHsoyisim;
        private TextBox textBoxHtc;
        private Button buttonKayitEkle;
        private TabControl tabControlSekreter;
        private GroupBox groupBoxRandevu;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private RadioButton radioButton2;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button buttonRandevuSil;
        private Button buttonRandevuHepsiniAra;
        private DataGridView dataGridViewRandevu;
        private Button buttonRandevuAra;
        private TextBox textBoxRandevuAraTc;
        private Label label8;
    }
}