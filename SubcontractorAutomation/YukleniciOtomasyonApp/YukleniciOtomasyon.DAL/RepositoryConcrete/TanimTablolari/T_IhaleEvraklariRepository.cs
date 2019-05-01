using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari
{
    public class T_IhaleEvraklariRepository : IT_IhaleEvraklariRepository
    {
        int _etkilenenSatir;

        public int AddItem(T_IhaleEvraklari item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.IhaleEvraklari.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(T_IhaleEvraklari item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.IhaleEvraklari.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<T_IhaleEvraklari> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.IhaleEvraklari.ToList();
            }
        }

        public T_IhaleEvraklari GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.IhaleEvraklari.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        T_IhaleEvraklari _eski;

        public int UpdateItem(T_IhaleEvraklari item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                T_IhaleEvraklari eskiIhaleEvraklari = _db.IhaleEvraklari.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiIhaleEvraklari.TicaretOdasiKayitBelgesi = item.TicaretOdasiKayitBelgesi;
                eskiIhaleEvraklari.ImzaSirkuleri = item.ImzaSirkuleri;
                eskiIhaleEvraklari.TeklifMektubu = item.TeklifMektubu;
                eskiIhaleEvraklari.GeciciTeminatMektubu = item.GeciciTeminatMektubu;
                eskiIhaleEvraklari.IsBitirmeBelgesi = item.IsBitirmeBelgesi;
                eskiIhaleEvraklari.Vekaletname = item.Vekaletname;
                eskiIhaleEvraklari.OrtaklikBeyannamesi = item.OrtaklikBeyannamesi;
                eskiIhaleEvraklari.BankaReferansMektubu = item.BankaReferansMektubu;
                eskiIhaleEvraklari.MeslekiYeterlilik = item.MeslekiYeterlilik;
                eskiIhaleEvraklari.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
                            
        }
    }
}
