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
    public partial class NumeroParoImpar : Form
    {
        public NumeroParoImpar()
        {
            InitializeComponent();
        }

        private void buttonComprobar_Click(object sender, EventArgs e)
        {
            int numero;
            int.TryParse(textBoxNumero.Text, out numero);
            if (numero % 2 == 0)
            {
                textBoxPrueba.Text = numero.ToString("Es par");
            }
            else
            {
                textBoxPrueba .Text = numero.ToString("No es par");
            }
        }
    }
}
