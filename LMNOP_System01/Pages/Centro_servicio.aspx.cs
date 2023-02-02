﻿using LMNOP_System01.Conexion;
using LMNOP_System01.Context;
using LMNOP_System01.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class Centro_servicio : System.Web.UI.Page
    {
        //CentroServicio centro = new CentroServicio();

        private void Consultar()
        {

            //grilla.DataSource = centro.Consultar();
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities()) {

                var res = entities.Centro_servicio.ToList();

                List<CentroServicioModel> list = new List<CentroServicioModel>();

                foreach(var item in res)
                {
                    list.Add(new CentroServicioModel
                    {
                        Num_OF = item.Num_OF,
                        Codigo_primera = item.Codigo_primera,
                        Descripcion = item.Descripcion,
                        Num_piezas = Convert.ToInt32(item.Num_piezas),
                        Kg = Convert.ToDouble(item.Kg),
                        Num_tarimas = Convert.ToInt32(item.Num_tarimas),
                        Operadores = item.Operadores,
                        Turno = item.Turno,
                        Pedaceria = item.Pedaceria,
                        Faltante = item.Faltante,
                        Sobrante = item.Sobrante,
                        Rechazo = item.Rechazo,
                        Observaciones = item.Observaciones,
                        Total = Convert.ToDouble(item.Total)
                    });
                }

                grilla.DataSource = list;
                grilla.DataBind();
            }
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Consultar();
        }

        protected void Enviar_Click(object sender, EventArgs e)
        {
            //CentroServicioModel model = new CentroServicioModel()
            //{
            //   Num_OF = int.Parse(num_of.Text),
            //   Codigo_primera = codigo_primera.Text,
            //   Descripcion = descripcion.Text,
            //   Num_piezas = int.Parse(num_piezas.Text),
            //   Kg = double.Parse(kg.Text),
            //   Num_tarimas = int.Parse(num_tarimas.Text),
            //   Operadores = operadores.Text,
            //   Turno = turno.Text,
            //   Pedaceria = pedaceria.Text,
            //   Faltante = faltante.Text,
            //   Sobrante = sobrante.Text,
            //   Rechazo = rechazo.Text,
            //   Total = double.Parse(total.Text)

            //};
            //centro.Guardar(model);
            using (LMNOP_SystemEntities entities = new LMNOP_SystemEntities())
            {
                entities.Centro_servicio.Add(new LMNOP_System01.Context.Centro_servicio //En donde dice ADD puedes agregar los métodos como PUT 
                {
                    Num_OF = int.Parse(num_of.Text),
                    Codigo_primera = codigo_primera.Text,
                    Descripcion = descripcion.Text,
                    Num_piezas = int.Parse(num_piezas.Text),
                    Kg = Convert.ToDecimal(kg.Text),
                    Num_tarimas = int.Parse(num_tarimas.Text),
                    Operadores = operadores.Text,
                    Turno = turno.Text,
                    Pedaceria = pedaceria.Text,
                    Faltante = faltante.Text,
                    Sobrante = sobrante.Text,
                    Rechazo = rechazo.Text,
                    Observaciones = observaciones.Text,
                    Total = Convert.ToDecimal(total.Text)
                });
                entities.SaveChanges();
            };
            Consultar();

        }
    }
}