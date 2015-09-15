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
    public partial class Ejercicio_2cap3 : Form
    {
        public Ejercicio_2cap3()
        {
            InitializeComponent();
        }

        private void buttonConvertir_Click(object sender, EventArgs e)
        {
            
        }

        private void GradosARadianes_Click(object sender, EventArgs e)
        {
            GradosARadianes ga = new GradosARadianes();
            ga.Show();
        }
    }
}
