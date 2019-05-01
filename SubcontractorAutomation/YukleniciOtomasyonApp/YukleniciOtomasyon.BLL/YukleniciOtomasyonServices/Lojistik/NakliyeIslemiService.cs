using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.Lojistik;
using YukleniciOtomasyon.Entities.Model.Lojistik;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.Lojistik
{
    public class NakliyeIslemiService
    {
        NakliyeIslemiRepository _nakliyeIslemiRepository;
        public NakliyeIslemiService()
        {
            _nakliyeIslemiRepository = new NakliyeIslemiRepository();
        }
        public int AddNakliyeIslemiService(NakliyeIslemi nakliyeIslemi)
        {
            try
            {
                return _nakliyeIslemiRepository.AddItem(nakliyeIslemi);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<NakliyeIslemi> TumNakliyeIslemleriniGetir()
        {
            return _nakliyeIslemiRepository.GetAll().ToList();
        }

        public NakliyeIslemi NakliyeIslemleriniGetirById(int ID)
        {
            return _nakliyeIslemiRepository.GetById(ID);
        }

        public int NakliyeIslemiUpdate(NakliyeIslemi nakliyeIslemi)
        {
            return _nakliyeIslemiRepository.UpdateItem(nakliyeIslemi);
        }

        public int NakliyeIslemiSil(NakliyeIslemi nakliyeIslemi)
        {
            return _nakliyeIslemiRepository.DeleteItem(nakliyeIslemi);
        }

        public List<NakliyeIslemi> NakliyeAraService(string text)
        {
            return _nakliyeIslemiRepository.NakliyeAra(text).ToList();
        }

        //public List<DepoMalzemeDTO> DepolarMalzemeRaporu(string text)
        //{
        //    return _depolarRepository.DepodaMalzemeAra(text).ToList();
        //}

        //public List<Depolar> ArananDepolarService(string isim)
        //{
        //    return _depolarRepository.DepoAra(isim).ToList();
        //}
    }
}
