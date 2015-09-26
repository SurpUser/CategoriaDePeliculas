using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RegistroDeCategorias
{
    class DBConexion
    {
        public static SqlConnection getConexion()
        {
            SqlConnection con = new SqlConnection("Data Source=(local); Initial Catalog=Pelicula; Integrated Security=true;");
            try
            {               
                con.Open();               
            }
            catch (Exception e)
            {
                MessageBox.Show("Error Al Conectar", "No Conectado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }
    }
}
