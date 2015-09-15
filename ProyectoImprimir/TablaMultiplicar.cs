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
    public partial class TablaMultiplicar : Form
    {
        public TablaMultiplicar()
        {
            InitializeComponent();
        }

        private void textBoxNumero_TextChanged(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int  res;
            int.TryParse(textBoxNumero.Text, out res);
            for (int i = 1; i <= 10; i++)
            {
                res *= i;
               
                richTextBoxMostrar.Text = res.ToString();
                
            }
           
            
        }

        private void textBoxResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
