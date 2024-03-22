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
            buttonKayitAra = new Button();
            textBoxAramaTc = new TextBox();
            label7 = new Label();
            tabPage3 = new TabPage();
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
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabControlSekreter.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonKayitEkle
            // 
            buttonKayitEkle.Location = new Point(184, 202);
            buttonKayitEkle.Name = "buttonKayitEkle";
            buttonKayitEkle.Size = new Size(100, 32);
            buttonKayitEkle.TabIndex = 14;
            buttonKayitEkle.Text = "KAYIT EKLE";
            buttonKayitEkle.UseVisualStyleBackColor = true;
            // 
            // textBoxHtc
            // 
            textBoxHtc.Location = new Point(141, 71);
            textBoxHtc.MaxLength = 11;
            textBoxHtc.Name = "textBoxHtc";
            textBoxHtc.Size = new Size(187, 23);
            textBoxHtc.TabIndex = 3;
            textBoxHtc.KeyPress += textBoxHtc_KeyPress;
            // 
            // textBoxHsoyisim
            // 
            textBoxHsoyisim.Location = new Point(141, 42);
            textBoxHsoyisim.Name = "textBoxHsoyisim";
            textBoxHsoyisim.Size = new Size(187, 23);
            textBoxHsoyisim.TabIndex = 2;
            textBoxHsoyisim.KeyPress += textBoxHsoyisim_KeyPress;
            // 
            // textBoxHisim
            // 
            textBoxHisim.Location = new Point(141, 13);
            textBoxHisim.Name = "textBoxHisim";
            textBoxHisim.Size = new Size(187, 23);
            textBoxHisim.TabIndex = 1;
            textBoxHisim.KeyPress += textBoxHisim_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(53, 166);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 5;
            label6.Text = "Telefon No : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 137);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 4;
            label5.Text = "Cinsiyet : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 108);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 3;
            label4.Text = "Doğum Tarihi : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 79);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 2;
            label3.Text = "T.C. Kimlik No :  ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 50);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Soyisim : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 21);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "İsim : ";
            // 
            // dateTimePickerHDogunT
            // 
            dateTimePickerHDogunT.Location = new Point(141, 102);
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
            maskedTextBoxHtel.Location = new Point(141, 163);
            maskedTextBoxHtel.Mask = "(999) 000-0000";
            maskedTextBoxHtel.Name = "maskedTextBoxHtel";
            maskedTextBoxHtel.Size = new Size(187, 23);
            maskedTextBoxHtel.TabIndex = 16;
            // 
            // comboBoxHcinsiyet
            // 
            comboBoxHcinsiyet.FormattingEnabled = true;
            comboBoxHcinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            comboBoxHcinsiyet.Location = new Point(141, 134);
            comboBoxHcinsiyet.Name = "comboBoxHcinsiyet";
            comboBoxHcinsiyet.Size = new Size(187, 23);
            comboBoxHcinsiyet.TabIndex = 15;
            // 
            // tabPage2
            // 
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
            // buttonKayitAra
            // 
            buttonKayitAra.Location = new Point(292, 51);
            buttonKayitAra.Name = "buttonKayitAra";
            buttonKayitAra.Size = new Size(75, 23);
            buttonKayitAra.TabIndex = 2;
            buttonKayitAra.Text = "KAYIT ARA";
            buttonKayitAra.UseVisualStyleBackColor = true;
            // 
            // textBoxAramaTc
            // 
            textBoxAramaTc.Location = new Point(156, 52);
            textBoxAramaTc.MaxLength = 11;
            textBoxAramaTc.Name = "textBoxAramaTc";
            textBoxAramaTc.Size = new Size(100, 23);
            textBoxAramaTc.TabIndex = 1;
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
            tabPage5.Location = new Point(4, 27);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(856, 340);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Randevu Oluşturma";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 27);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(856, 340);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Randevu Görüntüleme";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 27);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(856, 340);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Randevu Güncelleme - Silme";
            tabPage7.UseVisualStyleBackColor = true;
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
            tabControlSekreter.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
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
    }
}