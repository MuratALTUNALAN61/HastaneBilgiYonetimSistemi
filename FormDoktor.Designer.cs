namespace HBYS
{
    partial class FormDoktor
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
            label1 = new Label();
            richTextBoxSikayet = new RichTextBox();
            richTextBoxTeshis = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            richTextBoxRecete = new RichTextBox();
            buttonMuayeneKaydet = new Button();
            dataGridViewDoktor = new DataGridView();
            buttonHastaBilgi = new Button();
            label4 = new Label();
            labelHastaAd = new Label();
            label5 = new Label();
            labelHastaSoyad = new Label();
            buttonOncekiHastaBilgi = new Button();
            buttonCıkıs = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoktor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 322);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Hasta Şikayeti : ";
            // 
            // richTextBoxSikayet
            // 
            richTextBoxSikayet.Location = new Point(172, 319);
            richTextBoxSikayet.Name = "richTextBoxSikayet";
            richTextBoxSikayet.Size = new Size(202, 37);
            richTextBoxSikayet.TabIndex = 1;
            richTextBoxSikayet.Text = "";
            richTextBoxSikayet.TextChanged += richTextBoxSikayet_TextChanged;
            // 
            // richTextBoxTeshis
            // 
            richTextBoxTeshis.Location = new Point(172, 362);
            richTextBoxTeshis.Name = "richTextBoxTeshis";
            richTextBoxTeshis.Size = new Size(202, 37);
            richTextBoxTeshis.TabIndex = 2;
            richTextBoxTeshis.Text = "";
            richTextBoxTeshis.TextChanged += richTextBoxTeshis_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 365);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Doktor Teşhisi : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 408);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Reçete : ";
            // 
            // richTextBoxRecete
            // 
            richTextBoxRecete.Location = new Point(172, 405);
            richTextBoxRecete.Name = "richTextBoxRecete";
            richTextBoxRecete.Size = new Size(202, 37);
            richTextBoxRecete.TabIndex = 5;
            richTextBoxRecete.Text = "";
            // 
            // buttonMuayeneKaydet
            // 
            buttonMuayeneKaydet.Location = new Point(527, 362);
            buttonMuayeneKaydet.Name = "buttonMuayeneKaydet";
            buttonMuayeneKaydet.Size = new Size(110, 37);
            buttonMuayeneKaydet.TabIndex = 6;
            buttonMuayeneKaydet.Text = "Kaydet";
            buttonMuayeneKaydet.UseVisualStyleBackColor = true;
            buttonMuayeneKaydet.Click += buttonMuayeneKaydet_Click;
            // 
            // dataGridViewDoktor
            // 
            dataGridViewDoktor.BackgroundColor = SystemColors.Control;
            dataGridViewDoktor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoktor.Location = new Point(12, 112);
            dataGridViewDoktor.Name = "dataGridViewDoktor";
            dataGridViewDoktor.Size = new Size(944, 188);
            dataGridViewDoktor.TabIndex = 7;
            // 
            // buttonHastaBilgi
            // 
            buttonHastaBilgi.Location = new Point(1012, 254);
            buttonHastaBilgi.Name = "buttonHastaBilgi";
            buttonHastaBilgi.Size = new Size(110, 46);
            buttonHastaBilgi.TabIndex = 8;
            buttonHastaBilgi.Text = "SONRAKİ HASTA BİLGİSi";
            buttonHastaBilgi.UseVisualStyleBackColor = true;
            buttonHastaBilgi.Click += buttonHastaBilgi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 48);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 9;
            label4.Text = "Hasta Ad :";
            // 
            // labelHastaAd
            // 
            labelHastaAd.AutoSize = true;
            labelHastaAd.Location = new Point(149, 48);
            labelHastaAd.Name = "labelHastaAd";
            labelHastaAd.Size = new Size(55, 15);
            labelHastaAd.TabIndex = 10;
            labelHastaAd.Text = "00000000";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 78);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 11;
            label5.Text = "Hasta Soyad :";
            // 
            // labelHastaSoyad
            // 
            labelHastaSoyad.AutoSize = true;
            labelHastaSoyad.Location = new Point(149, 78);
            labelHastaSoyad.Name = "labelHastaSoyad";
            labelHastaSoyad.Size = new Size(55, 15);
            labelHastaSoyad.TabIndex = 12;
            labelHastaSoyad.Text = "00000000";
            // 
            // buttonOncekiHastaBilgi
            // 
            buttonOncekiHastaBilgi.Location = new Point(1012, 112);
            buttonOncekiHastaBilgi.Name = "buttonOncekiHastaBilgi";
            buttonOncekiHastaBilgi.Size = new Size(110, 46);
            buttonOncekiHastaBilgi.TabIndex = 13;
            buttonOncekiHastaBilgi.Text = "ÖNCEKİ HASTA BİLGİSİ";
            buttonOncekiHastaBilgi.UseVisualStyleBackColor = true;
            buttonOncekiHastaBilgi.Click += buttonOncekiHastaBilgi_Click;
            // 
            // buttonCıkıs
            // 
            buttonCıkıs.Location = new Point(1047, 405);
            buttonCıkıs.Name = "buttonCıkıs";
            buttonCıkıs.Size = new Size(75, 37);
            buttonCıkıs.TabIndex = 14;
            buttonCıkıs.Text = "ÇIKIŞ";
            buttonCıkıs.UseVisualStyleBackColor = true;
            buttonCıkıs.Click += buttonCıkıs_Click;
            // 
            // FormDoktor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1190, 585);
            Controls.Add(buttonCıkıs);
            Controls.Add(buttonOncekiHastaBilgi);
            Controls.Add(labelHastaSoyad);
            Controls.Add(label5);
            Controls.Add(labelHastaAd);
            Controls.Add(label4);
            Controls.Add(buttonHastaBilgi);
            Controls.Add(dataGridViewDoktor);
            Controls.Add(buttonMuayeneKaydet);
            Controls.Add(richTextBoxRecete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(richTextBoxTeshis);
            Controls.Add(richTextBoxSikayet);
            Controls.Add(label1);
            Name = "FormDoktor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += FormDoktor_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoktor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox richTextBoxSikayet;
        private RichTextBox richTextBoxTeshis;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBoxRecete;
        private Button buttonMuayeneKaydet;
        private DataGridView dataGridViewDoktor;
        private Button buttonHastaBilgi;
        private Label label4;
        private Label labelHastaAd;
        private Label label5;
        private Label labelHastaSoyad;
        private Button buttonOncekiHastaBilgi;
        private Button buttonCıkıs;
    }
}