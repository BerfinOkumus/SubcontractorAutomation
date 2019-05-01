using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YukleniciOtomasyon.DAL.RepositoryConcrete.IK;
using YukleniciOtomasyon.Entities.Model.IK;

namespace YukleniciOtomasyon.BLL.YukleniciOtomasyonServices.IK
{
    public class PersonelletisimService
    {
        PersonelIletisimRepository _personelIletisimRepository;
        public PersonelletisimService()
        {
            _personelIletisimRepository = new PersonelIletisimRepository();
        }

        public int AddPersonelIletisimService(PersonelIletisim personelIletisim)
        {
            try
            {
                return _personelIletisimRepository.AddItem(personelIletisim);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata : " + e.Message);
                throw;
            }
        }

        public int DeletePersonelIletisimService(PersonelIletisim personelIletisim)
        {
            try
            {
                return _personelIletisimRepository.DeleteItem(personelIletisim);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public List<PersonelIletisim> TumPersonelIletisimleriGetir()
        {
            try
            {
                return _personelIletisimRepository.GetAll().ToList();
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                throw;
            }
        }

        public PersonelIletisim PersonelIletisimGetir(int id)
        {
            try
            {
                return _personelIletisimRepository.GetById(id);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: "+e.Message);
                throw;
            }
           
        }

        public int UpdatePersonelletisimService(PersonelIletisim personelIletisim)
        {
            try
            {
                return _personelIletisimRepository.UpdateItem(personelIletisim);
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata: " + e.Message);
                throw;
            }
        }



    }
}
