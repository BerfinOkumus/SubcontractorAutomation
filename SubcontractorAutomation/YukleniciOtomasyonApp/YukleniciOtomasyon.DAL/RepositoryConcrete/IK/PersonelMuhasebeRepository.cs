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
    public class PersonelMuhasebeRepository : IPersonelMuhasebeRepository
    {
        int _etkilenenSatir;

        public int AddItem(PersonelMuhasebe item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.PersonelMuhasebe.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(PersonelMuhasebe item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.PersonelMuhasebe.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public ICollection<PersonelMuhasebe> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.PersonelMuhasebe.ToList();
            }
        }
        public PersonelMuhasebe GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.PersonelMuhasebe.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public int UpdateItem(PersonelMuhasebe item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                PersonelMuhasebe eskiMaas = _db.PersonelMuhasebe.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiMaas.Maas = item.Maas;
                eskiMaas.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
    }
}
