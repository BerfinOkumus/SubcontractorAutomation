using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract.Teklif;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Teklif
{
    public class AcilanIhalelerRepository : IAcilanIhalelerRepository
    {
        int _etkilenenSatir;

        public int AddItem(AcilanIhaleler item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.AcilanIhaleler.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(AcilanIhaleler item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.AcilanIhaleler.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<AcilanIhaleler> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.AcilanIhaleler.ToList();
            }
        }

        public AcilanIhaleler GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.AcilanIhaleler.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public int UpdateItem(AcilanIhaleler item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                AcilanIhaleler eskiIhaleler = _db.AcilanIhaleler.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiIhaleler.KurumFirmaAdi = item.KurumFirmaAdi;
                eskiIhaleler.IsinAdi = item.IsinAdi;
                eskiIhaleler.IsTanimi = item.IsTanimi;
                eskiIhaleler.IhaleTarihSaat = item.IhaleTarihSaat;
                eskiIhaleler.IhaleOturumAdresi = item.IhaleOturumAdresi;
                eskiIhaleler.IsBaslangicTarihi = item.IsBaslangicTarihi;
                eskiIhaleler.IsBitisTarihi = item.IsBitisTarihi;
                eskiIhaleler.TeklifBirimi = item.TeklifBirimi;
                eskiIhaleler.IdariSartname = item.IdariSartname;
                eskiIhaleler.SozlesmeTaslagi = item.SozlesmeTaslagi;
                eskiIhaleler.IhaleyiAlanFirmaAdi = item.IhaleyiAlanFirmaAdi;
                eskiIhaleler.AlanFirmaninTeklifi = item.AlanFirmaninTeklifi;
                eskiIhaleler.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public ICollection<AcilanIhaleler> IhaleAra(string text)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.AcilanIhaleler.Where(x => x.KurumFirmaAdi.Contains(text)
               || x.IsinAdi.Contains(text)
               || x.IsTanimi.Contains(text)
               || x.IhaleOturumAdresi.Contains(text)
               || x.IdariSartname.Contains(text)
               || x.SozlesmeTaslagi.Contains(text)
               || x.IhaleyiAlanFirmaAdi.Contains(text)
               || x.IhaleTarihSaat.ToString().Contains(text)
               || x.AlanFirmaninTeklifi.ToString().Contains(text)
               || x.IsBaslangicTarihi.ToString().Contains(text)
               || x.IsBitisTarihi.ToString().Contains(text)
               ).ToList();
            }
        }

        public ICollection<AcilanIhaleler> IhaleTarihiAra(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.AcilanIhaleler.Where(x => x.IsBaslangicTarihi >= baslangicTarihi || x.IsBitisTarihi <= bitisTarihi
                ).ToList();
            }
        }
    }
}
