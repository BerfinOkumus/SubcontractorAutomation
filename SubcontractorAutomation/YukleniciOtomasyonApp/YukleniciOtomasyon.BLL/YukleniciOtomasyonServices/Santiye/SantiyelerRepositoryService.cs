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
    class SantiyelerRepositoryService
    {
        SantiyelerRepository _santiyelerRepository;
        public SantiyelerRepositoryService()
        {
            _santiyelerRepository = new SantiyelerRepository();
        }
        public int AddDepolarService(Santiyeler santiye)
        {
            try
            {
                return _santiyelerRepository.AddItem(santiye);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        //public List<Santiyeler> TumNakliyeIrsaliyeGetir()
        //{
        //    return _nakliyeIrsaliyeRepository.GetAll().ToList();
        //}

        //public NakliyeIrsaliye NakliyeIrsaliyeGetirById(int ID)
        //{
        //    return _nakliyeIrsaliyeRepository.GetById(ID);
        //}

        //public int DepolarUpdate(NakliyeIrsaliye nakliye)
        //{
        //    return _nakliyeIrsaliyeRepository.UpdateItem(nakliye);
        //}

        //public int DepolarSil(NakliyeIrsaliye nakliye)
        //{
        //    return _nakliyeIrsaliyeRepository.DeleteItem(nakliye);
        //}

        //public List<NakliyeIrsaliyedekiMalzemelerDTO> NakliyeIrsaliyedekiMalzemelerRaporu(string text)
        //{
        //    return _nakliyeIrsaliyeRepository.TasinanMalzemeAra(text).ToList();
        //}


        //public List<NakliyeIrsaliye> TarihlereGoreNakliyeIrsaliyeAraService(DateTime cikisTarihi, DateTime bitisTarihi)
        //{
        //    return _nakliyeIrsaliyeRepository.NakliyeTarihAra(cikisTarihi, bitisTarihi).ToList();
        //}

        //public List<NakliyeIrsaliye> NakliyeIrsaliyeAraService(string text)
        //{
        //    return _nakliyeIrsaliyeRepository.IrsaliyeAra(text).ToList();
        //}
    }
}
