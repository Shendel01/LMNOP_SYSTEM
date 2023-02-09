using LMNOP_System01.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace LMNOP_System01.Conexion
{
    public class AtencionSucursales:Conexion
    {
       public void GuardarAS(AtencionSucursalesModel modelo)
        {
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("GuardarAS", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                //Parámetros
                comando.Parameters.Add(new SqlParameter("@Id_AtencionSucursales", modelo.Id_AtencionSucursales));
                comando.Parameters.Add(new SqlParameter("@Num_maquila", modelo.Num_maquila));
                comando.Parameters.Add(new SqlParameter("@Documento", modelo.Documento));
                comando.Parameters.Add(new SqlParameter("@Division", modelo.Division));
                comando.Parameters.Add(new SqlParameter("@Fecha", modelo.Fecha));
                comando.Parameters.Add(new SqlParameter("@Hora", modelo.Hora));
                //Fin parámetros
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
        public List<AtencionSucursalesModel> ConsultarAS()
        {
            List<AtencionSucursalesModel> list = new List<AtencionSucursalesModel>();
            Conectar();
            try
            {
                SqlCommand comando = new SqlCommand("GuardarAS", cnn);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    AtencionSucursalesModel modelo = new AtencionSucursalesModel()
                    {
                        Id_AtencionSucursales = int.Parse(lector[0] + ""),
                        Num_maquila = int.Parse(lector[1] + ""),
                        Documento = lector[2] + "",
                        Division = int.Parse(lector[3] + ""),
                        Fecha = lector[4]+"",
                        Hora = lector[5] + ""

                    };
                    list.Add(modelo);
                    //list.Add(modelo);
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