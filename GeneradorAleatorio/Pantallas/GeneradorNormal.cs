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
    public partial class GeneradorNormal : Form
    {
        private PantallaSeleccionModo PantallaSeleccion;
        public GeneradorNormal(PantallaSeleccionModo pantallaSeleccion)
        {
            InitializeComponent();
            PantallaSeleccion = pantallaSeleccion;
        }

        private void GeneradorNormal_Load(object sender, EventArgs e)
        {

        }

        private void GeneradorNormal_FormClosing(object sender, FormClosingEventArgs e)
        {
            PantallaSeleccion.Show();
            this.Dispose();
        }
    }
}
