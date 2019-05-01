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
    public class LojistikBirimiService
    {
        LojistikBirimiRepository _lojistikBirimiRepository;
        public LojistikBirimiService()
        {
            _lojistikBirimiRepository = new LojistikBirimiRepository();
        }
        public int AddLojistikBirimiService(LojistikBirimi lojistik)
        {
            try
            {
                return _lojistikBirimiRepository.AddItem(lojistik);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                return 0;
            }
        }
        public List<LojistikBirimi> TumDepolarıGetir()
        {
            return _lojistikBirimiRepository.GetAll().ToList();
        }

        public LojistikBirimi LojistikBirimiGetirById(int ID)
        {
            return _lojistikBirimiRepository.GetById(ID);
        }

        public int LojistikBirimiUpdate(LojistikBirimi lojistik)
        {
            return _lojistikBirimiRepository.UpdateItem(lojistik);
        }

        public int LojistikBirimiSil(LojistikBirimi lojistik)
        {
            return _lojistikBirimiRepository.DeleteItem(lojistik);
        }
    }
}
