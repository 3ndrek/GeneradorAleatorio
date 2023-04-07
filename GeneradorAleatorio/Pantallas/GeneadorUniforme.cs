﻿using GeneradorAleatorio.Gestor;
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
    public partial class GeneadorUniforme : Form
    {
        private PantallaSeleccionModo pantalla1;
        private GestorDeCalculos gestorDeCalculos;
        public GeneadorUniforme(PantallaSeleccionModo pantalla)
        {
            pantalla1 = pantalla;
           
            InitializeComponent();
        }

        private void GeneadorUniforme_Load(object sender, EventArgs e)
        {

        }

        private void GeneadorUniforme_FormClosing(object sender, FormClosingEventArgs e)
        {
            pantalla1.Show();
            this.Dispose();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {

            var numeros = generarNumeros();
            gestorDeCalculos = new GestorDeCalculos(numeros,1);

        }

        private List<Double> generarNumeros()
        {
            // obtengo el rnd
            var rand = new Random();
            // genero un listado para almacenar las variables 
            List<double> numeros = new List<double>();
            // obtengo los límites inferiores y superiores y la cantidad de n a generar 
            double Superior = Int32.Parse(LimSup.Text);
            double Inferior = Int32.Parse(LimInf.Text);
            double cantidad = Int32.Parse(CantNum.Text);

            // control del while
            int Contrl = 0;
            do
            {
                double numRand = (rand.NextDouble() * (Superior - Inferior)) + Inferior;
                numeros.Add(numRand);
                Contrl += 1;

            } while (Contrl < cantidad);
            return numeros;
        }




    }
}
