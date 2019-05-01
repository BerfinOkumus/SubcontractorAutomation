namespace YukleniciOtomasyon.WinUI
{
    partial class frmyanTedarikciFirma_Listele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmyanTedarikciFirma_Listele));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.txtFirmaAdiAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvFirmaListele = new System.Windows.Forms.DataGridView();
            this.Secim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnAcilanİhaleAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSorumluPersonel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbTedarikciFirmaGuncelleEkle = new System.Windows.Forms.GroupBox();
            this.txtFirmaTelefonu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirmaMail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirmaAdresi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirmaAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.lblguncelle = new System.Windows.Forms.Label();
            this.lblekle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBoxPersonelBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmaListele)).BeginInit();
            this.gbTedarikciFirmaGuncelleEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(5, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 41);
            this.panel2.TabIndex = 114;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(649, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(33, 35);
            this.btnKapat.TabIndex = 109;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(178, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "TEDARİKÇİ FİRMA GÜNCELLE / EKLE";
            // 
            // groupBoxPersonelBilgileri
            // 
            this.groupBoxPersonelBilgileri.BackColor = System.Drawing.Color.DimGray;
            this.groupBoxPersonelBilgileri.Controls.Add(this.txtFirmaAdiAra);
            this.groupBoxPersonelBilgileri.Controls.Add(this.label6);
            this.groupBoxPersonelBilgileri.Controls.Add(this.dgvFirmaListele);
            this.groupBoxPersonelBilgileri.Controls.Add(this.gbTedarikciFirmaGuncelleEkle);
            this.groupBoxPersonelBilgileri.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxPersonelBilgileri.ForeColor = System.Drawing.Color.White;
            this.groupBoxPersonelBilgileri.Location = new System.Drawing.Point(5, 59);
            this.groupBoxPersonelBilgileri.Name = "groupBoxPersonelBilgileri";
            this.groupBoxPersonelBilgileri.Size = new System.Drawing.Size(687, 584);
            this.groupBoxPersonelBilgileri.TabIndex = 113;
            this.groupBoxPersonelBilgileri.TabStop = false;
            // 
            // txtFirmaAdiAra
            // 
            this.txtFirmaAdiAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFirmaAdiAra.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAdiAra.ForeColor = System.Drawing.Color.Black;
            this.txtFirmaAdiAra.Location = new System.Drawing.Point(475, 200);
            this.txtFirmaAdiAra.Name = "txtFirmaAdiAra";
            this.txtFirmaAdiAra.Size = new System.Drawing.Size(206, 26);
            this.txtFirmaAdiAra.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(393, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 158;
            this.label6.Text = "Firma Adı :";
            // 
            // dgvFirmaListele
            // 
            this.dgvFirmaListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvFirmaListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFirmaListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Secim,
            this.clmnAcilanİhaleAdi,
            this.clmnSorumluPersonel});
            this.dgvFirmaListele.Location = new System.Drawing.Point(6, 232);
            this.dgvFirmaListele.Name = "dgvFirmaListele";
            this.dgvFirmaListele.Size = new System.Drawing.Size(675, 336);
            this.dgvFirmaListele.TabIndex = 157;
            // 
            // Secim
            // 
            this.Secim.HeaderText = "Sec";
            this.Secim.Name = "Secim";
            this.Secim.Width = 40;
            // 
            // clmnAcilanİhaleAdi
            // 
            this.clmnAcilanİhaleAdi.HeaderText = "Açılan İhaleler";
            this.clmnAcilanİhaleAdi.Name = "clmnAcilanİhaleAdi";
            this.clmnAcilanİhaleAdi.Width = 145;
            // 
            // clmnSorumluPersonel
            // 
            this.clmnSorumluPersonel.HeaderText = "Sorumlu Personel";
            this.clmnSorumluPersonel.Name = "clmnSorumluPersonel";
            this.clmnSorumluPersonel.Width = 145;
            // 
            // gbTedarikciFirmaGuncelleEkle
            // 
            this.gbTedarikciFirmaGuncelleEkle.BackColor = System.Drawing.Color.Transparent;
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.lblguncelle);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.lblekle);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.txtFirmaTelefonu);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.label5);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.txtFirmaMail);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.label3);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.txtFirmaAdresi);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.label2);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.txtFirmaAdi);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.label1);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.btnGuncelle);
            this.gbTedarikciFirmaGuncelleEkle.Controls.Add(this.btnKaydet);
            this.gbTedarikciFirmaGuncelleEkle.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbTedarikciFirmaGuncelleEkle.ForeColor = System.Drawing.Color.DimGray;
            this.gbTedarikciFirmaGuncelleEkle.Location = new System.Drawing.Point(6, 14);
            this.gbTedarikciFirmaGuncelleEkle.Name = "gbTedarikciFirmaGuncelleEkle";
            this.gbTedarikciFirmaGuncelleEkle.Size = new System.Drawing.Size(675, 177);
            this.gbTedarikciFirmaGuncelleEkle.TabIndex = 156;
            this.gbTedarikciFirmaGuncelleEkle.TabStop = false;
            // 
            // txtFirmaTelefonu
            // 
            this.txtFirmaTelefonu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFirmaTelefonu.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaTelefonu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtFirmaTelefonu.Location = new System.Drawing.Point(126, 53);
            this.txtFirmaTelefonu.Name = "txtFirmaTelefonu";
            this.txtFirmaTelefonu.Size = new System.Drawing.Size(154, 26);
            this.txtFirmaTelefonu.TabIndex = 192;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(402, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 16);
            this.label5.TabIndex = 191;
            this.label5.Text = "Firma Adresi :";
            // 
            // txtFirmaMail
            // 
            this.txtFirmaMail.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFirmaMail.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtFirmaMail.Location = new System.Drawing.Point(126, 85);
            this.txtFirmaMail.Name = "txtFirmaMail";
            this.txtFirmaMail.Size = new System.Drawing.Size(154, 26);
            this.txtFirmaMail.TabIndex = 190;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 189;
            this.label3.Text = "Firma Telefonu :";
            // 
            // txtFirmaAdresi
            // 
            this.txtFirmaAdresi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFirmaAdresi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAdresi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtFirmaAdresi.Location = new System.Drawing.Point(501, 21);
            this.txtFirmaAdresi.Multiline = true;
            this.txtFirmaAdresi.Name = "txtFirmaAdresi";
            this.txtFirmaAdresi.Size = new System.Drawing.Size(154, 80);
            this.txtFirmaAdresi.TabIndex = 188;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(20, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 187;
            this.label2.Text = "Firma E-Posta :";
            // 
            // txtFirmaAdi
            // 
            this.txtFirmaAdi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtFirmaAdi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFirmaAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtFirmaAdi.Location = new System.Drawing.Point(126, 21);
            this.txtFirmaAdi.Name = "txtFirmaAdi";
            this.txtFirmaAdi.Size = new System.Drawing.Size(154, 26);
            this.txtFirmaAdi.TabIndex = 186;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(46, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 185;
            this.label1.Text = "Firma Adı :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(551, 126);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(49, 46);
            this.btnGuncelle.TabIndex = 154;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(606, 126);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(49, 46);
            this.btnKaydet.TabIndex = 153;
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // lblguncelle
            // 
            this.lblguncelle.AutoSize = true;
            this.lblguncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblguncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblguncelle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblguncelle.ForeColor = System.Drawing.Color.DimGray;
            this.lblguncelle.Location = new System.Drawing.Point(541, 104);
            this.lblguncelle.Name = "lblguncelle";
            this.lblguncelle.Size = new System.Drawing.Size(59, 19);
            this.lblguncelle.TabIndex = 194;
            this.lblguncelle.Text = "Güncelle";
            this.lblguncelle.Visible = false;
            // 
            // lblekle
            // 
            this.lblekle.AutoSize = true;
            this.lblekle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblekle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblekle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblekle.ForeColor = System.Drawing.Color.DimGray;
            this.lblekle.Location = new System.Drawing.Point(622, 104);
            this.lblekle.Name = "lblekle";
            this.lblekle.Size = new System.Drawing.Size(33, 19);
            this.lblekle.TabIndex = 193;
            this.lblekle.Text = "Ekle";
            this.lblekle.Visible = false;
            // 
            // frmyanTedarikciFirma_Listele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBoxPersonelBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmyanTedarikciFirma_Listele";
            this.Text = "frmyanTedarikciFirma_Listele";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxPersonelBilgileri.ResumeLayout(false);
            this.groupBoxPersonelBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFirmaListele)).EndInit();
            this.gbTedarikciFirmaGuncelleEkle.ResumeLayout(false);
            this.gbTedarikciFirmaGuncelleEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxPersonelBilgileri;
        private System.Windows.Forms.GroupBox gbTedarikciFirmaGuncelleEkle;
        private System.Windows.Forms.TextBox txtFirmaAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtFirmaTelefonu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFirmaMail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirmaAdresi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirmaAdiAra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvFirmaListele;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Secim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAcilanİhaleAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSorumluPersonel;
        private System.Windows.Forms.Label lblguncelle;
        private System.Windows.Forms.Label lblekle;
    }
}