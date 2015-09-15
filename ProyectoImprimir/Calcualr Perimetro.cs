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
    public partial class Calcualr_Perimetro : Form
    {
        public Calcualr_Perimetro()
        {
            InitializeComponent();
        }

        private void textBoxLado_TextChanged(object sender, EventArgs e)
        {
            float lado;
            float.TryParse(textBoxLado.Text, out lado);
        }

        private void textBoxLongitud_TextChanged(object sender, EventArgs e)
        {
            float longitud;
            float.TryParse(textBoxLongitud.Text, out longitud);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            float lado, res;
            float.TryParse(textBoxLado.Text, out lado);
            float longitud;
            float.TryParse(textBoxLongitud.Text, out longitud);

            res = lado * longitud;
            textBoxResultado.Text = res.ToString();
          
    }

        private void Calcualr_Perimetro_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
