using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneradorAleatorio.Pantallas;

namespace GeneradorAleatorio.Pantallas
{
    public partial class PantallaSeleccionModo : Form
    {
        public PantallaSeleccionModo()
        {
            
            InitializeComponent();
        }

        private void BtnUniforme_Click(object sender, EventArgs e)
        {

            // en primer lugar se selecciona el modo y salta a la pantalla del generador para pedir los datos 
           var pantalla = new GeneadorUniforme(this);
            
           pantalla.Show();
        Hide();
        }

        private void BtnNormal_Click(object sender, EventArgs e)
        {
            var pantalla = new GeneradorNormal(this);
            pantalla.Show();
            this.Hide();
        }

        private void BtnPoisson_Click(object sender, EventArgs e)
        {
            var pantalla = new GeneradorPoisson(this);
            pantalla.Show();
            this.Hide();
        }

        private void PantallaSeleccionModo_Load(object sender, EventArgs e)
        {

        }

        private void BtnExp_Click(object sender, EventArgs e)
        {
            var pantalla = new GeneradorExponencial(this);
            pantalla.Show();
            this.Hide();
        }
    }
}
