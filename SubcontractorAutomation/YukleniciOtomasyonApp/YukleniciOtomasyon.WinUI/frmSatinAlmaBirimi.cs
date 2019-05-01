using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.SatinAlma;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.WinUI
{
    public partial class frmSatinAlmaBirimi : Form
    {
        public frmSatinAlmaBirimi()
        {
            InitializeComponent();
        }

        SatinAlmalarService _satinAlmalarService;
        SatinAlmalar satinAlmalar;

        public void SatinAlmaGetir()
        {
            dgvSatinAlmalariListele.DataSource = null;
            List<SatinAlmalar> satinAlmaListesi = _satinAlmalarService.TumSatinAlmalariGetirService();
            dgvSatinAlmalariListele.DataSource = satinAlmaListesi;
        }
        private void frmSatinAlmaBirimi_Load(object sender, EventArgs e)
        {
            SatinAlmaGetir();
        }
        //Hangi birim için satın alıyoruz.
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmyanSatinAlmaListele satinAlma = new frmyanSatinAlmaListele();
            satinAlma.Show();
        }

        private void txtPersonelAdiSoyadi_TextChanged(object sender, EventArgs e)
        {
            dgvSatinAlmalariListele.DataSource = null;
            List<SatinAlmalar> satinAlmaListesi = _satinAlmalarService.SatinAlmaAraService(txtPersonelAdiSoyadi.Text);
            dgvSatinAlmalariListele.DataSource = satinAlmaListesi;
        }

        private void dtpIsBaslangicTarihi_ValueChanged(object sender, EventArgs e)
        {
            dgvSatinAlmalariListele.DataSource = null;
            List<SatinAlmalar> satinAlmaListesi = _satinAlmalarService.SatinAlmaTarihAraService(dtpIlkTarih.Value, dtpSonTarih.Value);
            dgvSatinAlmalariListele.DataSource = satinAlmaListesi;
        }

        private void dgvSatinAlmalariListele_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var columnIndex = 0;
            if (e.ColumnIndex == columnIndex)
            {
                var isChecked = (bool)dgvSatinAlmalariListele.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (isChecked)
                {
                    foreach (DataGridViewRow row in dgvSatinAlmalariListele.Rows)
                    {
                        if (row.Index != e.RowIndex)
                        {
                            row.Cells[columnIndex].Value = !isChecked;
                        }
                    }
                }
            }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmyanSatinAlmaListele satinAlma = new frmyanSatinAlmaListele();
            satinAlma.Tag = satinAlmalar;
            satinAlma.Show();
        }
        
        private void dgvSatinAlmalariListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgvSatinAlmalariListele.RowCount; i++)
            {
                bool seciliCheckbox = (bool)dgvSatinAlmalariListele.Rows[i].Cells[0].Value;
                if (seciliCheckbox == true)
                {
                    int seciliSatinAlma = Convert.ToInt32(dgvSatinAlmalariListele.SelectedRows[0].Cells[1].Value);
                    satinAlmalar = _satinAlmalarService.BirSatinAlmaGetirService(seciliSatinAlma);
                   
                }
            }
        }
    }
}
