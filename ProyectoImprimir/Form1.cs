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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void buttonMostrar_Click(object sender, EventArgs e)
        {

            //MessageBox.Show("button1.Click was raised.");
            
        }

        private void textBoxNomrbe(object sender, EventArgs e)
        {
            
        }

        private void ejercicio1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ejercicio_1 ejer = new Ejercicio_1();
            ejer.Show();
        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio_2 eje = new Ejercicio_2();
            eje.Show();
        }

        private void ejercicio4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio_4 eje = new Ejercicio_4();
            eje.Show();
        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ejercicio5ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ejercicio_5 eje = new Ejercicio_5();
            eje.Show();
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NumeroParoImpar ejer = new NumeroParoImpar();
            ejer.Show();
        }

        private void ejercicio3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Impuesto_Producto impu = new Impuesto_Producto();

            impu.Show();
        }

        private void ejercicio2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Ejercicio_2cap3 ejer = new Ejercicio_2cap3();
            ejer.Show();
        }

        private void ejercicio4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Dia_Semana dia = new Dia_Semana();
            dia.Show();
        }

        private void ejercicio4ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Area_y_Perimetro_de_poligono aYe = new Area_y_Perimetro_de_poligono();
            aYe.Show();
        }

        private void ejercicio1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            TablaMultiplicar tm = new TablaMultiplicar();
            tm.Show();
        }

        private void ejercicio4ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NumerosPrimos np = new NumerosPrimos();
            np.Show();
        }

        private void ejercicio2ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ElevarAPotencia pn = new ElevarAPotencia();
            pn.Show();
        }

        private void ejercicio5ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PromedioEdades ep = new PromedioEdades();
            ep.Show();
        }

        private void ejercicio1ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MetodoGradoARadianes mad = new MetodoGradoARadianes();
            mad.Show();
        }

        private void ejercicio2ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MetodoCentigradosAFarenheit mcgf = new MetodoCentigradosAFarenheit();
            mcgf.Show();
        }

        private void ejercicio3ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            PerimetrodePoligonoReg per = new PerimetrodePoligonoReg();
            per.Show();
        }

        private void ejercicio4ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Factorial fact = new Factorial();
            fact.Show();
        }

        private void ejercicio1ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ImprimirMiNombre imp = new ImprimirMiNombre();
            imp.Show();
        }
    }
}
