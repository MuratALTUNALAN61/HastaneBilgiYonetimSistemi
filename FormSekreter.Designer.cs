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
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            tabPage6 = new TabPage();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            label7 = new Label();
            textBoxAramaTc = new TextBox();
            buttonKayitAra = new Button();
            tabControlSekreter.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            tabControlSekreter.Controls.Add(tabPage4);
            tabControlSekreter.Controls.Add(tabPage5);
            tabControlSekreter.Controls.Add(tabPage6);
            tabControlSekreter.Controls.Add(tabPage7);
            tabControlSekreter.Controls.Add(tabPage8);
            tabControlSekreter.Location = new Point(12, 12);
            tabControlSekreter.Name = "tabControlSekreter";
            tabControlSekreter.SelectedIndex = 0;
            tabControlSekreter.Size = new Size(815, 371);
            tabControlSekreter.SizeMode = TabSizeMode.Fixed;
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
            tabPage1.Size = new Size(807, 340);
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
            tabPage2.Size = new Size(807, 340);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Hasta Görüntüleme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 27);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(807, 340);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Hasta Kaydı Güncelleme";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 27);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(807, 340);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Hasta Kaydı Silme";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            tabPage5.Location = new Point(4, 27);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(807, 340);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Randevu Oluşturma";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            tabPage6.Location = new Point(4, 27);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(807, 340);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Randevu Görüntüleme";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            tabPage7.Location = new Point(4, 27);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(807, 340);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "Randevu Güncelleme";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            tabPage8.Location = new Point(4, 27);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(807, 340);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "Randevu Silme";
            tabPage8.UseVisualStyleBackColor = true;
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
            textBoxAramaTc.Location = new Point(156, 52);
            textBoxAramaTc.Name = "textBoxAramaTc";
            textBoxAramaTc.Size = new Size(100, 23);
            textBoxAramaTc.TabIndex = 1;
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
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private ComboBox comboBoxCinsiyet;
        private MaskedTextBox maskedTextBoxHtel;
        private ComboBox comboBoxHcinsiyet;
        private DateTimePicker dateTimePickerHDogunT;
        private TextBox textBoxAramaTc;
        private Label label7;
    }
}