
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media;

namespace GeneradorAleatorio.Pantallas
{
    public partial class PantallaHistogramaChi : Form
    {
        private double[,] frecuencia0;



        public PantallaHistogramaChi(double[,] frecuenciaObservada)
        {
            InitializeComponent();
            frecuencia0 = frecuenciaObservada;
            cargarMatrizDGV();
        }


        public void cargarMatrizDGV()
        {

            var a = 0;

            for (int i = 0; i < frecuencia0.GetLength(0); i++)
            {
                DataGVCHI.Rows.Add(frecuencia0[i, 0], frecuencia0[i, 1], frecuencia0[i, 2], frecuencia0[i, 3]);
            }
        }

        private void PantallaHistogramaChi_Load(object sender, EventArgs e)
        {
           /// primero obtengo los intervalos 
           
            var intervalos = new List<Double>();
            var freq = new List<Double>();
            for (int i = 0;  i< frecuencia0.GetLength(0) ;i ++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j==0)
                    {
                            intervalos.Add(frecuencia0[i, j]);
 

                    }
                    if (j== 2)
                    {
                        freq.Add(frecuencia0[i, j]);
                    }

                }
            }

            Histograma1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.BrightPastel;

            Histograma1.Titles.Add("Histograma de los valores generados");

            for (int i = 0; i < intervalos.Count ; i++)
            {
                 
                Series series = Histograma1.Series.Add( intervalos[i].ToString() );

                series.Label = freq[i].ToString();

                series.Points.Add(freq[i]);
            }



        }
    }

}


       

