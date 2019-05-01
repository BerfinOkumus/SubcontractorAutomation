namespace YukleniciOtomasyon.WinUI
{
    partial class frmSorumluPersonelSecme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSorumluPersonelSecme));
            this.btnAra = new System.Windows.Forms.Button();
            this.txtPersonelAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTekliflerListele = new System.Windows.Forms.DataGridView();
            this.Secim = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnAcilanİhaleAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnSorumluPersonel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTekliflerListele)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAra.BackgroundImage")));
            this.btnAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAra.Location = new System.Drawing.Point(517, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(43, 42);
            this.btnAra.TabIndex = 175;
            this.btnAra.UseVisualStyleBackColor = false;
            // 
            // txtPersonelAdi
            // 
            this.txtPersonelAdi.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPersonelAdi.Font = new System.Drawing.Font("Verdana", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPersonelAdi.ForeColor = System.Drawing.Color.Black;
            this.txtPersonelAdi.Location = new System.Drawing.Point(301, 20);
            this.txtPersonelAdi.Name = "txtPersonelAdi";
            this.txtPersonelAdi.Size = new System.Drawing.Size(206, 26);
            this.txtPersonelAdi.TabIndex = 174;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(201, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 173;
            this.label2.Text = "Personel Adı :";
            // 
            // dgvTekliflerListele
            // 
            this.dgvTekliflerListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTekliflerListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTekliflerListele.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Secim,
            this.clmnAcilanİhaleAdi,
            this.clmnSorumluPersonel});
            this.dgvTekliflerListele.Location = new System.Drawing.Point(12, 60);
            this.dgvTekliflerListele.Name = "dgvTekliflerListele";
            this.dgvTekliflerListele.Size = new System.Drawing.Size(597, 381);
            this.dgvTekliflerListele.TabIndex = 172;
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
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(566, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(43, 42);
            this.btnKapat.TabIndex = 176;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // frmSorumluPersonelSecme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(621, 453);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtPersonelAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTekliflerListele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSorumluPersonelSecme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SorumluPersonelSecme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTekliflerListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtPersonelAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTekliflerListele;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Secim;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnAcilanİhaleAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnSorumluPersonel;
        private System.Windows.Forms.Button btnKapat;
    }
}