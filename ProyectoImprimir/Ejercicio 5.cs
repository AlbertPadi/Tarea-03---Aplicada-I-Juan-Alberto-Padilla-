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
    public partial class Ejercicio_5 : Form
    {
        public Ejercicio_5()
        {
            InitializeComponent();
        }

        private void labelDollar_Click(object sender, EventArgs e)
        {

        }


        private void textBoxTD_TextChanged(object sender, EventArgs e)
        {
            float dollar, cDollar;

            float.TryParse(textBoxCD.Text, out dollar);
            float.TryParse(textBoxDollar.Text, out cDollar);
        }

        private void textBoxCD_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void buttonCambio_Click(object sender, EventArgs e)
        {
            float dollar, TD = 0.89f;

            float.TryParse(textBoxDollar.Text, out dollar);
            

            float cambio = dollar * TD;
            textBoxCD.Text = cambio.ToString();
        }

        private void textBoxTE_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonCambio1_Click(object sender, EventArgs e)
        {
            float TE = 1.19f, CantEur;

            
            float.TryParse(textBoxEuro.Text, out CantEur);

            float cambio = CantEur * TE;
            textBoxCE.Text = cambio.ToString();
        }

        private void textBoxDollar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
