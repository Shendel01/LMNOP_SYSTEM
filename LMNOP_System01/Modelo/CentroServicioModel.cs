using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Modelo
{
    public class CentroServicioModel
    {
        public int Num_OF { get;  set; }
        public string Codigo_primera { get; set; }
        public string Descripcion { get; set; }
        //public int Num_piezas { get; set; }
        //public double Kg { get; set; }
        //public int Num_tarimas { get; set; }
        public string Operadores { get; set; }
        public string Turno { get; set; }
        public string Pedaceria { get; set; }
        public string Faltante { get; set; }
        public string Sobrante { get; set; }
        public string Rechazo { get; set; }
        public string Observaciones { get; set; }
        public double Total { get; set; }

    }
}