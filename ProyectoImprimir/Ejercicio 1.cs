﻿using System;
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
    public partial class Ejercicio_1 : Form
    {
        public Ejercicio_1()
        {
            InitializeComponent();
        }

        private void textBoxLado_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            float lado, longitud;

            float.TryParse(textBoxLado.Text, out lado);
            float.TryParse(textBoxLongitud.Text, out longitud);
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            float lado, longitud;

            float.TryParse(textBoxLado.Text, out lado);
            float.TryParse(textBoxLongitud.Text, out longitud);

            float res;

            res = lado * longitud;
            textBoxResultado.Text = res.ToString();
        }
    }
}
