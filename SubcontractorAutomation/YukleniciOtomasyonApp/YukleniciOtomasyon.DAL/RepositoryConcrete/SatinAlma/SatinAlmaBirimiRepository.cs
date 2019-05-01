using System.Collections.Generic;
using System.Linq;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.SatinAlma;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.SatinAlma
{
    public class SatinAlmaBirimiRepository : ISatinAlmaBirimiRepository
    {
        private int _etkilenenSatir;

        public int AddItem(SatinAlmaBirimi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.SatinAlmaBirimi.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(SatinAlmaBirimi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.SatinAlmaBirimi.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

       
        public ICollection<SatinAlmaBirimi> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.SatinAlmaBirimi.ToList();
            }
        }

        public SatinAlmaBirimi GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.SatinAlmaBirimi.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public int UpdateItem(SatinAlmaBirimi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                SatinAlmaBirimi eskiSatinAlmaBirimi = _db.SatinAlmaBirimi.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiSatinAlmaBirimi.BirimAdi = item.BirimAdi;
                eskiSatinAlmaBirimi.YapilanSatinAlmalar = item.YapilanSatinAlmalar;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public ICollection<SatinAlmaBirimiDTO> DTOSatinAlmaBirimiGetir()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return (from tedarikci in _db.T_TedarikciFirma
                        join malzeme in _db.T_MalzemeOzellikleri on tedarikci.SatinAlmalar.AlinanMalzemeler.FirstOrDefault().Id 
                        equals malzeme.Id
                        join satinalmalar in _db.SatinAlmalar on malzeme.Id equals satinalmalar.AlinanMalzemeler.FirstOrDefault().Id
                        join satinalmabirimi in _db.SatinAlmaBirimi on satinalmalar.SatinAlmaBirimiId  equals satinalmabirimi.Id
                        join departman in _db.Departman on satinalmabirimi.DepartmanId equals departman.Id
                        join personeltanimi in _db.PersonelTanimi on departman.PersonelTanimlari.FirstOrDefault().Id equals personeltanimi.Id
                        join personel in _db.Personel on personeltanimi.Personeller.FirstOrDefault().Id equals personel.Id
                        select new SatinAlmaBirimiDTO
                        {
                            BirimAdi=satinalmabirimi.BirimAdi,
                            PersonelId=personel.Id,
                            FirmaAd=tedarikci.Ad,
                            FirmaAdres=tedarikci.Adres,
                            FirmaEMail=tedarikci.EMail,
                            FirmaTelefon=tedarikci.Telefon,
                            CekVadesi=satinalmalar.CekVadesi,
                            OdemeTuru=satinalmalar.OdemeTuru,
                            TeslimTarihi=satinalmalar.TeslimTarihi,
                            SatinAlmaTarihi=satinalmalar.SatinAlmaTarihi,
                            MalzemeAdi = malzeme.MalzemeAdi,
                            Tur = malzeme.Tur,
                            Adet = malzeme.Adet,
                            AdetTip = malzeme.AdetTip,
                            En = malzeme.En,
                            Boy = malzeme.Boy,
                            Derinlik = malzeme.Derinlik,
                            Agırlik = malzeme.Agırlik,
                            BirimFiyat = malzeme.MalzemeFiyatlari.FirstOrDefault().BirimFiyat,
                            ToplamFiyat = malzeme.MalzemeFiyatlari.FirstOrDefault().BirimFiyat * malzeme.Adet
                        }).ToList();
            }
        }
    }
}
