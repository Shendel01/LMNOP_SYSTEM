using LMNOP_System01.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Datos
{
    public class Estatus01
    {
        public List<Estatus_CentroServicio> Consultar()
        {
            using(LMNOP_SystemEntities contexto = new LMNOP_SystemEntities())
            {
                return contexto.Estatus_CentroServicio.AsNoTracking().ToList();
            }
        }
    }
}