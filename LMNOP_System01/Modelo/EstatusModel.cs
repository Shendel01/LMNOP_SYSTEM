
using LMNOP_System01.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LMNOP_System01.Modelo
{
    public class EstatusModel
    {
        public Maquila_CentroServicio maquila_cs { get; set; }
        public IEnumerable<SelectListItem> ListadoEstatus { get; set; }
    }
}