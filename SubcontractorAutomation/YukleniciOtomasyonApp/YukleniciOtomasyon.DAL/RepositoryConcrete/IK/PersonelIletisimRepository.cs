using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.IK
{
    public class PersonelIletisimRepository : IPersonelletisimRepository
    {
        int _etkilenenSatir;

        public int AddItem(PersonelIletisim item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.PersonelIletisim.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public int DeleteItem(PersonelIletisim item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.PersonelIletisim.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public ICollection<PersonelIletisim> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.PersonelIletisim.ToList();
            }
        }
        public PersonelIletisim GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.PersonelIletisim.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public int UpdateItem(PersonelIletisim item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                PersonelIletisim eskiIletisim = _db.PersonelIletisim.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiIletisim.Telefon = item.Telefon;
                eskiIletisim.EMail = item.EMail;
                eskiIletisim.Sifre = item.Sifre;
                eskiIletisim.Adres = item.Adres;
                eskiIletisim.DahiliTel = item.DahiliTel;
                eskiIletisim.PostaKodu = item.PostaKodu;
                eskiIletisim.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
    }
}
