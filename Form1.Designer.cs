namespace HBYS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            buttonGirisYap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(233, 163);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "KULLANICI ADI : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(285, 192);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "ŞİFRE : ";
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(358, 160);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(180, 23);
            textBoxKullaniciAdi.TabIndex = 2;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(358, 189);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(180, 23);
            textBoxSifre.TabIndex = 3;
            // 
            // buttonGirisYap
            // 
            buttonGirisYap.Location = new Point(411, 218);
            buttonGirisYap.Name = "buttonGirisYap";
            buttonGirisYap.Size = new Size(75, 37);
            buttonGirisYap.TabIndex = 4;
            buttonGirisYap.Text = "GİRİŞ YAP";
            buttonGirisYap.UseVisualStyleBackColor = true;
            buttonGirisYap.Click += buttonGirisYap_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonGirisYap);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Button buttonGirisYap;
    }
}
