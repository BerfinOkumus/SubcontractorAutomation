using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract.TanimTablolari;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari
{
    public class T_NakliyeAraclariRepository : IT_NakliyeAraclariRepository
    {
        int _etkilenenSatir;

        public int AddItem(T_NakliyeAraclari item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.NakliyeAraclari.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(T_NakliyeAraclari item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.NakliyeAraclari.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<T_NakliyeAraclari> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.NakliyeAraclari.ToList();
            }
        }

        public T_NakliyeAraclari GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.NakliyeAraclari.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public int UpdateItem(T_NakliyeAraclari item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                T_NakliyeAraclari eskiNakliyeAraclari = _db.NakliyeAraclari.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiNakliyeAraclari.TasitTipi = item.TasitTipi;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
    }
}
