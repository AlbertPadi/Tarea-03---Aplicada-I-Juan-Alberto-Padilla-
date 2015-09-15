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
    public partial class CalcularArea : Form
    {
        public CalcularArea()
        {
            InitializeComponent();
        }
        

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            float apot;
            float.TryParse(textBoxApotema.Text, out apot);
            Calcualr_Perimetro cp = new Calcualr_Perimetro ();
            float result;
       
            
        }
    }
}
