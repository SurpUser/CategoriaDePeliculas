using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeCategorias
{
    public partial class ConsultaCategoria : Form
    {
        public ConsultaCategoria()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            if (string.IsNullOrEmpty(CategoriaIdtextBox.Text))
            {
                MessageBox.Show("Debe completar la informacion");
                errorProvider.SetError(CategoriaIdtextBox,"Ingrese Id");
            }
            else
            {
                DatosdataGridView.DataSource = CategoriaDAL.BuscarCategoria(Int32.Parse(CategoriaIdtextBox.Text));
            }
        }

        private void CategoriaIdtextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}
