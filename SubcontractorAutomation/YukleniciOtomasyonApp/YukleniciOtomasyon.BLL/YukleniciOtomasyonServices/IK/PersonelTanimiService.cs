using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.DAL.RepositoryConcrete.IK;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.IK
{
    public class PersonelTanimiService
    {
        PersonelTanimiRepository _personelTanimiRepository;
        public PersonelTanimiService()
        {
            _personelTanimiRepository = new PersonelTanimiRepository();
        }

        public int AddPersonelTanimiService(PersonelTanimi eklenecekPersonelTanimi)
        {
            try
            {
                return _personelTanimiRepository.AddItem(eklenecekPersonelTanimi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata : " + e.Message);
                throw;
            }
        }

        public int DeletePersonelTanimiService(PersonelTanimi silinecekPersonelTanimi)
        {
            try
            {
                return _personelTanimiRepository.DeleteItem(silinecekPersonelTanimi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata : " + e.Message);
                throw;
            }
        }

        public List<PersonelTanimi> TumPersonelTanimlariniGetirService()
        {
            try
            {
                return _personelTanimiRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }

        public PersonelTanimi BirPersonelTanimiGetirService(int id)
        {
            try
            {
                return _personelTanimiRepository.GetById(id);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " + e.Message);
                throw;
            }            
        }
        public int UpdatePersonelTanimiService(PersonelTanimi guncellenecekPersonelTanimi)
        {
            try
            {
                return _personelTanimiRepository.UpdateItem(guncellenecekPersonelTanimi);
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show("Hata: " +e.Message);
                throw;
            }
        }












    }
}
