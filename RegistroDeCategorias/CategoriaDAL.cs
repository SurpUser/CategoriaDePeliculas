using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace RegistroDeCategorias
{
    class CategoriaDAL
    {
        public static int Agregar(Categoria categoria)
        {
            int retorno;
            using (SqlConnection con = DBConexion.getConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("insert into Categorias(Descripcion) VALUES('{0}')",categoria.Descripcion), con);
                retorno = comando.ExecuteNonQuery();
                con.Close();
            }
            return retorno;
        }

        public static List<Categoria> BuscarCategoria(int CategoriaId)
        {
            List<Categoria> Lista = new List<Categoria>();
            using (SqlConnection conexion = DBConexion.getConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select * from Categorias where CategoriaId={0}",CategoriaId), conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Categoria c = new Categoria();
                    c.CategoriaId = reader.GetInt32(0);
                    c.Descripcion = reader.GetString(1);            

                    Lista.Add(c);
                }
                conexion.Close();
                return Lista;
            }
        }
    }
}
