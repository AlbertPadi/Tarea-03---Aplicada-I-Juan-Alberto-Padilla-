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
    public partial class GradosARadianes : Form
    {
        public GradosARadianes()
        {
            InitializeComponent();
        }


        private void textBoxDato_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            float dato, radianes;
            float.TryParse(textBoxDato.Text, out dato);
            float.TryParse(textBoxRadianes.Text, out radianes);

            float res;
            res = (dato * radianes) / 180;
            res /= 4;

            

            float.TryParse(textBoxResultado.Text, out res);
            textBoxResultado.Text = res.ToString();
        }

    }
}
