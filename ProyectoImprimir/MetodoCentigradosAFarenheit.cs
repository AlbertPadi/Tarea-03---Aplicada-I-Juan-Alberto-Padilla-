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
    public partial class MetodoCentigradosAFarenheit : Form
    {
        public MetodoCentigradosAFarenheit()
        {
            InitializeComponent();
        }

        private double CentigradosAFarenheit(double cent)
        {
            return (cent * 1.8) + 32;
                }
        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            double dato;
            double.TryParse(textBoxCentigrados.Text, out dato);

            textBoxFarenheit.Text = CentigradosAFarenheit(dato).ToString();
        }
    }
}
