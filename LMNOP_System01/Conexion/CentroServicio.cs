using LMNOP_System01.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Conexion
{
    public class CentroServicio:Conexion
    {
        public void Guardar(CentroServicioModel modelo)
        {
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("Guardar", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                //PARÁMETROS
                comando.Parameters.Add(new SqlParameter("@Num_OF", modelo.Num_OF));
                comando.Parameters.Add(new SqlParameter("@Codigo_primera", modelo.Codigo_primera));
                comando.Parameters.Add(new SqlParameter("@Descripcion,", modelo.Descripcion));
                comando.Parameters.Add(new SqlParameter("@Kg,", modelo.Kg));
                comando.Parameters.Add(new SqlParameter("@Num_tarimas", modelo.Num_OF));
                comando.Parameters.Add(new SqlParameter("@Operadores", modelo.Operadores));
                comando.Parameters.Add(new SqlParameter("@Turno", modelo.Turno));
                comando.Parameters.Add(new SqlParameter("@Pedaceria", modelo.Pedaceria));
                comando.Parameters.Add(new SqlParameter("@Faltante", modelo.Faltante));
                comando.Parameters.Add(new SqlParameter("@Sobrante", modelo.Sobrante));
                comando.Parameters.Add(new SqlParameter("@Rechazo", modelo.Rechazo));
                comando.Parameters.Add(new SqlParameter("@Observaciones", modelo.Observaciones));
                comando.Parameters.Add(new SqlParameter("@Total", modelo.Total));
                

                //TERMINA PARÁMETROS
                comando.ExecuteNonQuery();
                comando.Dispose();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);

            }
            finally
            {
                Desconectar();
            }
        }

        public List<CentroServicioModel> Consultar()
        {
            List<CentroServicioModel> list = new List<CentroServicioModel>();
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("Guardar", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    CentroServicioModel modelo = new CentroServicioModel()
                    {
                        Num_OF = int.Parse(lector[0]+""),
                        Codigo_primera = lector[1]+"",
                        Descripcion = lector[2]+"",
                        Kg = double.Parse(lector[3]+""),
                        Num_tarimas = int.Parse(lector[4]+""),
                        Operadores = lector[5]+"",
                        Turno = lector[6] + "",
                        Pedaceria = lector[7] + "",
                        Faltante = lector[8] + "",
                        Sobrante = lector[9] + "",
                        Rechazo = lector[10] + "",
                        Observaciones = lector[11] + "",
                        Total = int.Parse(lector[12] + "")

                    };
                    list.Add(modelo);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Desconectar();
            }
            return list;
        }
    }
}