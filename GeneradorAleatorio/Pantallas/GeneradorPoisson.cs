using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using GeneradorAleatorio.Gestor;

namespace GeneradorAleatorio.Pantallas
{
    public partial class GeneradorPoisson : Form
    {
        private PantallaSeleccionModo pantallaSeleccion;

        private GestorDeCalculos gestor;
        public GeneradorPoisson(PantallaSeleccionModo pantallaSeleccionModo)
        {
            pantallaSeleccion = pantallaSeleccionModo;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            gestor = new GestorDeCalculos(GenerarPoisson(), 4, 0);
            double lambda = Convert.ToDouble(txtLambda.Text);
            gestor.Plambda = lambda;
        }

        private List<double> GenerarPoisson()
        {
            // Convierto los inputs en numeros

            double lambda = Convert.ToDouble(txtLambda.Text);
            int muestra = Convert.ToInt32(txtMuestra.Text);

            double exp = Math.Exp(-lambda);
            double nroGenerado;

            Random random = new Random();
            List<double> datos = new List<double>(muestra);


            for (int i = 0; i < muestra; i++)
            {
                int x = -1;
                double p = 1;

                // Creo los numeros aleatorios

                do
                {
                    nroGenerado = random.NextDouble();
                    p *= nroGenerado;
                    x += 1;

                } while (p >= exp);

                // Los cargo en la lista

                datos.Add(x);
            }

            return datos;
        }


        private void GeneradorPoisson_FormClosing(object sender, FormClosingEventArgs e)
        {
            pantallaSeleccion.Show();
            this.Dispose();
        }
    }
}
