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
    public partial class Area_y_Perimetro_de_poligono : Form
    {
        public Area_y_Perimetro_de_poligono()
        {
            InitializeComponent();
        }

        private void textBoxLado_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void calcularAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Area_y_Perimetro_de_poligono_Load(object sender, EventArgs e)
        {

        }

        private void buttonPerimetro_Click(object sender, EventArgs e)
        {
            Calcualr_Perimetro cp = new Calcualr_Perimetro();
            cp.Show();
        }

        private void buttonArea_Click(object sender, EventArgs e)
        {
            CalcularArea ca = new CalcularArea();
            ca.Show();
        }
    }
}
