namespace YukleniciOtomasyon.WinUI
{
    partial class frmSatinAlmaBirimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatinAlmaBirimi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblKapat = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpIlkTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblguncelle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblekle = new System.Windows.Forms.Label();
            this.txtPersonelAdiSoyadi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dgvSatinAlmalariListele = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.malzemeAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatinAlmalariListele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblKapat);
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(62, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 37);
            this.panel2.TabIndex = 109;
            // 
            // lblKapat
            // 
            this.lblKapat.AutoSize = true;
            this.lblKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblKapat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblKapat.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKapat.ForeColor = System.Drawing.Color.DimGray;
            this.lblKapat.Location = new System.Drawing.Point(963, 8);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(44, 19);
            this.lblKapat.TabIndex = 185;
            this.lblKapat.Text = "Kapat";
            this.lblKapat.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Transparent;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKapat.Location = new System.Drawing.Point(1013, 3);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(30, 28);
            this.btnKapat.TabIndex = 109;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(392, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(256, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "SATIN ALMA DEPARTMANI";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvSatinAlmalariListele);
            this.groupBox1.Location = new System.Drawing.Point(62, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 546);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.dtpSonTarih);
            this.groupBox2.Controls.Add(this.dtpIlkTarih);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnEkle);
            this.groupBox2.Controls.Add(this.lblguncelle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblekle);
            this.groupBox2.Controls.Add(this.txtPersonelAdiSoyadi);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.btnGuncelle);
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 219);
            this.groupBox2.TabIndex = 181;
            this.groupBox2.TabStop = false;
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.CalendarFont = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpSonTarih.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpSonTarih.Location = new System.Drawing.Point(729, 123);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(171, 19);
            this.dtpSonTarih.TabIndex = 184;
            // 
            // dtpIlkTarih
            // 
            this.dtpIlkTarih.CalendarFont = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIlkTarih.Font = new System.Drawing.Font("Ebrima", 7F, System.Drawing.FontStyle.Bold);
            this.dtpIlkTarih.Location = new System.Drawing.Point(550, 123);
            this.dtpIlkTarih.Name = "dtpIlkTarih";
            this.dtpIlkTarih.Size = new System.Drawing.Size(173, 19);
            this.dtpIlkTarih.TabIndex = 183;
            this.dtpIlkTarih.ValueChanged += new System.EventHandler(this.dtpIsBaslangicTarihi_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(405, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 182;
            this.label1.Text = "Tarih Aralığı Seçiniz :";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEkle.BackgroundImage")));
            this.btnEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEkle.Location = new System.Drawing.Point(969, 145);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(47, 46);
            this.btnEkle.TabIndex = 174;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // lblguncelle
            // 
            this.lblguncelle.AutoSize = true;
            this.lblguncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblguncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblguncelle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblguncelle.ForeColor = System.Drawing.Color.DimGray;
            this.lblguncelle.Location = new System.Drawing.Point(906, 124);
            this.lblguncelle.Name = "lblguncelle";
            this.lblguncelle.Size = new System.Drawing.Size(59, 19);
            this.lblguncelle.TabIndex = 178;
            this.lblguncelle.Text = "Güncelle";
            this.lblguncelle.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(436, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Satın Alma Ara :";
            // 
            // lblekle
            // 
            this.lblekle.AutoSize = true;
            this.lblekle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblekle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblekle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblekle.ForeColor = System.Drawing.Color.DimGray;
            this.lblekle.Location = new System.Drawing.Point(983, 123);
            this.lblekle.Name = "lblekle";
            this.lblekle.Size = new System.Drawing.Size(33, 19);
            this.lblekle.TabIndex = 177;
            this.lblekle.Text = "Ekle";
            this.lblekle.Visible = false;
            // 
            // txtPersonelAdiSoyadi
            // 
            this.txtPersonelAdiSoyadi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPersonelAdiSoyadi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdiSoyadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtPersonelAdiSoyadi.Location = new System.Drawing.Point(550, 148);
            this.txtPersonelAdiSoyadi.Name = "txtPersonelAdiSoyadi";
            this.txtPersonelAdiSoyadi.Size = new System.Drawing.Size(173, 26);
            this.txtPersonelAdiSoyadi.TabIndex = 111;
            this.txtPersonelAdiSoyadi.TextChanged += new System.EventHandler(this.txtPersonelAdiSoyadi_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 199);
            this.pictureBox1.TabIndex = 175;
            this.pictureBox1.TabStop = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(916, 145);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(47, 46);
            this.btnGuncelle.TabIndex = 126;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dgvSatinAlmalariListele
            // 
            this.dgvSatinAlmalariListele.AllowUserToAddRows = false;
            this.dgvSatinAlmalariListele.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dgvSatinAlmalariListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSatinAlmalariListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSatinAlmalariListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatinAlmalariListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.malzemeAdi});
            this.dgvSatinAlmalariListele.Location = new System.Drawing.Point(6, 234);
            this.dgvSatinAlmalariListele.Name = "dgvSatinAlmalariListele";
            this.dgvSatinAlmalariListele.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSatinAlmalariListele.Size = new System.Drawing.Size(1037, 306);
            this.dgvSatinAlmalariListele.TabIndex = 180;
            this.dgvSatinAlmalariListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSatinAlmalariListele_CellContentClick);
            this.dgvSatinAlmalariListele.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSatinAlmalariListele_CellValueChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Seç";
            this.Column1.Name = "Column1";
            // 
            // malzemeAdi
            // 
            this.malzemeAdi.HeaderText = "Malzeme Adı";
            this.malzemeAdi.Name = "malzemeAdi";
            // 
            // frmSatinAlmaBirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSatinAlmaBirimi";
            this.Text = "SATIN ALMA DEPARTMANI";
            this.TopMost = true;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatinAlmalariListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblguncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblekle;
        private System.Windows.Forms.TextBox txtPersonelAdiSoyadi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DataGridView dgvSatinAlmalariListele;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.DateTimePicker dtpIlkTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdi;
    }
}