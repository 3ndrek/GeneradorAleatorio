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
            labelCant.Visible = false;
            inputCant.Visible = false;
            btnReset.Visible = false;

            mediaInput.Text = "";
            desviaInput.Text = "";
            inputCant.Text = "";

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
            btnReset .Visible = true;   
        }

        private void setToDisabled (Button name)
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

        private void setChanges(Button name) {

            setMethodElementsToVisible();
            setToDisabled(name);
        
        }

        private void btnMuller_Click(object sender, EventArgs e)
        {
            // Si hago click en box muller hago visible los inputs, escondo el boton que no se usa y e inhabilito el boton actual que use para no generar errores
            setChanges(btnMuller);
            method = 1;

        }

        private void btnConvolucion_Click(object sender, EventArgs e)
        {
            // Si hago click en convolucion hago visible los inputs, escondo el boton que no se usa y e inhabilito el boton actual que use para no generar errores
            setChanges(btnConvolucion);
            method = 2;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            //Operador ternario, si el metodo es 1 (Box Muller) llamo a mi clase auxiliar que tiene los metodos necesarios para devolver los numeros, caso contario metodo es 2 entonces
            // hago lo correspondiente con las clases auxiliares de convolucion. De esta forma separo la capa de presentacion de la logica, llamo a las clases y estas me devuelven todo calculado
            // sin saber como lo hicieron.

        var numeros = 
                method == 1 ? 
         (new Box_Muller()).GenerateBoxMuller(float.Parse(mediaInput.Text), float.Parse(desviaInput.Text), Int32.Parse(inputCant.Text)) : 
         (new Convolucion()).GenerateConvolution(float.Parse(mediaInput.Text), float.Parse(desviaInput.Text), Int32.Parse(inputCant.Text));

            // Seteo variables globales en Program para no tener que andar mandando de archivo en archivo mi media y desviacion, ademas de que si le mando al gestor
            // la desviacion le rompo el codigo a los que hicieron los otros metodos
            Program.deviation = float.Parse(desviaInput.Text);
            Program.mediaN = float.Parse(mediaInput.Text);

         gestorDeCalculos = new GestorDeCalculos(numeros, 2,double.Parse(mediaInput.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            initialConditions();
        }
    }
}
