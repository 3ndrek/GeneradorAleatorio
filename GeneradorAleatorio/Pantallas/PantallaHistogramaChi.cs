
using LiveCharts.Wpf.Charts.Base;
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
            Histograma1.Series.Add("Frecuencia Observada");
            Histograma1.Series["Frecuencia Observada"].ChartType = SeriesChartType.Column;

            // Obtener los datos de los intervalos superiores, inferiores y frecuencia observada
            int filas = frecuencia0.GetLength(0);
            double[] intervalosSuperiores = new double[filas]; 
            double[] intervalosInferiores = new double[filas];
            double[] frecuenciaObservada = new double[filas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        intervalosInferiores[i]=frecuencia0[i,j];
                    }

                    if (j == 1)
                    {
                        intervalosSuperiores[i] = frecuencia0[i, j];
                    }

                    if (j == 2)
                    {
                        frecuenciaObservada[i] = frecuencia0[i, j];
                    }
                }
            }

            // Agregar los puntos a la serie del Chart
            for (int i = 0; i < intervalosSuperiores.Length; i++)
            {
                double xValue = (intervalosSuperiores[i] + intervalosInferiores[i]) / 2.0;
                double yValue = frecuenciaObservada[i];
                Histograma1.Series["Frecuencia Observada"].Points.AddXY(xValue, yValue);
            }

            // Asignar los nombres a los ejes X e Y del Chart
            Histograma1.ChartAreas[0].AxisX.Title = "Intervalos";
            Histograma1.ChartAreas[0].AxisY.Title = "Frecuencia Observada";

            // Ajustar las propiedades de la serie y del Chart
            Histograma1.Series["Frecuencia Observada"].Color = Color.Aqua;
            Histograma1.Series["Frecuencia Observada"].BorderWidth = 6 ;
            Histograma1.ChartAreas[0].AxisX.Interval = intervalosSuperiores[1] - intervalosInferiores[1];
            Histograma1.ChartAreas[0].AxisX.Minimum = intervalosInferiores[0];
            //Histograma1.ChartAreas[0].AxisX.Maximum = intervalosSuperiores[intervalosSuperiores.Length - 1];
            Histograma1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            Histograma1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

        }
    }
}




       

