namespace YukleniciOtomasyon.WinUI
{
    partial class frmİhaleEvraklari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmİhaleEvraklari));
            this.dgvIhaleEvraklari = new System.Windows.Forms.DataGridView();
            this.Secim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnTicaretOdasiKayitBelgesi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnİhaleEvraklari = new System.Windows.Forms.Button();
            this.btnImzaSirkuleri = new System.Windows.Forms.Button();
            this.btnTeklifMektubu = new System.Windows.Forms.Button();
            this.btnGeciciTeminatMektubu = new System.Windows.Forms.Button();
            this.btnIsBitirmeBelgesi = new System.Windows.Forms.Button();
            this.btnTeklifBirimiID = new System.Windows.Forms.Button();
            this.btnMeslekiYeterlilik = new System.Windows.Forms.Button();
            this.btnBankaReferansMektubu = new System.Windows.Forms.Button();
            this.btnOrtakilBeyannamesi = new System.Windows.Forms.Button();
            this.btnVekaletname = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIhaleEvraklari)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxPersonelBilgileri.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvIhaleEvraklari
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            this.dgvIhaleEvraklari.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvIhaleEvraklari.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvIhaleEvraklari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIhaleEvraklari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Secim,
            this.clmnTicaretOdasiKayitBelgesi,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvIhaleEvraklari.GridColor = System.Drawing.Color.DimGray;
            this.dgvIhaleEvraklari.Location = new System.Drawing.Point(6, 267);
            this.dgvIhaleEvraklari.Name = "dgvIhaleEvraklari";
            this.dgvIhaleEvraklari.Size = new System.Drawing.Size(676, 311);
            this.dgvIhaleEvraklari.TabIndex = 38;
            // 
            // Secim
            // 
            this.Secim.HeaderText = "Sec";
            this.Secim.Name = "Secim";
            this.Secim.Width = 40;
            // 
            // clmnTicaretOdasiKayitBelgesi
            // 
            this.clmnTicaretOdasiKayitBelgesi.HeaderText = "Ticaret Odasi Kayıt Belgesi";
            this.clmnTicaretOdasiKayitBelgesi.Name = "clmnTicaretOdasiKayitBelgesi";
            this.clmnTicaretOdasiKayitBelgesi.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "İmza Sirküleri";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Teklif Mektubu";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Geçici Teminat Mektubu";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "İş Bitirme Belgesi";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Vekaletname";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "OrtakilBeyannamesi";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Firmanın Teklif Tutarı";
            this.Column8.Name = "Column8";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(7, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 41);
            this.panel2.TabIndex = 110;
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
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(164, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(367, 23);
            this.label4.TabIndex = 108;
            this.label4.Text = "İHALE EVRAKLARI LİSTELE / GÜNCELLE / EKLE";
            // 
            // groupBoxPersonelBilgileri
            // 
            this.groupBoxPersonelBilgileri.BackColor = System.Drawing.Color.DimGray;
            this.groupBoxPersonelBilgileri.Controls.Add(this.groupBox1);
            this.groupBoxPersonelBilgileri.Controls.Add(this.dgvIhaleEvraklari);
            this.groupBoxPersonelBilgileri.Controls.Add(this.panel1);
            this.groupBoxPersonelBilgileri.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBoxPersonelBilgileri.ForeColor = System.Drawing.Color.White;
            this.groupBoxPersonelBilgileri.Location = new System.Drawing.Point(7, 59);
            this.groupBoxPersonelBilgileri.Name = "groupBoxPersonelBilgileri";
            this.groupBoxPersonelBilgileri.Size = new System.Drawing.Size(687, 584);
            this.groupBoxPersonelBilgileri.TabIndex = 109;
            this.groupBoxPersonelBilgileri.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnTeklifBirimiID);
            this.groupBox1.Controls.Add(this.btnMeslekiYeterlilik);
            this.groupBox1.Controls.Add(this.btnBankaReferansMektubu);
            this.groupBox1.Controls.Add(this.btnOrtakilBeyannamesi);
            this.groupBox1.Controls.Add(this.btnVekaletname);
            this.groupBox1.Controls.Add(this.btnIsBitirmeBelgesi);
            this.groupBox1.Controls.Add(this.btnGeciciTeminatMektubu);
            this.groupBox1.Controls.Add(this.btnTeklifMektubu);
            this.groupBox1.Controls.Add(this.btnImzaSirkuleri);
            this.groupBox1.Controls.Add(this.btnİhaleEvraklari);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(6, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 238);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(7, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 17);
            this.label5.TabIndex = 128;
            this.label5.Text = "Ticaret Odasi Kayit Belgesi :";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.BackgroundImage")));
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuncelle.Location = new System.Drawing.Point(568, 182);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(47, 46);
            this.btnGuncelle.TabIndex = 154;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnKaydet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.BackgroundImage")));
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKaydet.Location = new System.Drawing.Point(621, 182);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(47, 46);
            this.btnKaydet.TabIndex = 153;
            this.btnKaydet.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(87, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 132;
            this.label1.Text = "İmza Sirküleri :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(421, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 150;
            this.label7.Text = "Teklif Birimi ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(77, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 134;
            this.label2.Text = "Teklif Mektubu :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(409, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 17);
            this.label9.TabIndex = 147;
            this.label9.Text = "Mesleki Yeterlilik :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(21, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 17);
            this.label6.TabIndex = 136;
            this.label6.Text = "Geçiçi Teminat Mektubu :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(362, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 17);
            this.label10.TabIndex = 145;
            this.label10.Text = "Banka Referans Mektubu :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(64, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 140;
            this.label8.Text = "İş Bitirme Belgesı :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(392, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 17);
            this.label11.TabIndex = 143;
            this.label11.Text = "OrtakilBeyannamesi :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(435, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 17);
            this.label12.TabIndex = 141;
            this.label12.Text = "Vekaletname :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(11, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 3);
            this.panel1.TabIndex = 105;
            // 
            // btnİhaleEvraklari
            // 
            this.btnİhaleEvraklari.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİhaleEvraklari.Location = new System.Drawing.Point(183, 14);
            this.btnİhaleEvraklari.Name = "btnİhaleEvraklari";
            this.btnİhaleEvraklari.Size = new System.Drawing.Size(142, 28);
            this.btnİhaleEvraklari.TabIndex = 155;
            this.btnİhaleEvraklari.Text = "Dosya Seç";
            this.btnİhaleEvraklari.UseVisualStyleBackColor = true;
            // 
            // btnImzaSirkuleri
            // 
            this.btnImzaSirkuleri.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnImzaSirkuleri.Location = new System.Drawing.Point(183, 42);
            this.btnImzaSirkuleri.Name = "btnImzaSirkuleri";
            this.btnImzaSirkuleri.Size = new System.Drawing.Size(142, 28);
            this.btnImzaSirkuleri.TabIndex = 156;
            this.btnImzaSirkuleri.Text = "Dosya Seç";
            this.btnImzaSirkuleri.UseVisualStyleBackColor = true;
            // 
            // btnTeklifMektubu
            // 
            this.btnTeklifMektubu.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeklifMektubu.Location = new System.Drawing.Point(183, 70);
            this.btnTeklifMektubu.Name = "btnTeklifMektubu";
            this.btnTeklifMektubu.Size = new System.Drawing.Size(142, 28);
            this.btnTeklifMektubu.TabIndex = 157;
            this.btnTeklifMektubu.Text = "Dosya Seç";
            this.btnTeklifMektubu.UseVisualStyleBackColor = true;
            // 
            // btnGeciciTeminatMektubu
            // 
            this.btnGeciciTeminatMektubu.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeciciTeminatMektubu.Location = new System.Drawing.Point(183, 98);
            this.btnGeciciTeminatMektubu.Name = "btnGeciciTeminatMektubu";
            this.btnGeciciTeminatMektubu.Size = new System.Drawing.Size(142, 28);
            this.btnGeciciTeminatMektubu.TabIndex = 158;
            this.btnGeciciTeminatMektubu.Text = "Dosya Seç";
            this.btnGeciciTeminatMektubu.UseVisualStyleBackColor = true;
            // 
            // btnIsBitirmeBelgesi
            // 
            this.btnIsBitirmeBelgesi.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIsBitirmeBelgesi.Location = new System.Drawing.Point(183, 126);
            this.btnIsBitirmeBelgesi.Name = "btnIsBitirmeBelgesi";
            this.btnIsBitirmeBelgesi.Size = new System.Drawing.Size(142, 28);
            this.btnIsBitirmeBelgesi.TabIndex = 159;
            this.btnIsBitirmeBelgesi.Text = "Dosya Seç";
            this.btnIsBitirmeBelgesi.UseVisualStyleBackColor = true;
            // 
            // btnTeklifBirimiID
            // 
            this.btnTeklifBirimiID.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTeklifBirimiID.Location = new System.Drawing.Point(526, 126);
            this.btnTeklifBirimiID.Name = "btnTeklifBirimiID";
            this.btnTeklifBirimiID.Size = new System.Drawing.Size(142, 28);
            this.btnTeklifBirimiID.TabIndex = 164;
            this.btnTeklifBirimiID.Text = "Dosya Seç";
            this.btnTeklifBirimiID.UseVisualStyleBackColor = true;
            // 
            // btnMeslekiYeterlilik
            // 
            this.btnMeslekiYeterlilik.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMeslekiYeterlilik.Location = new System.Drawing.Point(526, 98);
            this.btnMeslekiYeterlilik.Name = "btnMeslekiYeterlilik";
            this.btnMeslekiYeterlilik.Size = new System.Drawing.Size(142, 28);
            this.btnMeslekiYeterlilik.TabIndex = 163;
            this.btnMeslekiYeterlilik.Text = "Dosya Seç";
            this.btnMeslekiYeterlilik.UseVisualStyleBackColor = true;
            // 
            // btnBankaReferansMektubu
            // 
            this.btnBankaReferansMektubu.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankaReferansMektubu.Location = new System.Drawing.Point(526, 70);
            this.btnBankaReferansMektubu.Name = "btnBankaReferansMektubu";
            this.btnBankaReferansMektubu.Size = new System.Drawing.Size(142, 28);
            this.btnBankaReferansMektubu.TabIndex = 162;
            this.btnBankaReferansMektubu.Text = "Dosya Seç";
            this.btnBankaReferansMektubu.UseVisualStyleBackColor = true;
            // 
            // btnOrtakilBeyannamesi
            // 
            this.btnOrtakilBeyannamesi.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOrtakilBeyannamesi.Location = new System.Drawing.Point(526, 42);
            this.btnOrtakilBeyannamesi.Name = "btnOrtakilBeyannamesi";
            this.btnOrtakilBeyannamesi.Size = new System.Drawing.Size(142, 28);
            this.btnOrtakilBeyannamesi.TabIndex = 161;
            this.btnOrtakilBeyannamesi.Text = "Dosya Seç";
            this.btnOrtakilBeyannamesi.UseVisualStyleBackColor = true;
            // 
            // btnVekaletname
            // 
            this.btnVekaletname.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVekaletname.Location = new System.Drawing.Point(526, 14);
            this.btnVekaletname.Name = "btnVekaletname";
            this.btnVekaletname.Size = new System.Drawing.Size(142, 28);
            this.btnVekaletname.TabIndex = 160;
            this.btnVekaletname.Text = "Dosya Seç";
            this.btnVekaletname.UseVisualStyleBackColor = true;
            // 
            // frmİhaleEvraklari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBoxPersonelBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmİhaleEvraklari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IhaleListele";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmİhaleEvraklari_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmİhaleEvraklari_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmİhaleEvraklari_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIhaleEvraklari)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBoxPersonelBilgileri.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIhaleEvraklari;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxPersonelBilgileri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Secim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnTicaretOdasiKayitBelgesi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnTeklifBirimiID;
        private System.Windows.Forms.Button btnMeslekiYeterlilik;
        private System.Windows.Forms.Button btnBankaReferansMektubu;
        private System.Windows.Forms.Button btnOrtakilBeyannamesi;
        private System.Windows.Forms.Button btnVekaletname;
        private System.Windows.Forms.Button btnIsBitirmeBelgesi;
        private System.Windows.Forms.Button btnGeciciTeminatMektubu;
        private System.Windows.Forms.Button btnTeklifMektubu;
        private System.Windows.Forms.Button btnImzaSirkuleri;
        private System.Windows.Forms.Button btnİhaleEvraklari;
    }
}