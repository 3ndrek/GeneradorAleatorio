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
    public partial class GeneadorUniforme : Form
    {
        private PantallaSeleccionModo pantalla1;
        public GeneadorUniforme(PantallaSeleccionModo pantalla)
        {
            pantalla1 = pantalla; 
            InitializeComponent();
        }

        private void GeneadorUniforme_Load(object sender, EventArgs e)
        {

        }

        private void GeneadorUniforme_FormClosing(object sender, FormClosingEventArgs e)
        {
            pantalla1.Show();
            this.Dispose();
        }
    }
}
