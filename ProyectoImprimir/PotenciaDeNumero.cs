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
    public partial class PotenciaDeNumero : Form
    {
        public PotenciaDeNumero()
        {
            InitializeComponent();
        }

        

        private void buttonElevar_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonResultado_Click(object sender, EventArgs e)
        {
            int nbase = 0, nexpo = 0;

            int.TryParse(textBoxNumero.Text, out nbase);
            int.TryParse(textBoxPotencia.Text, out nexpo);
            int pot = 0;

            for (int i = 1; i < nexpo; i++)
            {
                pot *= i;
            }
            textBoxResultado.Text = pot.ToString();
        }
    }
}
