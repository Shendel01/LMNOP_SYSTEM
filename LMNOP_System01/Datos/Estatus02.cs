using LMNOP_System01.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Datos
{
    public class Estatus02
    {
        public void Guardar(Maquila_CentroServicio modelo)
        {
           using(LMNOP_SystemEntities contexto = new LMNOP_SystemEntities())
            {
                contexto.Maquila_CentroServicio.Add(modelo);
            }
        }
    }
}