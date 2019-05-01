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
    public partial class PersonelBilgileriGuncelle_Kaydet : Form
    {
        public PersonelBilgileriGuncelle_Kaydet()
        {
            InitializeComponent();
        }

        private void btnFormKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool move;
        int mouse_x;
        int mouse_y;

        private void PersonelBilgileriGuncelle_Kaydet_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void PersonelBilgileriGuncelle_Kaydet_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void PersonelBilgileriGuncelle_Kaydet_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }
    }
}
