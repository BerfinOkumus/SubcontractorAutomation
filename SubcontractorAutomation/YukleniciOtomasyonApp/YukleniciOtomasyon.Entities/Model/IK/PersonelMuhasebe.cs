using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YukleniciOtomasyon.Entities.Model.IK
{
    public class PersonelMuhasebe : BaseEntity
    {
        public decimal Maas { get; set; }

        public int PersonelTanimiId { get; set; }

        //Navigation Properties
        public virtual PersonelTanimi PersonelTanimi { get; set; }
    }
}
