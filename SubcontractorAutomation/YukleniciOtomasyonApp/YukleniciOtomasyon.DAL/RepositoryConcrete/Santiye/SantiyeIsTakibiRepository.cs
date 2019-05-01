using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Santiye;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Santiye
{
    public class SantiyeIsTakibiRepository : ISantiyeIsTakibiRepository
    {
        int _etkilenenSatir;

        public int AddItem(SantiyeIsTakibi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.SantiyeIsTakibi.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public int DeleteItem(SantiyeIsTakibi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.SantiyeIsTakibi.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public ICollection<SantiyeIsTakibi> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.SantiyeIsTakibi.ToList();
            }
        }
        public SantiyeIsTakibi GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.SantiyeIsTakibi.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public int UpdateItem(SantiyeIsTakibi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                SantiyeIsTakibi eskiIsTakibi = _db.SantiyeIsTakibi.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiIsTakibi.YapilanIsinAdi = item.YapilanIsinAdi;
                eskiIsTakibi.IsBaslangicTarihi = item.IsBaslangicTarihi;
                eskiIsTakibi.IsBitisTarihi = item.IsBitisTarihi;
                eskiIsTakibi.IsinSuresi = item.IsinSuresi;
                eskiIsTakibi.KullanilanMalzemeler = item.KullanilanMalzemeler;
                eskiIsTakibi.Santiyeler = item.Santiyeler;
                eskiIsTakibi.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public ICollection<SantiyeIsTakibi> IsTakibiAra(string text)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.SantiyeIsTakibi.Where(x => x.YapilanIsinAdi.Contains(text)).ToList();
            }
        }

        public ICollection<SantiyeIsTakibi> IsTakibiTarihAra(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.SantiyeIsTakibi.Where(x => x.IsBaslangicTarihi >= baslangicTarihi || x.IsBitisTarihi <= bitisTarihi
                ).ToList();
            }
        }

       
    }
}
