﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryAbstract.TanimTablolari;
using YukleniciOtomasyon.DAL.YukleniciOtomasyonContext;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryConcrete.TanimTablolari
{
    public class T_NakliyeRepository : IT_NakliyeRepository
    {
        int _etkilenenSatir;

        public int AddItem(T_Nakliye item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.Nakliye.Add(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public int DeleteItem(T_Nakliye item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                _db.Nakliye.Remove(item);
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }

        public ICollection<T_Nakliye> GetAll()
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.Nakliye.ToList();
            }
        }

        public T_Nakliye GetById(int id)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.Nakliye.Where(x => x.Id == id).FirstOrDefault();
            }
        }

        T_Nakliye _eski;

        public int UpdateItem(T_Nakliye item)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                T_Nakliye eskiNakliye = _db.Nakliye.Where(x => x.Id == item.Id).FirstOrDefault();
                eskiNakliye.Ad = item.Ad;
                eskiNakliye.Telefon = item.Telefon;
                eskiNakliye.EMail = item.EMail;
                eskiNakliye.Adres = item.Adres;
                _etkilenenSatir = _db.SaveChanges();
                return _etkilenenSatir;
            }
        }
        public ICollection<T_Nakliye> NakliyeFirmaAra(string text)
        {
            using (YukleniciOtomasyonDbContext _db = new YukleniciOtomasyonDbContext())
            {
                return _db.Nakliye.Where(x => x.Ad.Contains(text)
                || x.Adres.Contains(text)
                || x.EMail.Contains(text)
                || x.Telefon.Contains(text)
                ).ToList();
            }
        }
    }
}
