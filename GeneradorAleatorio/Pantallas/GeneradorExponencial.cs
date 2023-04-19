using GeneradorAleatorio.Gestor;
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
    public partial class GeneradorExponencial : Form
    {
        private PantallaSeleccionModo pantalla1;
        private GestorDeCalculos gestorDeCalculos;
        private int numerosAGenerar;
        private double media;

        public GeneradorExponencial(PantallaSeleccionModo pantalla)
        {
            InitializeComponent();
            pantalla1 = pantalla;
        }

        private void GeneradorExponencial_FormClosing(object sender, FormClosingEventArgs e)
        {
            pantalla1.Show();
            this.Dispose();
        }

        private List<double> GenerarRNDExponencial()
        {
            Random rnd = new Random();
            int ctrl = 0;

            List<double> numerosGenerados = new List<double>();

            do
            {
                double numAleatorio = (-media) * Math.Log(1 - rnd.NextDouble());
                numerosGenerados.Add(numAleatorio);
                ctrl += 1;
            } while (ctrl < numerosAGenerar);

            return numerosGenerados;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                numerosAGenerar = Int32.Parse(txtCantValores.Text);
                media = Double.Parse(txtMedia.Text);
                if (numerosAGenerar < 10)
                {
                    MessageBox.Show("No se puede realizar pruebas KS o Chi con este valor. Ingrese un valor mayor o igual a 10");
                }
                else
                {
                    List<double> numeros = GenerarRNDExponencial();
                    gestorDeCalculos = new GestorDeCalculos(numeros, 3, media);
                }
            }
            catch
            {
                MessageBox.Show("No se puede procesar los valores ingresados. Por favor intente nuevamente.");
            }
            
            
            
        }
    }
}
