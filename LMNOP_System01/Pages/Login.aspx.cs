using LMNOP_System01.Context;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LMNOP_System01.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;

            Response.AppendHeader("Cache-Control", "no-store");
        }

        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["LMNOP_SystemEntities"].ToString());

        const string CLAVE = "LMNOP";

        protected void ingresar_Click(object sender, EventArgs e)
        {

            try
            {
                List<sp_login_Result> result = null;
                using (var context = new LMNOP_SystemEntities()/*LMNOP_SystemEntities2()*/)
                {
                    result = context.sp_login(usuario.Text, CLAVE, clave.Text).ToList();


                    if (result != null && result.Count >= 1)
                    {
                        Response.Redirect("Index.aspx");
                    }
                    else
                    {
                        //Agregar alerta
                        ClientScript.RegisterClientScriptBlock(this.GetType(), "alert",
                            "swal('¡Oh no!', 'Usuario o contraseña incorrectos', 'warning')", true);
                        //ClientScript.RegisterClientScriptBlock(this.GetType(), "alert", 
                        //    "swal('¡Oh no!', 'Contraseña o usuario no válido', 'warning')",true);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //try
            //{
            //    SqlCommand cmd = new SqlCommand("sp_login", con);
            //    cmd.CommandType = System.Data.CommandType.StoredProcedure;
            //    cmd.Parameters.Add("@Usuario", System.Data.SqlDbType.VarChar).Value = usuario.Text;
            //    cmd.Parameters.Add("@Clave", System.Data.SqlDbType.VarChar).Value = clave.Text;
            //    cmd.Parameters.Add("@Patron", System.Data.SqlDbType.VarChar).Value = Patron;
            //    con.Open();
            //    SqlDataReader rd = cmd.ExecuteReader();

            //    if(rd.Read())
            //    {
            //        Session["Id_rol"] = rd[5].ToString();
            //        Session["usuario"] = rd[1].ToString();
            //        Response.Redirect("Index.aspx");
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
    }
}