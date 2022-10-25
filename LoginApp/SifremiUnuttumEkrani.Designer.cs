namespace LoginApp
{
    partial class SifremiUnuttumEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifremiUnuttumEkrani));
            this.anaEkranaDon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.girilenKullaniciAdi = new System.Windows.Forms.TextBox();
            this.radioBox_Mail = new System.Windows.Forms.RadioButton();
            this.radioBox_TelNo = new System.Windows.Forms.RadioButton();
            this.girilenMail = new System.Windows.Forms.TextBox();
            this.btn_sifreGonder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // anaEkranaDon
            // 
            this.anaEkranaDon.Location = new System.Drawing.Point(12, 12);
            this.anaEkranaDon.Name = "anaEkranaDon";
            this.anaEkranaDon.Size = new System.Drawing.Size(77, 27);
            this.anaEkranaDon.TabIndex = 5;
            this.anaEkranaDon.Text = "< Ana Ekran";
            this.anaEkranaDon.UseVisualStyleBackColor = true;
            this.anaEkranaDon.Click += new System.EventHandler(this.anaEkranaDon_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(72, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // girilenKullaniciAdi
            // 
            this.girilenKullaniciAdi.Location = new System.Drawing.Point(170, 95);
            this.girilenKullaniciAdi.Name = "girilenKullaniciAdi";
            this.girilenKullaniciAdi.Size = new System.Drawing.Size(151, 20);
            this.girilenKullaniciAdi.TabIndex = 0;
            // 
            // radioBox_Mail
            // 
            this.radioBox_Mail.AutoSize = true;
            this.radioBox_Mail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radioBox_Mail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioBox_Mail.Location = new System.Drawing.Point(87, 161);
            this.radioBox_Mail.Name = "radioBox_Mail";
            this.radioBox_Mail.Size = new System.Drawing.Size(53, 17);
            this.radioBox_Mail.TabIndex = 1;
            this.radioBox_Mail.TabStop = true;
            this.radioBox_Mail.Text = "e-Mail";
            this.radioBox_Mail.UseVisualStyleBackColor = false;
            this.radioBox_Mail.CheckedChanged += new System.EventHandler(this.radioBox_Mail_CheckedChanged_1);
            // 
            // radioBox_TelNo
            // 
            this.radioBox_TelNo.AutoSize = true;
            this.radioBox_TelNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radioBox_TelNo.Location = new System.Drawing.Point(209, 161);
            this.radioBox_TelNo.Name = "radioBox_TelNo";
            this.radioBox_TelNo.Size = new System.Drawing.Size(78, 17);
            this.radioBox_TelNo.TabIndex = 2;
            this.radioBox_TelNo.TabStop = true;
            this.radioBox_TelNo.Text = "Telefon No";
            this.radioBox_TelNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioBox_TelNo.UseVisualStyleBackColor = false;
            this.radioBox_TelNo.CheckedChanged += new System.EventHandler(this.radioBox_TelNo_CheckedChanged_1);
            // 
            // girilenMail
            // 
            this.girilenMail.Location = new System.Drawing.Point(75, 203);
            this.girilenMail.Name = "girilenMail";
            this.girilenMail.Size = new System.Drawing.Size(246, 20);
            this.girilenMail.TabIndex = 3;
            // 
            // btn_sifreGonder
            // 
            this.btn_sifreGonder.Location = new System.Drawing.Point(136, 246);
            this.btn_sifreGonder.Name = "btn_sifreGonder";
            this.btn_sifreGonder.Size = new System.Drawing.Size(112, 36);
            this.btn_sifreGonder.TabIndex = 4;
            this.btn_sifreGonder.Text = "Gönder";
            this.btn_sifreGonder.UseVisualStyleBackColor = true;
            this.btn_sifreGonder.Click += new System.EventHandler(this.btn_sifreGonder_Click);
            // 
            // SifremiUnuttumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(624, 339);
            this.Controls.Add(this.btn_sifreGonder);
            this.Controls.Add(this.girilenMail);
            this.Controls.Add(this.radioBox_TelNo);
            this.Controls.Add(this.radioBox_Mail);
            this.Controls.Add(this.girilenKullaniciAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anaEkranaDon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifremiUnuttumEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trendiol | Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button anaEkranaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox girilenKullaniciAdi;
        private System.Windows.Forms.RadioButton radioBox_Mail;
        private System.Windows.Forms.RadioButton radioBox_TelNo;
        private System.Windows.Forms.TextBox girilenMail;
        private System.Windows.Forms.Button btn_sifreGonder;
    }
}