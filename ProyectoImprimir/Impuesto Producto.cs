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
    public partial class Impuesto_Producto : Form
    {
        public Impuesto_Producto()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double costo = 0;
            double.TryParse(textBoxCosto.Text, out costo);
            double impuesto = costo * 0.18;
            double.TryParse(textBoxImpuesto.Text, out impuesto);
            textBoxImpuesto.Text = impuesto.ToString();
        }
    }
}
