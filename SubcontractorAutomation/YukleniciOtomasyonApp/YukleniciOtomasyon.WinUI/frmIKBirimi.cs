using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YukleniciOtomasyon.WinUI
{
    public partial class frmIKBirimi : Form
    {
        public frmIKBirimi()
        {
            InitializeComponent();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            PersonelBilgileriGuncelle_Kaydet PersonelKaydet = new PersonelBilgileriGuncelle_Kaydet();
            PersonelKaydet.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmIKBirimi_Load(object sender, EventArgs e)
        {

        }
    }
}
