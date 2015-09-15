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
    public partial class ElevarAPotencia : Form
    {
        public ElevarAPotencia()
        {
            InitializeComponent();
        }

        private void buttonElevar_Click(object sender, EventArgs e)
        {
            int nbase, pot;

            int.TryParse(textBoxBase.Text, out nbase);
            pot = nbase * nbase * nbase;
            
            textBoxResultado.Text = pot.ToString();
        }
    }
}
