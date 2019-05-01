namespace YukleniciOtomasyon.WinUI
{
    partial class frmIKBirimi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIKBirimi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPersonelBilgileri = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPersonelListele = new System.Windows.Forms.Button();
            this.lblguncelle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblekle = new System.Windows.Forms.Label();
            this.txtPersonelAra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvPersonelListele = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            this.gbPersonelBilgileri.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListele)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(62, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 37);
            this.panel2.TabIndex = 108;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(1015, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 109;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Ebrima", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(377, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(324, 25);
            this.label4.TabIndex = 108;
            this.label4.Text = "İNSAN KAYNAKLARI DEPARTMANI";
            // 
            // gbPersonelBilgileri
            // 
            this.gbPersonelBilgileri.BackColor = System.Drawing.Color.DimGray;
            this.gbPersonelBilgileri.Controls.Add(this.groupBox2);
            this.gbPersonelBilgileri.Controls.Add(this.dgvPersonelListele);
            this.gbPersonelBilgileri.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.gbPersonelBilgileri.ForeColor = System.Drawing.Color.White;
            this.gbPersonelBilgileri.Location = new System.Drawing.Point(62, 55);
            this.gbPersonelBilgileri.Name = "gbPersonelBilgileri";
            this.gbPersonelBilgileri.Size = new System.Drawing.Size(1049, 546);
            this.gbPersonelBilgileri.TabIndex = 107;
            this.gbPersonelBilgileri.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.btnPersonelListele);
            this.groupBox2.Controls.Add(this.lblguncelle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblekle);
            this.groupBox2.Controls.Add(this.txtPersonelAra);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1037, 219);
            this.groupBox2.TabIndex = 179;
            this.groupBox2.TabStop = false;
            // 
            // btnPersonelListele
            // 
            this.btnPersonelListele.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonelListele.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPersonelListele.BackgroundImage")));
            this.btnPersonelListele.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPersonelListele.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPersonelListele.Location = new System.Drawing.Point(971, 152);
            this.btnPersonelListele.Name = "btnPersonelListele";
            this.btnPersonelListele.Size = new System.Drawing.Size(47, 46);
            this.btnPersonelListele.TabIndex = 174;
            this.btnPersonelListele.UseVisualStyleBackColor = false;
            this.btnPersonelListele.Click += new System.EventHandler(this.btnPersonelListele_Click);
            // 
            // lblguncelle
            // 
            this.lblguncelle.AutoSize = true;
            this.lblguncelle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblguncelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblguncelle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblguncelle.ForeColor = System.Drawing.Color.DimGray;
            this.lblguncelle.Location = new System.Drawing.Point(920, 130);
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
            this.label2.Location = new System.Drawing.Point(639, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 110;
            this.label2.Text = "Personel Ara :";
            // 
            // lblekle
            // 
            this.lblekle.AutoSize = true;
            this.lblekle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblekle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblekle.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblekle.ForeColor = System.Drawing.Color.DimGray;
            this.lblekle.Location = new System.Drawing.Point(985, 130);
            this.lblekle.Name = "lblekle";
            this.lblekle.Size = new System.Drawing.Size(33, 19);
            this.lblekle.TabIndex = 177;
            this.lblekle.Text = "Ekle";
            this.lblekle.Visible = false;
            // 
            // txtPersonelAra
            // 
            this.txtPersonelAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPersonelAra.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(114)))));
            this.txtPersonelAra.Location = new System.Drawing.Point(739, 172);
            this.txtPersonelAra.Name = "txtPersonelAra";
            this.txtPersonelAra.Size = new System.Drawing.Size(173, 26);
            this.txtPersonelAra.TabIndex = 111;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(32, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 202);
            this.pictureBox1.TabIndex = 175;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(918, 152);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 46);
            this.button3.TabIndex = 126;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dgvPersonelListele
            // 
            this.dgvPersonelListele.AllowUserToAddRows = false;
            this.dgvPersonelListele.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gainsboro;
            this.dgvPersonelListele.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPersonelListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPersonelListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonelListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvPersonelListele.Location = new System.Drawing.Point(6, 237);
            this.dgvPersonelListele.Name = "dgvPersonelListele";
            this.dgvPersonelListele.Size = new System.Drawing.Size(1037, 292);
            this.dgvPersonelListele.TabIndex = 114;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "seçim";
            this.Column1.Name = "Column1";
            // 
            // frmIKBirimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gbPersonelBilgileri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmIKBirimi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PersonelListele";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmIKBirimi_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbPersonelBilgileri.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonelListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPersonelBilgileri;
        private System.Windows.Forms.TextBox txtPersonelAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPersonelListele;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Button btnPersonelListele;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblguncelle;
        private System.Windows.Forms.Label lblekle;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}