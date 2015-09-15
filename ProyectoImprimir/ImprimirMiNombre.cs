using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoImprimir
{
    public partial class ImprimirMiNombre : Form
    {
        public ImprimirMiNombre()
        {
            InitializeComponent();
        }


        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text =("Juan Alberto Padilla Balbi");
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El ejercicio 5 se trata de \nagregar mas cosas al primer ejerciccio");
        }
    }
}
