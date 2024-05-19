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
            label15 = new Label();
            textBoxRandevuAraTc = new TextBox();
            button2 = new Button();
            tabPage5 = new TabPage();
            textBoxRandevuTc = new TextBox();
            buttonRandevuOlustur = new Button();
            label19 = new Label();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            comboBoxRandevuPolikinlik = new ComboBox();
            comboBoxRandevuDoktor = new ComboBox();
            dateTimePickerRancevuTarih = new DateTimePicker();
            tabPage2 = new TabPage();
            label7 = new Label();
            textBoxAramaTc = new TextBox();
            buttonKayitAra = new Button();
            dataGridView1 = new DataGridView();
            buttonHepsiniGöster = new Button();
            buttonKayıtGuncelle = new Button();
            buttonKayitSill = new Button();
            tabPage1 = new TabPage();
            textBoxHtc = new TextBox();
            buttonKayitEkle = new Button();
            textBoxHsoyisim = new TextBox();
            textBoxHisim = new TextBox();
            label2 = new Label();
            label6 = new Label();
            label3 = new Label();
            label5 = new Label();
            dateTimePickerHDogunT = new DateTimePicker();
            label4 = new Label();
            label1 = new Label();
            comboBoxHcinsiyet = new ComboBox();
            maskedTextBoxHtel = new MaskedTextBox();
            tabControlSekreter = new TabControl();
            tabPage6.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage1.SuspendLayout();
            tabControlSekreter.SuspendLayout();
            SuspendLayout();
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
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(50, 66);
            label15.Name = "label15";
            label15.Size = new Size(91, 15);
            label15.TabIndex = 3;
            label15.Text = "T.C. Kimlik No : ";
            // 
            // textBoxRandevuAraTc
            // 
            textBoxRandevuAraTc.Location = new Point(170, 63);
            textBoxRandevuAraTc.MaxLength = 11;
            textBoxRandevuAraTc.Name = "textBoxRandevuAraTc";
            textBoxRandevuAraTc.Size = new Size(141, 23);
            textBoxRandevuAraTc.TabIndex = 4;
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
            // textBoxRandevuTc
            // 
            textBoxRandevuTc.Location = new Point(357, 97);
            textBoxRandevuTc.MaxLength = 11;
            textBoxRandevuTc.Name = "textBoxRandevuTc";
            textBoxRandevuTc.Size = new Size(187, 23);
            textBoxRandevuTc.TabIndex = 23;
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
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(290, 192);
            label19.Name = "label19";
            label19.Size = new Size(52, 15);
            label19.TabIndex = 26;
            label19.Text = "Doktor : ";
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
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(278, 163);
            label17.Name = "label17";
            label17.Size = new Size(64, 15);
            label17.TabIndex = 25;
            label17.Text = "Polikinlik : ";
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
            // comboBoxRandevuPolikinlik
            // 
            comboBoxRandevuPolikinlik.FormattingEnabled = true;
            comboBoxRandevuPolikinlik.Location = new Point(357, 160);
            comboBoxRandevuPolikinlik.Name = "comboBoxRandevuPolikinlik";
            comboBoxRandevuPolikinlik.Size = new Size(187, 23);
            comboBoxRandevuPolikinlik.TabIndex = 30;
            // 
            // comboBoxRandevuDoktor
            // 
            comboBoxRandevuDoktor.FormattingEnabled = true;
            comboBoxRandevuDoktor.Location = new Point(357, 189);
            comboBoxRandevuDoktor.Name = "comboBoxRandevuDoktor";
            comboBoxRandevuDoktor.Size = new Size(187, 23);
            comboBoxRandevuDoktor.TabIndex = 31;
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
            tabPage2.Text = "Hasta Görüntüleme";
            tabPage2.UseVisualStyleBackColor = true;
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
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 106);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(747, 228);
            dataGridView1.TabIndex = 3;
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
            // buttonKayıtGuncelle
            // 
            buttonKayıtGuncelle.Location = new Point(594, 43);
            buttonKayıtGuncelle.Name = "buttonKayıtGuncelle";
            buttonKayıtGuncelle.Size = new Size(75, 38);
            buttonKayıtGuncelle.TabIndex = 31;
            buttonKayıtGuncelle.Text = "KAYIT GÜNCELLE";
            buttonKayıtGuncelle.UseVisualStyleBackColor = true;
            buttonKayıtGuncelle.Click += buttonKayitGuncelle_Click;
            // 
            // buttonKayitSill
            // 
            buttonKayitSill.Location = new Point(706, 43);
            buttonKayitSill.Name = "buttonKayitSill";
            buttonKayitSill.Size = new Size(75, 38);
            buttonKayitSill.TabIndex = 32;
            buttonKayitSill.Text = "KAYIT SİL";
            buttonKayitSill.UseVisualStyleBackColor = true;
            buttonKayitSill.Click += buttonKayitSill_Click;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 106);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim : ";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(247, 135);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "T.C. Kimlik No :  ";
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
            // dateTimePickerHDogunT
            // 
            dateTimePickerHDogunT.Location = new Point(356, 158);
            dateTimePickerHDogunT.Name = "dateTimePickerHDogunT";
            dateTimePickerHDogunT.Size = new Size(187, 23);
            dateTimePickerHDogunT.TabIndex = 4;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 77);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim : ";
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
            // maskedTextBoxHtel
            // 
            maskedTextBoxHtel.Location = new Point(356, 187);
            maskedTextBoxHtel.Mask = "(999) 000-0000";
            maskedTextBoxHtel.Name = "maskedTextBoxHtel";
            maskedTextBoxHtel.Size = new Size(187, 23);
            maskedTextBoxHtel.TabIndex = 16;
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
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
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
        private Button button2;
        private TextBox textBoxRandevuAraTc;
        private Label label15;
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
    }
}