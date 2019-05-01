using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Santiye;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Santiye
{
    public class SantiyeBirimiService
    {
        SantiyeBirimiRepository _santiyeBirimiRepository;
        public SantiyeBirimiService()
        {
            _santiyeBirimiRepository = new SantiyeBirimiRepository();
        }

        public int AddDepolarService(SantiyeBirimi santiye)
        {
            try
            {
                return _santiyeBirimiRepository.AddItem(santiye);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<SantiyeBirimi> TumSantiyeBirimleriniGetir()
        {
            return _santiyeBirimiRepository.GetAll().ToList();
        }

        public SantiyeBirimi SantiyeBirimleriniGetirById(int ID)
        {
            return _santiyeBirimiRepository.GetById(ID);
        }

        public int SantiyeBirimiUpdate(SantiyeBirimi santiye)
        {
            return _santiyeBirimiRepository.UpdateItem(santiye);
        }

        public int SantiyeBirimiSil(SantiyeBirimi santiye)
        {
            return _santiyeBirimiRepository.DeleteItem(santiye);
        }
    }
}
