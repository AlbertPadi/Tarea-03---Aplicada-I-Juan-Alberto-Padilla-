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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }


        
        
        private void button1_Click(object sender, EventArgs e)
        {
            int dato;
            int.TryParse(textBoxNumero.Text, out dato);

            for (int i = 1; i <= dato; i++)
            {
               dato *= i;
            }
            textBoxFactorial.Text = dato.ToString();



        }
    }
}
