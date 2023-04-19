
using LiveCharts.Wpf.Charts.Base;
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
using System.Windows.Forms.DataVisualization.Charting;


namespace GeneradorAleatorio.Pantallas
{
    public partial class PantallaHistogramaChi : Form
    {
        private double[,] frecuencia0;
        private double valorCalc;
        private int tamañoMuestra;
        private List<Double> valoresTabuladosChi = new List<Double> { 3.83, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8, 44.98, 46.19, 43.39, 48.60, 49.80, 50.99, 52.19, 53.38, 54.57, 55.8, 56.94, 58.12, 59.30, 60.48, 61.65, 62.83, 64.00, 65.75, 66.33, 67.5 };
        private List<Double> valoresTabuladosKS = new List<Double> { 0.97500, 0.84189, 0.70760, 0.62394, 0.56328, 0.51926, 0.48342, 0.45427, 0.43001, 0.40925, 0.39122, 0.37543, 0.36143, 0.34890, 0.33750, 0.32733, 0.31796, 0.30936, 0.30143, 0.29408, 0.28724, 0.28087, 0.27490, 0.26931, 0.26404, 0.25908, 0.25438, 0.24993, 0.24571, 0.24170, 0.23788, 0.23076, 0.22743, 0.22425 };
        private int gradosL;


        public PantallaHistogramaChi(double[,] frecuenciaObservada, double valorCalculado, int tamaño, int gradosLibertad)
        {
            InitializeComponent();
            frecuencia0 = frecuenciaObservada;
            tamañoMuestra = tamaño;
            valorCalc = Math.Truncate(valorCalculado * 10000)/10000;
            gradosL = gradosLibertad;
            cargarMatrizDGV();
        }


        public void cargarMatrizDGV()
        {


            for (int i = 0; i < frecuencia0.GetLength(0); i++)
            {
                DataGVCHI.Rows.Add(Math.Truncate(frecuencia0[i, 0]*10000)/10000, Math.Truncate(frecuencia0[i, 1]*10000)/10000, Math.Truncate(frecuencia0[i, 2]*10000)/10000, Math.Truncate(frecuencia0[i, 3]*10000)/10000);
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
            Histograma1.ChartAreas[0].AxisX.Interval = Math.Truncate((intervalosSuperiores[1] - intervalosInferiores[1])*10000)/10000;
            Histograma1.ChartAreas[0].AxisX.Minimum = Math.Truncate(intervalosInferiores[0]*10000)/10000;
            //Histograma1.ChartAreas[0].AxisX.Maximum = intervalosSuperiores[intervalosSuperiores.Length - 1];
            Histograma1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            Histograma1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;


            //Envía a la pantalla los valores calculados y tabulados de ks o chi
            lblValorCalculado.Text = valorCalc.ToString();

            if(tamañoMuestra <= 30 && tamañoMuestra >= 10)
            {
                //Se fija el valor correspondiente en la tabla ks con un alfa=5%
                if (gradosL <= 35)
                {
                    lblValorTabulado.Text = valoresTabuladosKS[gradosL - 1].ToString();
                }
                else
                {
                    lblValorTabulado.Text = (1.36 / Math.Sqrt(gradosL)).ToString();
                }
                try
                {
                    if (Double.Parse(lblValorCalculado.Text) <= Double.Parse(lblValorTabulado.Text))
                    {
                        lblAceptacion.Text = "Se ACEPTA la hipótesis nula según prueba de Kolmogorov-Smirnov";
                    }
                    else
                    {
                        lblAceptacion.Text = "No se acepta la hipótesis nula según prueba de Kolmogorov-Smirnov";
                    }
                }
                catch
                {

                }
                
            }

            else if(tamañoMuestra > 30)
            {
                //Se fija el valor correspondiente en la tabla chi-cuadrado con un alfa=5%
                if(gradosL <= 50 )
                {
                    if(gradosL <= 0)
                    {
                        System.Windows.Forms.MessageBox.Show("No es posible calcular. Por favor intente otro valor de intervalo");
                        this.Close();
                    }
                    else
                    {
                        lblValorTabulado.Text = valoresTabuladosChi[gradosL - 1].ToString();
                        try
                        {
                            if (Double.Parse(lblValorCalculado.Text) <= Double.Parse(lblValorTabulado.Text))
                            {
                                lblAceptacion.Text = "Se ACEPTA la hipótesis nula según prueba de Chi-Cuadrado";
                            }
                            else
                            {
                                lblAceptacion.Text = "No se acepta la hipótesis nula según prueba de Chi-Cuadrado";
                            }
                        }
                        catch
                        {

                        }
                    }
                }
                else 
                {
                    System.Windows.Forms.MessageBox.Show("No es posible calcular. Por favor intente otro valor de intervalo");
                    this.Close();
                }

                
                
            }

        }
    }
}




       

