namespace YukleniciOtomasyon.WinUI
{
    partial class FrmSantiyeMalzemeIstekListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSantiyeMalzemeIstekListele));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIstekGonder = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpMontajGunu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSantiyeMalzemeIstekListele = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.cmbSantiyeAdi = new System.Windows.Forms.ComboBox();
            this.cmbTalepEden = new System.Windows.Forms.ComboBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtKullanilacagiYer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSantiyeAdiAra = new System.Windows.Forms.ComboBox();
            this.cmbMalzemeAdiAra = new System.Windows.Forms.ComboBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSantiyeMalzemeIstekListele)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cmbTalepEden);
            this.groupBox1.Controls.Add(this.cmbSantiyeAdi);
            this.groupBox1.Controls.Add(this.txtMalzemeAdi);
            this.groupBox1.Controls.Add(this.btnIstekGonder);
            this.groupBox1.Controls.Add(this.txtAdet);
            this.groupBox1.Controls.Add(this.txtKullanilacagiYer);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpMontajGunu);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnIstekGonder
            // 
            this.btnIstekGonder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.btnIstekGonder.Location = new System.Drawing.Point(167, 347);
            this.btnIstekGonder.Name = "btnIstekGonder";
            this.btnIstekGonder.Size = new System.Drawing.Size(150, 28);
            this.btnIstekGonder.TabIndex = 82;
            this.btnIstekGonder.Text = "İStek Gönder";
            this.btnIstekGonder.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label8.Location = new System.Drawing.Point(47, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 79;
            this.label8.Text = "Şantiye adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label7.Location = new System.Drawing.Point(47, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 16);
            this.label7.TabIndex = 78;
            this.label7.Text = "Talep Eden:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label4.Location = new System.Drawing.Point(30, 275);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 77;
            this.label4.Text = "Montaj Günü:";
            // 
            // dtpMontajGunu
            // 
            this.dtpMontajGunu.Location = new System.Drawing.Point(163, 283);
            this.dtpMontajGunu.Name = "dtpMontajGunu";
            this.dtpMontajGunu.Size = new System.Drawing.Size(154, 23);
            this.dtpMontajGunu.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label3.Location = new System.Drawing.Point(86, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "Adet:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label2.Location = new System.Drawing.Point(5, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "Kullanılacağı Yer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label1.Location = new System.Drawing.Point(32, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Malzeme Ad:";
            // 
            // dgvSantiyeMalzemeIstekListele
            // 
            this.dgvSantiyeMalzemeIstekListele.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.dgvSantiyeMalzemeIstekListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSantiyeMalzemeIstekListele.Location = new System.Drawing.Point(409, 160);
            this.dgvSantiyeMalzemeIstekListele.Name = "dgvSantiyeMalzemeIstekListele";
            this.dgvSantiyeMalzemeIstekListele.Size = new System.Drawing.Size(673, 320);
            this.dgvSantiyeMalzemeIstekListele.TabIndex = 113;
            this.dgvSantiyeMalzemeIstekListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label5.Location = new System.Drawing.Point(450, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 16);
            this.label5.TabIndex = 121;
            this.label5.Text = "bu combobox muhendise gore gelecek";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label6.Location = new System.Drawing.Point(450, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 16);
            this.label6.TabIndex = 120;
            this.label6.Text = "bu formu proje muduru gorecek";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label12.Location = new System.Drawing.Point(454, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 16);
            this.label12.TabIndex = 118;
            this.label12.Text = "Şantiye Adı:";
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.txtMalzemeAdi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMalzemeAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtMalzemeAdi.Location = new System.Drawing.Point(163, 181);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(154, 26);
            this.txtMalzemeAdi.TabIndex = 142;
            // 
            // cmbSantiyeAdi
            // 
            this.cmbSantiyeAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.cmbSantiyeAdi.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbSantiyeAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.cmbSantiyeAdi.FormattingEnabled = true;
            this.cmbSantiyeAdi.Location = new System.Drawing.Point(163, 117);
            this.cmbSantiyeAdi.Name = "cmbSantiyeAdi";
            this.cmbSantiyeAdi.Size = new System.Drawing.Size(153, 24);
            this.cmbSantiyeAdi.TabIndex = 146;
            // 
            // cmbTalepEden
            // 
            this.cmbTalepEden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.cmbTalepEden.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbTalepEden.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.cmbTalepEden.FormattingEnabled = true;
            this.cmbTalepEden.Location = new System.Drawing.Point(163, 149);
            this.cmbTalepEden.Name = "cmbTalepEden";
            this.cmbTalepEden.Size = new System.Drawing.Size(153, 24);
            this.cmbTalepEden.TabIndex = 144;
            // 
            // txtAdet
            // 
            this.txtAdet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.txtAdet.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAdet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtAdet.Location = new System.Drawing.Point(164, 249);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(153, 26);
            this.txtAdet.TabIndex = 145;
            // 
            // txtKullanilacagiYer
            // 
            this.txtKullanilacagiYer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.txtKullanilacagiYer.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanilacagiYer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtKullanilacagiYer.Location = new System.Drawing.Point(164, 215);
            this.txtKullanilacagiYer.Name = "txtKullanilacagiYer";
            this.txtKullanilacagiYer.Size = new System.Drawing.Size(153, 26);
            this.txtKullanilacagiYer.TabIndex = 143;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.label9.Location = new System.Drawing.Point(443, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 122;
            this.label9.Text = "Malzeme Adı:";
            // 
            // cmbSantiyeAdiAra
            // 
            this.cmbSantiyeAdiAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.cmbSantiyeAdiAra.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbSantiyeAdiAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.cmbSantiyeAdiAra.FormattingEnabled = true;
            this.cmbSantiyeAdiAra.Location = new System.Drawing.Point(581, 18);
            this.cmbSantiyeAdiAra.Name = "cmbSantiyeAdiAra";
            this.cmbSantiyeAdiAra.Size = new System.Drawing.Size(153, 24);
            this.cmbSantiyeAdiAra.TabIndex = 147;
            // 
            // cmbMalzemeAdiAra
            // 
            this.cmbMalzemeAdiAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(35)))), ((int)(((byte)(44)))));
            this.cmbMalzemeAdiAra.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbMalzemeAdiAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.cmbMalzemeAdiAra.FormattingEnabled = true;
            this.cmbMalzemeAdiAra.Location = new System.Drawing.Point(581, 74);
            this.cmbMalzemeAdiAra.Name = "cmbMalzemeAdiAra";
            this.cmbMalzemeAdiAra.Size = new System.Drawing.Size(153, 24);
            this.cmbMalzemeAdiAra.TabIndex = 148;
            // 
            // btnAra
            // 
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Location = new System.Drawing.Point(781, 26);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(55, 69);
            this.btnAra.TabIndex = 149;
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // FrmSantiyeMalzemeIstekListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1094, 611);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cmbMalzemeAdiAra);
            this.Controls.Add(this.cmbSantiyeAdiAra);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvSantiyeMalzemeIstekListele);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSantiyeMalzemeIstekListele";
            this.Text = "ŞANTİYE MALZEME İSTEK LİSTELE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSantiyeMalzemeIstekListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIstekGonder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpMontajGunu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSantiyeMalzemeIstekListele;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.ComboBox cmbSantiyeAdi;
        private System.Windows.Forms.ComboBox cmbTalepEden;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtKullanilacagiYer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSantiyeAdiAra;
        private System.Windows.Forms.ComboBox cmbMalzemeAdiAra;
        private System.Windows.Forms.Button btnAra;
    }
}