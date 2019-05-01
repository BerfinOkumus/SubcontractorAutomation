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
    public partial class frmTeklifBirimi : Form
    {
        public frmTeklifBirimi()
        {
            InitializeComponent();
        }



        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnKaydet_Click(object sender, EventArgs e)
        {
            frmİhaleKaydet ihaleKaydet = new frmİhaleKaydet();
            ihaleKaydet.Show();
        }

        private void frmTeklifBirimi_Load(object sender, EventArgs e)
        {

        }
    }
}
