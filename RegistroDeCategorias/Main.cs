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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void deCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCategoria rc = new RegistroCategoria();
            rc.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaCategoria cc = new ConsultaCategoria();
            cc.Show();
        }
    }
}
