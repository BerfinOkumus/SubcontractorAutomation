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
    public class T_PersonelUnvanRepository : IT_PersonelUnvanRepository
    {
        int _etkilenenSatir;

        public int AddItem(T_PersonelUnvan item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.PersonelUnvan.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(T_PersonelUnvan item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.PersonelUnvan.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<T_PersonelUnvan> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.PersonelUnvan.ToList();
            }
        }

        public T_PersonelUnvan GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.PersonelUnvan.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        T_PersonelUnvan _eski;

        public int UpdateItem(T_PersonelUnvan item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                T_PersonelUnvan eskiUnvan = _db.PersonelUnvan.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiUnvan.UnvanAdi = item.UnvanAdi;
                eskiUnvan.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
    }
}
