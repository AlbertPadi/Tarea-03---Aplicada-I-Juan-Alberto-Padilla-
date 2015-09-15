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
    public partial class Ejercicio_4 : Form
    {
        public Ejercicio_4()
        {
            InitializeComponent();
        }

        private void textBoxCentigrados_TextChanged(object sender, EventArgs e)
        {
            float cent;
            float.TryParse(textBoxCentigrados.Text, out cent);
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            float cent;
            float.TryParse(textBoxCentigrados.Text, out cent);

            float res;
            res = (cent * 9/ 5) + 32;

            textBoxFahrenheit.Text = res.ToString();
        }
    }
}
