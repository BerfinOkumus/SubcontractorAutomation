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
    public partial class frmİhaleKaydet : Form
    {
        public frmİhaleKaydet()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmİhaleEvraklari ihaleEvraklari = new frmİhaleEvraklari();
            ihaleEvraklari.Show();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void frmİhaleKaydet_MouseDown_1(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void frmİhaleKaydet_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void frmİhaleKaydet_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
