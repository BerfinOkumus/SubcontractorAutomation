using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Santiye;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Santiye
{
    public class SantiyeIsTakibiService
    {
        SantiyeIsTakibiRepository _santiyeIsTakibiRepository;
        public SantiyeIsTakibiService()
        {
            _santiyeIsTakibiRepository = new SantiyeIsTakibiRepository();
        }
        public int AddDepolarService(SantiyeIsTakibi santiye)
        {
            try
            {
                return _santiyeIsTakibiRepository.AddItem(santiye);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<SantiyeIsTakibi> TumSantiyeIsTakibleriniGetir()
        {
            return _santiyeIsTakibiRepository.GetAll().ToList();
        }

        public SantiyeIsTakibi SantiyeIsTakibiGetirById(int ID)
        {
            return _santiyeIsTakibiRepository.GetById(ID);
        }

        public int SantiyeIsTakibiUpdate(SantiyeIsTakibi santiye)
        {
            return _santiyeIsTakibiRepository.UpdateItem(santiye);
        }

        public int SantiyeIsTakibiSil(SantiyeIsTakibi santiye)
        {
            return _santiyeIsTakibiRepository.DeleteItem(santiye);
        }

        //public List<SantiyeIsTakibindekiMalzemelerDTO> SantiyeIsTakibindekiMalzemelerinRaporu(string text)
        //{
        //    return _santiyeIsTakibiRepository.IsTakibiAra(text).ToList();
        //}


        public List<SantiyeIsTakibi> TarihlereGoreSantiyeIsTakibiTarihAraService(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            return _santiyeIsTakibiRepository.IsTakibiTarihAra(baslangicTarihi, bitisTarihi).ToList();
        }
    }
}
