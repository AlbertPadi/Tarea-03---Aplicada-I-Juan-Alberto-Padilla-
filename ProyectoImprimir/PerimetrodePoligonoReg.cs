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
    public partial class PerimetrodePoligonoReg : Form
    {
        public PerimetrodePoligonoReg()
        {
            InitializeComponent();
        }

        private double perimetro(double lado, double noLado) {
            return lado * noLado;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double lado, nLado;
            double.TryParse(textBoxLado.Text, out lado);
            double.TryParse(textBoxNoLado.Text, out nLado);

            textBoxResultado.Text = perimetro(lado, nLado).ToString();
        }
    }
}
