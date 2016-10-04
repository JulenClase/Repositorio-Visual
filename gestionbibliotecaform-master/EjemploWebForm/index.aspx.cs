using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WebApplication1
{
    public partial class index : System.Web.UI.Page
    {
        DataTable dt;
        protected void Page_Load(object sender, EventArgs e)
        {
            cargaDatos();
        }

        private void cargaDatos()
        {
            try
            {
                string cadenaConexion = ConfigurationManager.ConnectionStrings["formacion-to15.GESTLIBRERIA"].ConnectionString;
                string SQL = "SELECT * FROM usuarios";
                SqlConnection conn = new SqlConnection(cadenaConexion);
                conn.Open();
                DataSet ds = new DataSet();
                SqlDataAdapter dAdapter = new SqlDataAdapter(SQL, conn);
                dAdapter.Fill(ds);
                dt = ds.Tables[0];

                grdv_Usuarios.DataSource = dt;
                grdv_Usuarios.DataBind();
                conn.Close();
            }
            catch (SqlException ex)
            {
                Console.Error.Write(ex.Message);
            }
        }

        protected void grdv_Usuarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            string comand = e.CommandName;
            int index = Convert.ToInt32(e.CommandArgument);
            switch (comand) {
                case "editUsuario":
                    //hemos pulsado el boton de editar;
                    break;
                case "deleteUsuario":
                    //hemos pulsado el boton de borrar;
                    string codigo = grdv_Usuarios.DataKeys[index].Value.ToString();
                    string cadenaConexion = ConfigurationManager.ConnectionStrings["GESTLIBRERIAConnectionString"].ConnectionString;
                    string SQL = "DELETE FROM usuarios WHERE id=" + codigo;
                    SqlConnection conn = null;
                    try {
                        
                        conn = new SqlConnection(cadenaConexion);
                        conn.Open();
                        SqlCommand sqlcmd = new SqlCommand(SQL, conn);
                        sqlcmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex){
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }

                    
                    
                    break;
            }
        }
    }
}