﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.Depo;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari
{
    public class T_DepoOzellikleriRepository : IT_DepoOzellikleriRepository
    {
        int _etkilenenSatir;

        public int AddItem(T_DepoOzellikleri item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.T_DepoOzellikleri.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(T_DepoOzellikleri item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {

                _db.T_DepoOzellikleri.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<T_DepoOzellikleri> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.T_DepoOzellikleri.ToList();
            }
        }

        public T_DepoOzellikleri GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.T_DepoOzellikleri.Where(x => x.Id == id).FirstOrDefault();
            }
        }
        public int UpdateItem(T_DepoOzellikleri item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                T_DepoOzellikleri eskiDepoOzellikleri = _db.T_DepoOzellikleri.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiDepoOzellikleri.Ad = item.Ad;
                eskiDepoOzellikleri.Boyutu = item.Boyutu;
                eskiDepoOzellikleri.Adres = item.Adres;
                eskiDepoOzellikleri.Depolar.DepoAdi = item.Depolar.DepoAdi;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
    }
}
