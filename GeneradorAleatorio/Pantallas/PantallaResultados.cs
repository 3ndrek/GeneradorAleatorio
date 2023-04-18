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
    public partial class PantallaResultados : Form
    {

        private List<Double> numerosRandom;

        private GestorDeCalculos gestor;
        public PantallaResultados(List<Double> numeros, GestorDeCalculos gestor1)
        {
            InitializeComponent();
            this.numerosRandom = numeros;

            gestor = gestor1;


        }

        private void PantallaResultados_Load(object sender, EventArgs e)
        {

            DvgArreglo.Columns.Add("Columna2", "Valor");

            foreach (Double i in numerosRandom)
            {

                DvgArreglo.Rows.Add( Math.Round(i,4));  
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                if(TxtIntervalos.Text != "")
                {
                    int inter = Int32.Parse(TxtIntervalos.Text);
                    gestor.asignarIntervalos(inter);
                }
              
            }
            catch
            {
                MessageBox.Show("Debe ingresar un valor entero positivo");
            }

        }

        // estaría para desde acá generar un archivo csv, o desde acá o desde la de chi 
    }
}
