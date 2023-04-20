﻿using System;
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
    public partial class PantallaResultadoPoisson : Form
    {
        private double[,] frecuencia0;
        private double valorCalc;
        private int tamañoMuestra;
        private List<Double> valoresTabuladosChi = new List<Double> { 3.83, 5.99, 7.81, 9.49, 11.1, 12.6, 14.1, 15.5, 16.9, 18.3, 19.7, 21.0, 22.4, 23.7, 25.0, 26.3, 27.6, 28.9, 30.1, 31.4, 32.7, 33.9, 35.2, 36.4, 37.7, 38.9, 40.1, 41.3, 42.6, 43.8, 44.98, 46.19, 43.39, 48.60, 49.80, 50.99, 52.19, 53.38, 54.57, 55.8, 56.94, 58.12, 59.30, 60.48, 61.65, 62.83, 64.00, 65.75, 66.33, 67.5 };
        private int gradosL;


        public PantallaResultadoPoisson(double[,] frecuenciaObservada, double valorCalculado, int tamaño, int gradosLibertad)
        {
            InitializeComponent();
            frecuencia0 = frecuenciaObservada;
            tamañoMuestra = tamaño;
            valorCalc = Math.Truncate(valorCalculado * 10000) / 10000;
            gradosL = gradosLibertad;
            cargarMatrizDGV();
        }


        public void cargarMatrizDGV()
        {


            for (int i = 0; i < frecuencia0.GetLength(0); i++)
            {
                DataGVCHI.Rows.Add(Math.Truncate(frecuencia0[i, 0] * 10000) / 10000, Math.Truncate(frecuencia0[i, 1] * 10000) / 10000, Math.Truncate(frecuencia0[i, 2] * 10000) / 10000, Math.Truncate(frecuencia0[i, 3] * 10000) / 10000);
            }
        }

        private void PantallaResultadoPoisson_Load(object sender, EventArgs e)
        {
            Histograma1.Series.Add("Frecuencia Observada");
            Histograma1.Series["Frecuencia Observada"].ChartType = SeriesChartType.Column;

            // Asignar los nombres a los ejes X e Y del Chart
            Histograma1.ChartAreas[0].AxisX.Title = "Intervalos";
            Histograma1.ChartAreas[0].AxisY.Title = "Frecuencia Observada";

            // Ajustar las propiedades de la serie y del Chart
            Histograma1.Series["Frecuencia Observada"].Color = Color.Aqua;
            Histograma1.Series["Frecuencia Observada"].BorderWidth = 6;
            
            Histograma1.ChartAreas[0].AxisX.Minimum = Math.Truncate(frecuencia0[0,0] * 10000) / 10000;

            Histograma1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
            Histograma1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;

            //Envía a la pantalla los valores calculados y tabulados de ks o chi
            lblValorCalculado.Text = valorCalc.ToString();

           

           
                //Se fija el valor correspondiente en la tabla chi-cuadrado con un alfa=5%
                if (gradosL <= 50)
                {
                    if (gradosL <= 0)
                    {
                        MessageBox.Show("No es posible calcular. Por favor intente otro valor de intervalo");
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
                    MessageBox.Show("No es posible calcular. Por favor intente otro valor de tamaño de muestra");
                    this.Close();
                }

        }
    }
}
