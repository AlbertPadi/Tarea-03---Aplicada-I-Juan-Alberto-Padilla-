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
    public partial class Ejercicio_2 : Form
    {
        public Ejercicio_2()
        {
            InitializeComponent();
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {
            float angulo;
            float.TryParse(textBoxAngulo.Text, out angulo);
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            float angulo;
            float.TryParse(textBoxAngulo.Text, out angulo);
            double res;
            res = (Math.PI / 180) * angulo;

            textBoxResultado.Text = res.ToString();

        }
    }
}
