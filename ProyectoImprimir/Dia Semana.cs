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
    public partial class Dia_Semana : Form
    {
        public Dia_Semana()
        {
            InitializeComponent();
        }

        private void textBoxDia_TextChanged(object sender, EventArgs e)
        {
            int dia;
            int.TryParse(textBoxDia.Text, out dia);
        }

        private void buttonComprobar_Click(object sender, EventArgs e)
        {
            int dia;
            int.TryParse(textBoxDia.Text, out dia);

            if(dia == 1)
            {
                textBoxCompDia.Text = dia.ToString("Lunes"); 
            }
            if(dia == 2)
            {
                textBoxCompDia.Text = dia.ToString("Martes"); 
            }
            if(dia == 3)
            {
                textBoxCompDia.Text = dia.ToString("Miercoles");
            }
            if (dia == 4)
            {
                textBoxCompDia.Text = dia.ToString("Jueves");
            }
            if (dia == 5)
            {
                textBoxCompDia.Text = dia.ToString("Viernes");
            }
            if (dia == 6)
            {
                textBoxCompDia.Text = dia.ToString("Sabado");
            }
            if (dia == 7)
            {
                textBoxCompDia.Text = dia.ToString("Domingo");
            }
           

        }
    }
}
