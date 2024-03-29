﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YukleniciOtomasyon.Entities.Model.TanimTablolari;

namespace YukleniciOtomasyon.DAL.RepositoryAbstract.TanimTablolari
{
    interface IT_TedarikciFirmaRepository : IBaseRepository<T_TedarikciFirma>
    {
        ICollection<T_TedarikciFirma> TedarikciFirmaAra(string text);
    }
}
