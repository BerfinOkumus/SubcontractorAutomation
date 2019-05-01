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
    public class PersonelTanimiRepository : IPersonelTanimiRepository
    {
        int _etkilenenSatir;

        public int AddItem(PersonelTanimi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.PersonelTanimi.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(PersonelTanimi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.PersonelTanimi.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<PersonelTanimi> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.PersonelTanimi.ToList();
            }
        }

        public PersonelTanimi GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.PersonelTanimi.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        public int UpdateItem(PersonelTanimi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                PersonelTanimi eskiPersonelTanimi = _db.PersonelTanimi.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiPersonelTanimi.Departmanlar = item.Departmanlar;
                eskiPersonelTanimi.Personeller = item.Personeller;
                eskiPersonelTanimi.PersonelUnvanlar = item.PersonelUnvanlar;
                eskiPersonelTanimi.Personelletisimleri = item.Personelletisimleri;
                eskiPersonelTanimi.PersonelMuhasebeleri = item.PersonelMuhasebeleri;
                eskiPersonelTanimi.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
    }
}
