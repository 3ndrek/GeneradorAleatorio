using GeneradorAleatorio.Helpers.Distribucion_Normal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GeneradorAleatorio.Gestor;

namespace GeneradorAleatorio.Pantallas
{
    public partial class GeneradorNormal : Form
    {
        private PantallaSeleccionModo PantallaSeleccion;
        private GestorDeCalculos gestorDeCalculos;

        int method;
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void initialConditions() {

            mediaLabel.Visible = false;
            mediaInput.Visible = false;
            desviaLabel.Visible = false;
            desviaInput.Visible = false;
            btnGenerar.Visible = false;

            btnMuller.Visible = true;
            btnConvolucion.Visible = true;
            btnMuller.Enabled   = true;
            btnConvolucion.Enabled = true;
        }


        private void setMethodElementsToVisible ()
        {
            mediaLabel.Visible = true;
            mediaInput.Visible = true;
            desviaLabel.Visible = true;
            desviaInput.Visible = true;
            btnGenerar.Visible = true;
            labelCant.Visible = true;
            inputCant.Visible = true;
        }

        private void setToInvisible (Button name)
        {

            if (name == btnMuller)
            {
                btnConvolucion.Visible = false;
                btnMuller.Enabled = false;

            }
            else {
                btnMuller.Visible = false;
                btnConvolucion.Enabled = false;

            }
        }

        private void btnMuller_Click(object sender, EventArgs e)
        {

            setMethodElementsToVisible();
            setToInvisible(btnMuller);
            method = 1;

        }

        private void btnConvolucion_Click(object sender, EventArgs e)
        {
            setMethodElementsToVisible();
            setToInvisible(btnConvolucion);
            method = 2;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
        var numeros = method == 1 ? 
         (new Box_Muller()).GenerateBoxMuller(float.Parse(mediaInput.Text), float.Parse(desviaInput.Text), Int32.Parse(inputCant.Text)) : 
         (new Convolucion()).GenerateConvolution(float.Parse(mediaInput.Text), float.Parse(desviaInput.Text), Int32.Parse(inputCant.Text));

         gestorDeCalculos = new GestorDeCalculos(numeros, 2);
        }


    }
}
