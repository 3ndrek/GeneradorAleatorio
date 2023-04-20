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

        private int modoSelec;
        public PantallaResultados(List<Double> numeros, GestorDeCalculos gestor1, int modo)
        {
            InitializeComponent();
            this.numerosRandom = numeros;
            modoSelec = modo;

            gestor = gestor1;


        }

        private void PantallaResultados_Load(object sender, EventArgs e)
        {
            if(modoSelec == 4)
            {
                TxtIntervalos.Visible = false;
                label1.Visible = false;
            }


            DvgArreglo.Columns.Add("Columna2", "Valor");

            foreach (Double i in numerosRandom)
            {

                DvgArreglo.Rows.Add( Math.Truncate(i * 10000)/10000);  
            }
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            if(modoSelec != 4)
            {
                try
                {
                    if (TxtIntervalos.Texts != "")
                    {
                        int inter = Int32.Parse(TxtIntervalos.Texts);
                        gestor.asignarIntervalos(inter);
                    }

                }
                catch
                {
                    MessageBox.Show("Debe ingresar un valor entero positivo");
                }
            }
            else
            {
                try
                {
                    if (TxtIntervalos.Texts == "")
                    {
                        gestor.asignarIntervalos(1);
                    }

                }
                catch
                {
                    
                }
            }
            

        }

    }
}
