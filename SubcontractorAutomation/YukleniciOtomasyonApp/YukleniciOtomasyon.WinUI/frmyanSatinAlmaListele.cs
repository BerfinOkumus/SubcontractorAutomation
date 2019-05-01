using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.SatinAlma;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.WinUI
{
    public partial class frmyanSatinAlmaListele : Form
    {
        public frmyanSatinAlmaListele()
        {
            InitializeComponent();
        }

        T_MalzemeService _malzemeService;

        bool move;
        int mouse_x;
        int mouse_y;

        private void frmyanSatinAlmaListele_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmyanSatinAlmaListele_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmyanSatinAlmaListele_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmyanMalzemeBilgisi_Listele malzemeEkle = new frmyanMalzemeBilgisi_Listele();
            malzemeEkle.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmyanTedarikciFirma_Listele tedarikçiFirmalar = new frmyanTedarikciFirma_Listele();
            tedarikçiFirmalar.Show();
        }

        private void frmyanSatinAlmaListele_Load(object sender, EventArgs e)
        {
            SatinAlmalar secilenSatinAlma = (SatinAlmalar)Tag;

            dtpSatinAlmaTarihi.Value = secilenSatinAlma.SatinAlmaTarihi;
            dtpTeslimTarihi.Value = secilenSatinAlma.TeslimTarihi;
            cmbOdemeTipi.SelectedText = secilenSatinAlma.OdemeTuru.ToString();
            cmbCekVadesi.SelectedText = secilenSatinAlma.CekVadesi.ToString();
            cmbFirmaAdi.SelectedText = secilenSatinAlma.TedarikciFirma.ToString();
            txtToplamFiyat.Text = secilenSatinAlma.ToplamFiyat.ToString();
            dgvMalzemeListele.DataSource = null;
            dgvMalzemeListele.DataSource = secilenSatinAlma.AlinanMalzemeler.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
