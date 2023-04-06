using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneradorAleatorio.Pantallas
{
    public partial class GeneradorPoisson : Form
    {
        private PantallaSeleccionModo pantallaSeleccion;
        public GeneradorPoisson(PantallaSeleccionModo pantallaSeleccionModo)
        {
            pantallaSeleccion = pantallaSeleccionModo;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GeneradorPoisson_FormClosing(object sender, FormClosingEventArgs e)
        {
            pantallaSeleccion.Show();
            this.Dispose(); 
        }
    }
}
