﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.IK;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.IK
{
    public class PersonelService
    {
        PersonelRepository _personelRepository;
        public PersonelService()
        {
            _personelRepository = new PersonelRepository();
        }



        public int AddPersonelService (Personel yeniPersonel)
        {
            try
            {
                return _personelRepository.AddItem(yeniPersonel);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;               
            }
        }
         
        public int DeletePersonelService(Personel silinecekPersonel)
        {
            try
            {
                return _personelRepository.DeleteItem(silinecekPersonel);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public List<Personel> TumPersonelleriGetirService()
        {
            try
            {
                return _personelRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }
        
        public Personel BirPersonelGetirService(int id)
        {
            try
            {
                return _personelRepository.GetById(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                throw;
            }            
        }

        public int UpdatePersonelService(Personel guncellenecekPersonel)
        {
            try
            {
                return _personelRepository.UpdateItem(guncellenecekPersonel);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

    }
}
