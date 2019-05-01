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
    public class PersonelRepository : IPersonelRepository
    {
        int _etkilenenSatir;

        public int AddItem(Personel item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.Personel.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(Personel item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.Personel.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public ICollection<Personel> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.Personel.ToList();
            }
        }
        public Personel GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.Personel.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public int UpdateItem(Personel item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                Personel eskiPersonel = _db.Personel.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiPersonel.Ad = item.Ad;
                eskiPersonel.Soyad = item.Soyad;
                eskiPersonel.DogumTarihi = item.DogumTarihi;
                eskiPersonel.MedeniHal = item.MedeniHal;
                eskiPersonel.EgitimDurumu = item.EgitimDurumu;
                eskiPersonel.CikisTarihi = item.CikisTarihi;
                eskiPersonel.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public bool PersonelLoginKontrol(string kimlikNo, string sifre)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                //PersonelTanimi personelTanimi= _db.PersonelTanimi.Where(x => x.Personeller.Select(y => y.KimlikNo).ToString() == kimlikNo)
                   // .Where(k => k.Personelletisimleri.Select(y => y.Sifre).ToString() == sifre);

                PersonelTanimi personelTanimi = _db.PersonelTanimi
                    .Where(x => x.Personeller.FirstOrDefault().KimlikNo == kimlikNo && x.Personelletisimleri.FirstOrDefault().Sifre == sifre)
                    .FirstOrDefault();

                if (personelTanimi != null)
                {
                    return true;
                }
                return false;
            }
        }
        public ICollection<Personel> PersonelAra(string text)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.Personel.Where(x => x.Ad.Contains(text)
                || x.Soyad.Contains(text) || x.KimlikNo.Contains(text) || x.DogumTarihi.ToString().Contains(text)
                ).ToList();
               
            }
        }
    }
}
