using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract.Teklif;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.Teklif
{
    public class TeklifBirimiRepository : ITeklifBirimiRepository
    {
        int _etkilenenSatir;

        public int AddItem(TeklifBirimi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.TeklifBirimi.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(TeklifBirimi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.TeklifBirimi.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<TeklifBirimi> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.TeklifBirimi.ToList();
            }
        }

        public TeklifBirimi GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.TeklifBirimi.Where(x => x.Id == id).FirstOrDefault();
            }
        }


        TeklifBirimi _eski;

        public int UpdateItem(TeklifBirimi item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                TeklifBirimi eskiTeklifBirimi = _db.TeklifBirimi.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiTeklifBirimi.BirimAdi = item.BirimAdi;
                eskiTeklifBirimi.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<TeklifBirimiDTO> DTOTeklifBirimiGetir()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return (from teklifbirimi in _db.TeklifBirimi
                        join ihaleler in _db.AcilanIhaleler on teklifbirimi.KatilimSaglananIhaleler.FirstOrDefault().Id equals ihaleler.Id
                        join evraklar in _db.IhaleEvraklari on ihaleler.HazirlananEvraklar.FirstOrDefault().Id equals evraklar.Id
                        join departman in _db.Departman on teklifbirimi.DepartmanId equals departman.Id
                        join personeltanimi in _db.PersonelTanimi on departman.PersonelTanimlari.FirstOrDefault().Id equals personeltanimi.Id
                        join personel in _db.Personel on personeltanimi.Personeller.FirstOrDefault().Id equals personel.Id
                        select new TeklifBirimiDTO
                        {
                            BirimAdi=teklifbirimi.BirimAdi,
                            KurumFirmaAdi=ihaleler.KurumFirmaAdi,
                            IsinAdi=ihaleler.IsinAdi,
                            IsTanimi=ihaleler.IsTanimi,
                            IhaleTarihSaat=ihaleler.IhaleTarihSaat,
                            IhaleOturumAdresi=ihaleler.IhaleOturumAdresi,
                            IsBaslangicTarihi=ihaleler.IsBaslangicTarihi,
                            IsBitisTarihi=ihaleler.IsBitisTarihi,
                            TeknikSartname=ihaleler.TeknikSartname,
                            IdariSartname=ihaleler.IdariSartname,
                            SozlesmeTaslagi=ihaleler.SozlesmeTaslagi,
                            IhaleyiAlanFirmaAdi=ihaleler.IhaleyiAlanFirmaAdi,
                            AlanFirmaninTeklifi=ihaleler.AlanFirmaninTeklifi,
                            TicaretOdasiKayitBelgesi=evraklar.TicaretOdasiKayitBelgesi,
                            ImzaSirkuleri=evraklar.ImzaSirkuleri,
                            TeklifMektubu=evraklar.TeklifMektubu,
                            GeciciTeminatMektubu=evraklar.GeciciTeminatMektubu,
                            IsBitirmeBelgesi=evraklar.IsBitirmeBelgesi,
                            Vekaletname=evraklar.Vekaletname,
                            OrtaklikBeyannamesi=evraklar.OrtaklikBeyannamesi,
                            BankaReferansMektubu=evraklar.BankaReferansMektubu,
                            MeslekiYeterlilik=evraklar.MeslekiYeterlilik
                        }).ToList();
            }
        }
    }
}
