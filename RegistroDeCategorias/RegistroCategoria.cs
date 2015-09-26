using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RegistroDeCategorias
{
    public partial class RegistroCategoria : Form
    {
        public RegistroCategoria()
        {
            InitializeComponent();
            GetIdCategoria();
        }

        private void GetIdCategoria()
        {
            using (SqlConnection conexion = DBConexion.getConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select MAX(CategoriaId)+1 as Id from Categorias"), conexion);
                SqlDataReader reader = comando.ExecuteReader();

                if(reader.Read() == true)
                {
                    IdCategoriatextBox.Text = reader["Id"].ToString();
                }
                conexion.Close();
            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (DescripcionrichTextBox.Text.Length == 0)
            {
                errorProvider.SetError(DescripcionrichTextBox, "Falta la Descripcion");
            }
            else
            {
                Categoria c = new Categoria();
                c.Descripcion = DescripcionrichTextBox.Text;

                int resultado = CategoriaDAL.Agregar(c);

                if (resultado > 0)
                {
                    MessageBox.Show("Guardado Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error Al Guardar", "Datos No Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                GetIdCategoria();
                DescripcionrichTextBox.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DescripcionrichTextBox.Text = "";
        }

        private void Cancelarbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
