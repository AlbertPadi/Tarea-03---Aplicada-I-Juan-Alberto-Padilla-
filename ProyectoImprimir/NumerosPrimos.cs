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
    public partial class NumerosPrimos : Form
    {
        public NumerosPrimos()
        {
            InitializeComponent();
        }

        private void buttonPrimos_Click(object sender, EventArgs e)
        {
            int cont = 0;
            int cont2 = 0;
            for(int i = 3; i <= 1000; i++)
            {
                for(int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        cont2++;
                    }
                }
                if (cont2 == 0)
                {

                    cont++;
                    

                }

                richTextBoxResultado.Text = cont.ToString();

            }
        }
    }
}
