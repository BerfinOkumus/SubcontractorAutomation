using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.Depo;
using YukleniciOtomasyon.Entities.Model.Lojistik;
using YukleniciOtomasyon.Entities.Model.Santiye;
using YukleniciOtomasyon.Entities.Model.SatinAlma;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;
using YukleniciOtomasyon.Entities.Model.Teklif;

namespace YukleniciOtomasyon.Entities.Model.IK
{
    public class PersonelTanimi : BaseEntity
    {
        public PersonelTanimi()  
        {
            Departmanlar = new List<Departman>();
            PersonelUnvanlar= new List<T_PersonelUnvan>();
            Personeller= new List<Personel>();
            Personelletisimleri= new List<PersonelIletisim>();
            PersonelMuhasebeleri = new List<PersonelMuhasebe>();
        }

       /* public int? DepoBirimiId { get; set; }
        public int? LojistikBirimiId { get; set; }
        public int? SantiyeBirimiId { get; set; }
        public int? SatinAlmaBirimiId { get; set; }
        public int? TeklifBirimiId { get; set; }
        public int? InsanKaynaklariBirimiId { get; set; }

    */
        //Navigation Properties
        public virtual ICollection<Departman> Departmanlar { get; set; }
        public virtual ICollection<T_PersonelUnvan> PersonelUnvanlar { get; set; }
        public virtual ICollection<Personel> Personeller { get; set; }
        public virtual ICollection<PersonelIletisim> Personelletisimleri { get; set; }
        public virtual ICollection<PersonelMuhasebe> PersonelMuhasebeleri { get; set; }

        /*public virtual DepoBirimi DepoBirimi { get; set; }
        public virtual LojistikBirimi LojistikBirimi { get; set; }
        public virtual Santiyeler SantiyeBirimi { get; set; }
        public virtual SatinAlmaBirimi SatinAlmaBirimi { get; set; }
        public virtual TeklifBirimi TeklifBirimi { get; set; }
        public virtual InsanKaynaklariBirimi InsanKaynaklariBirimi { get; set; }
        */
    }
}
