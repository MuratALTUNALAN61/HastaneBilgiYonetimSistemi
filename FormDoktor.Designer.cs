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
            ((System.ComponentModel.ISupportInitialize)dataGridViewDoktor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 244);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Hasta Şikayeti : ";
            // 
            // richTextBoxSikayet
            // 
            richTextBoxSikayet.Location = new Point(171, 272);
            richTextBoxSikayet.Name = "richTextBoxSikayet";
            richTextBoxSikayet.Size = new Size(136, 87);
            richTextBoxSikayet.TabIndex = 1;
            richTextBoxSikayet.Text = "";
            // 
            // richTextBoxTeshis
            // 
            richTextBoxTeshis.Location = new Point(357, 272);
            richTextBoxTeshis.Name = "richTextBoxTeshis";
            richTextBoxTeshis.Size = new Size(136, 87);
            richTextBoxTeshis.TabIndex = 2;
            richTextBoxTeshis.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(381, 244);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Doktor Teşhisi : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(586, 244);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Reçete : ";
            // 
            // richTextBoxRecete
            // 
            richTextBoxRecete.Location = new Point(543, 272);
            richTextBoxRecete.Name = "richTextBoxRecete";
            richTextBoxRecete.Size = new Size(136, 87);
            richTextBoxRecete.TabIndex = 5;
            richTextBoxRecete.Text = "";
            // 
            // buttonMuayeneKaydet
            // 
            buttonMuayeneKaydet.Location = new Point(381, 387);
            buttonMuayeneKaydet.Name = "buttonMuayeneKaydet";
            buttonMuayeneKaydet.Size = new Size(89, 30);
            buttonMuayeneKaydet.TabIndex = 6;
            buttonMuayeneKaydet.Text = "Kaydet";
            buttonMuayeneKaydet.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDoktor
            // 
            dataGridViewDoktor.BackgroundColor = SystemColors.Control;
            dataGridViewDoktor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDoktor.Location = new Point(12, 34);
            dataGridViewDoktor.Name = "dataGridViewDoktor";
            dataGridViewDoktor.Size = new Size(944, 188);
            dataGridViewDoktor.TabIndex = 7;
            // 
            // buttonHastaBilgi
            // 
            buttonHastaBilgi.Location = new Point(171, 387);
            buttonHastaBilgi.Name = "buttonHastaBilgi";
            buttonHastaBilgi.Size = new Size(110, 46);
            buttonHastaBilgi.TabIndex = 8;
            buttonHastaBilgi.Text = "SIRADAKİ HASTA";
            buttonHastaBilgi.UseVisualStyleBackColor = true;
            buttonHastaBilgi.Click += buttonHastaBilgi_Click;
            // 
            // FormDoktor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1190, 585);
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
    }
}