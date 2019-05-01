using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.DTO;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari
{
    public class DepartmanRepository : IT_DepartmanRepository
    {
        int _etkilenenSatir;

        public int AddItem(Departman item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.Departman.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(Departman item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.Departman.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public Departman GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.Departman.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        
        public int UpdateItem(Departman item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                Departman departman = _db.Departman.Where(x => x.Id == item.Id).FirstOrDefault();
                departman.DepartmanAdi = item.DepartmanAdi;
                departman.DuzenlenmeTarihi = DateTime.Now;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<Departman> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.Departman.ToList();
            }
        }

        public ICollection<Departman> DepartmanAra(string text)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.Departman.Where(x => x.DepartmanAdi.Contains(text)
                || x.DepoBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                || x.LojistikBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                || x.SantiyeBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                || x.SantiyeBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                || x.SatinAlmaBirimleri.FirstOrDefault().BirimAdi.Contains(text)
                ).ToList();
            }
        }

        public ICollection<DepartmanPersonelTanimiDTO> DTODepartmanPersonelTanimiGetir(string text)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                string brmadi="";
                var depoadi = from personeltanim in _db.PersonelTanimi
                                 join departman in _db.Departman on personeltanim.Id equals departman.PersonelTanimlari.FirstOrDefault().Id
                                 join depobirimi in _db.DepoBirimi on departman.Id equals depobirimi.DepartmanId
                                 join depolar in _db.Depolar on depobirimi.Id equals depolar.DepoBirimiId
                                 select depolar.DepoAdi;

                if (depoadi.ToString() != null)
                {
                    brmadi = depoadi.ToString();
                }

                var loj = from personeltanim in _db.PersonelTanimi
                              join departman in _db.Departman on personeltanim.Id equals departman.PersonelTanimlari.FirstOrDefault().Id
                              join lojistikbirimi in _db.LojistikBirimi on departman.Id equals lojistikbirimi.DepartmanId
                              select lojistikbirimi.BirimAdi;

                if (depoadi.ToString() != null)
                {
                    brmadi = loj.ToString();
                }

                var san = from personeltanim in _db.PersonelTanimi
                          join departman in _db.Departman on personeltanim.Id equals departman.PersonelTanimlari.FirstOrDefault().Id
                          join santiyebirimi in _db.SantiyeBirimi on departman.Id equals santiyebirimi.DepartmanId
                          join santiyeler in _db.Santiyeler on santiyebirimi.Id equals santiyeler.SantiyeBirimiId
                          join santiyeozellikleri in _db.T_SantiyeOzellikleri on santiyeler.Id equals santiyeozellikleri.SantiyeleriId
                          select santiyeozellikleri.Ad;

                if (depoadi.ToString() != null)
                {
                    brmadi = san.ToString();
                }
                var sat = from personeltanim in _db.PersonelTanimi
                          join departman in _db.Departman on personeltanim.Id equals departman.PersonelTanimlari.FirstOrDefault().Id
                          join santinalmabirimi in _db.SatinAlmaBirimi on departman.Id equals santinalmabirimi.DepartmanId
                          select santinalmabirimi.BirimAdi;

                if (depoadi.ToString() != null)
                {
                    brmadi = sat.ToString();
                }
                var tek = from personeltanim in _db.PersonelTanimi
                          join departman in _db.Departman on personeltanim.Id equals departman.PersonelTanimlari.FirstOrDefault().Id
                          join teklifbirimi in _db.TeklifBirimi on departman.Id equals teklifbirimi.DepartmanId
                          select teklifbirimi.BirimAdi;

                if (depoadi.ToString() != null)
                {
                    brmadi = tek.ToString();
                }


                return (from departman in _db.Departman
                        join personelTanimi in _db.PersonelTanimi on departman.Id equals personelTanimi.Departmanlar.FirstOrDefault().Id
                        select new DepartmanPersonelTanimiDTO
                        {
                            DepartmanAdi=departman.DepartmanAdi,
                            CalistigiYer = brmadi,
                            UnvanAdi = personelTanimi.PersonelUnvanlar.FirstOrDefault().UnvanAdi,
                            Ad = personelTanimi.Personeller.FirstOrDefault().Ad,
                            Soyad = personelTanimi.Personeller.FirstOrDefault().Soyad,
                            KimlikNo = personelTanimi.Personeller.FirstOrDefault().KimlikNo,
                            DogumTarihi= personelTanimi.Personeller.FirstOrDefault().DogumTarihi,
                            Cinsiyet= personelTanimi.Personeller.FirstOrDefault().Cinsiyet,
                            MedeniHal= personelTanimi.Personeller.FirstOrDefault().MedeniHal,
                            EgitimDurumu= personelTanimi.Personeller.FirstOrDefault().EgitimDurumu,
                            BaslangicTarihi= personelTanimi.Personeller.FirstOrDefault().BaslangicTarihi,
                            Telefon= personelTanimi.Personelletisimleri.FirstOrDefault().Telefon,
                            EMail = personelTanimi.Personelletisimleri.FirstOrDefault().EMail,
                            Sifre = personelTanimi.Personelletisimleri.FirstOrDefault().Sifre,
                            Adres = personelTanimi.Personelletisimleri.FirstOrDefault().Adres,
                            DahiliTel = personelTanimi.Personelletisimleri.FirstOrDefault().DahiliTel,
                            PostaKodu = personelTanimi.Personelletisimleri.FirstOrDefault().PostaKodu,
                            ResimUrl = personelTanimi.Personelletisimleri.FirstOrDefault().ResimUrl,
                            Maas = personelTanimi.PersonelMuhasebeleri.FirstOrDefault().Maas
                        }).ToList();
            }
        }
    }
}
