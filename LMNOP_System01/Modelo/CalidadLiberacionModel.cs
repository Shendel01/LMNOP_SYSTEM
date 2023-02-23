using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Modelo
{
    public class CalidadLiberacionModel
    {
        public int Id { get; set; }
        public int Estatus { get; set; }
        public int Nombre_libera { get; set; }
        public String Fecha { get; set; }
        public String Hora { get; set; }

    }
}