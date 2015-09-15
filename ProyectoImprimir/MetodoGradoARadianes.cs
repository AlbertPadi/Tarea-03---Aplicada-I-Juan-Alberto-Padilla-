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
    public partial class MetodoGradoARadianes : Form
    {
        public MetodoGradoARadianes()
        {
            InitializeComponent();
        }

        private double gradoRadianes(double grado ) {
            return (grado * 3.14) / 180;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double dato;
            double.TryParse(textBoxDato.Text, out dato);

            textBoxResultado.Text = gradoRadianes(dato).ToString();

        }
    }
}
