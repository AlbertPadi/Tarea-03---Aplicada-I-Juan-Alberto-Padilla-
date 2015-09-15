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
    public partial class PromedioEdades : Form
    {
        public PromedioEdades()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Enter(object sender, EventArgs e)
        {
            int edad1, edad2, edad3, edad4, may = 0, men = 0;
            float prom;
            int.TryParse(textBoxEdad1.Text, out edad1);
            int.TryParse(textBoxEdad2.Text, out edad2);
            int.TryParse(textBoxEdad3.Text, out edad3);
            int.TryParse(textBoxEdad4.Text, out edad4);

            prom = (edad1 + edad2 + edad3 + edad4) / 4;

            if(edad1 > edad2 & edad1 >edad3 & edad1 > edad4)
            {
                textBoxMayor.Text = edad1.ToString();
            }
            if(edad2 > edad1 & edad1 > edad3 & edad1 > edad4)
            {
                textBoxMayor.Text = edad2.ToString();
            }
            if (edad3 > edad1 & edad3 > edad2 & edad3 > edad4)
            {
                textBoxMayor.Text = edad3.ToString();
            }

            else
            {
                textBoxMayor.Text = edad4.ToString();
            }

            if (edad1 < edad2 & edad1 < edad3 & edad1 < edad4)
            {
                textBoxMenor.Text = edad1.ToString();
            }
            if (edad2 < edad1 & edad2 < edad3 & edad2 < edad4)
            {
                textBoxMenor.Text = edad2.ToString();
            }
            if (edad3 < edad1 & edad3 < edad2 & edad3 < edad4)
            {
                textBoxMenor.Text = edad3.ToString();
            }

            else if(edad4 < 1 & edad4 < edad2 & edad4 <edad3 )
            {
                textBoxMenor.Text = edad4.ToString();
            }

            textBoxPromedio.Text = prom.ToString();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
