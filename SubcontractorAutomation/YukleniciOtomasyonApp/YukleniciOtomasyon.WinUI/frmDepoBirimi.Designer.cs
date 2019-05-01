namespace YukleniciOtomasyon.WinUI
{
    partial class frmDepoBirimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepoBirimi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.lblguncelle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblekle = new System.Windows.Forms.Label();
            this.txtPersonelAdi_Soyadi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvSatınAlmalarıListele = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatınAlmalarıListele)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DimGray;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvSatınAlmalarıListele);
            this.groupBox1.Location = new System.Drawing.Point(62, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 546);
            this.groupBox1.TabIndex = 129;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.btnPersonelListele);
            this.groupBox2.Controls.Add(this.lblguncelle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblekle);
            this.groupBox2.Controls.Add(this.txtPersonelAdi_Soyadi);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(6, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 219);
            this.groupBox2.TabIndex = 181;
            this.groupBox2.TabStop = false;
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelListele.BackgroundImage")));
            this.btnPersonelListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonelListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelListele.Location = new System.Drawing.Point(973, 143);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(47, 46);
            this.btnPersonelListele.TabIndex = 174;
            this.btnPersonelListele.UseVisualStyleBackColor = false;
            // 
            // lblguncelle
            // 
            this.lblguncelle.AutoSize = true;
            this.lblguncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblguncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblguncelle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblguncelle.ForeColor = System.Drawing.Color.DimGray;
            this.lblguncelle.Location = new System.Drawing.Point(908, 121);
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
            this.label2.Location = new System.Drawing.Point(641, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Depo Ara :";
            // 
            // lblekle
            // 
            this.lblekle.AutoSize = true;
            this.lblekle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblekle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblekle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblekle.ForeColor = System.Drawing.Color.DimGray;
            this.lblekle.Location = new System.Drawing.Point(973, 121);
            this.lblekle.Name = "lblekle";
            this.lblekle.Size = new System.Drawing.Size(33, 19);
            this.lblekle.TabIndex = 177;
            this.lblekle.Text = "Ekle";
            this.lblekle.Visible = false;
            // 
            // txtPersonelAdi_Soyadi
            // 
            this.txtPersonelAdi_Soyadi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPersonelAdi_Soyadi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdi_Soyadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtPersonelAdi_Soyadi.Location = new System.Drawing.Point(721, 135);
            this.txtPersonelAdi_Soyadi.Name = "txtPersonelAdi_Soyadi";
            this.txtPersonelAdi_Soyadi.Size = new System.Drawing.Size(173, 26);
            this.txtPersonelAdi_Soyadi.TabIndex = 111;
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
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(920, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 46);
            this.button3.TabIndex = 126;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgvSatınAlmalarıListele
            // 
            this.dgvSatınAlmalarıListele.AllowUserToAddRows = false;
            this.dgvSatınAlmalarıListele.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dgvSatınAlmalarıListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSatınAlmalarıListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSatınAlmalarıListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatınAlmalarıListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvSatınAlmalarıListele.Location = new System.Drawing.Point(6, 234);
            this.dgvSatınAlmalarıListele.Name = "dgvSatınAlmalarıListele";
            this.dgvSatınAlmalarıListele.Size = new System.Drawing.Size(1037, 306);
            this.dgvSatınAlmalarıListele.TabIndex = 180;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "seçim";
            this.Column1.Name = "Column1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(62, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 37);
            this.panel2.TabIndex = 128;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1013, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 28);
            this.button1.TabIndex = 109;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(492, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "DEPO BİRİMİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(619, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 179;
            this.label1.Text = "Malzeme Ara :";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.textBox1.Location = new System.Drawing.Point(721, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 26);
            this.textBox1.TabIndex = 180;
            // 
            // frmDepoBirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1179, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepoBirimi";
            this.Text = "frmDepoBirimi";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatınAlmalarıListele)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Label lblguncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblekle;
        private System.Windows.Forms.TextBox txtPersonelAdi_Soyadi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dgvSatınAlmalarıListele;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}