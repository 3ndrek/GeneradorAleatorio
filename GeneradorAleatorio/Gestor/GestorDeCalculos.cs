﻿using GeneradorAleatorio.Contador;
using GeneradorAleatorio.Helpers.Distribucion_Normal;
using GeneradorAleatorio.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GeneradorAleatorio.Gestor
{
    public class GestorDeCalculos

    {
        public List<Double> NumerosGenerados;
        public int modoSeleccionado;

        public double Plambda;

        private int intervalos;


        //solo para uniforme 
        private Double limInf;
        private Double limSup;


        // solución para pasar la matriz contada a la pantalla 
        private double[,] contadas;

        //solo para exponencial
        private double mediaE;
        private int gradosLibertad;
        
        public GestorDeCalculos(List<Double> doubles, int modo, double media) 
        {
            NumerosGenerados= doubles;
            modoSeleccionado = modo;
            mediaE = media;


            // carga la pantalla 
            PantallaResultados pantallaResultados = new PantallaResultados(NumerosGenerados, this, modo);


            pantallaResultados.Show();

        }


        // la pantalla llama a este punto, setea la cantidad de intervalos 
        public void asignarIntervalos(int intervalo)
        {
            intervalos = intervalo;

            var prueba = PasaPrueba(NumerosGenerados, modoSeleccionado); // devuelve el valor de chi

            if(modoSeleccionado == 4)
            {
                generarPantallaHistogramaPoisson(contadas, prueba, NumerosGenerados.Count());
            }
            else
            {
                generarPantallaHistograma(contadas, prueba, NumerosGenerados.Count());
            }
            

        }



        // esto es solo para la uniforme, no creo que les haga falta setear los intervalos en sí 
        public void SetIntervalos(Double sup,Double inf)
        {
            limSup = sup;
            limInf = inf;

        }


        /// modo seleccionado proviene desde el generador, se le pasa que se va calcular 1= unif, 2= normal, 3 = exp, 4= poisson
        private double PasaPrueba(List<double> numerosGenerados, int modoSeleccionado)
        {
            double chiCalculado = 0;
            // uniforme 

            if (modoSeleccionado == 1)
            {
                var contador = new Contar();

                var matriz = contador.ContarEntreIntervalosParaUniforme(NumerosGenerados, intervalos, limInf, limSup);

                //asigno a la global para darle visibilidad a la pantalla 

                double[,] freqEsperada = new double[matriz.GetLength(0), 4];
                contadas = freqEsperada;

                //calcular probabilidad del intervalo 

                double prob = (matriz[0, 1] - limInf) / (limSup - limInf);

                double acumulador = 0;

                for (int i = 0; i < intervalos; i++)
                { 
                    // selecciona columnas 
                    for (int j = 0; j < 4; j++)
                    {
                            //
                        if (j == 0 || j==1 )
                        {
                                freqEsperada[i, j] = matriz[i, j];
                        }
                        /// freq observada 
                        if (j == 2)
                        {
                                freqEsperada[i,j] = matriz[i,j];
                                acumulador += matriz[i,j];
                        }
                    }
                }
                for (int i = 0; i < intervalos; i++)
                {
                    // selecciona columnas 
                    for (int j = 0; j < 4; j++)
                    {
                        if (j == 3)
                        {
                            freqEsperada[i, j] = acumulador * prob;
                        }
                    }
                }



                chiCalculado = ValidarChiKS(freqEsperada, numerosGenerados.Count());

                contadas = freqEsperada;
                gradosLibertad = gradosLibertad - 2;
            }

            if (modoSeleccionado == 2) { 


                //Obtengo de Program las variables que declare
                float deviation = Program.deviation;

                float media = Program.mediaN;


                ///// Metodos de gabi para obtener intervalos y frecuencia observada //////////////
                

                var contador = new Contar();

                var matriz = contador.contarEntreIntervalos(NumerosGenerados, intervalos);


                ////////////////////////////////////////////////////////////////////////////
                

                //// Metodos propios para obtener la matriz que tiene la freucencia esperada que sera usada en prueba chi //////////
                

                var helper = new ChiCuadrado();

                var matrizCompleta = helper.DevolverMatrizChi(matriz,media,deviation, numerosGenerados.Count);


                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



                /// Aca hago la conexion con los metodos definidos de gabi para la prueba chi ///////////////////////////////////////

                //Determina si corresponde Chi o KS y lo hace
                chiCalculado = ValidarChiKS(matrizCompleta, numerosGenerados.Count());

                contadas = matrizCompleta;
                gradosLibertad = gradosLibertad - 2;




            }


            if (modoSeleccionado == 3)
            {
                var contador = new Contar();

                var matriz = contador.contarEntreIntervalos(NumerosGenerados, intervalos);

                double[,] matrizCompleta = new double[matriz.GetLength(0), 4];

                //recorremos filas de la matriz
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    //recorremos columnas de la matriz
                    for (int j = 0; j < 4; j++)
                    {
                        double prob = (1 - Math.Exp(-(1 / mediaE) * matriz[i, 1])) - (1 - Math.Exp(-(1 / mediaE) * matriz[i, 0]));

                        if (j == 0 || j == 1)
                        {
                            matrizCompleta[i, j] = matriz[i, j];
                        }
                        /// freq observada 
                        if (j == 2)
                        {
                            matrizCompleta[i, j] = matriz[i, j];
                        }
                        if (j == 3)
                        {
                            matrizCompleta[i, j] = prob * (numerosGenerados.Count);
                        }
                    }
                }


                //Determina si corresponde Chi o KS y lo hace
                chiCalculado = ValidarChiKS(matrizCompleta, numerosGenerados.Count());              

                contadas = matrizCompleta;
                gradosLibertad = gradosLibertad - 2;

            }

            if (modoSeleccionado == 4)
            {

                var contador = new Contar();

                var matriz = contador.CountOccurrences(numerosGenerados);

                double[,] matrizCompleta = new double[matriz.GetLength(0), 4];


                for (int i = 0; i < matriz.GetLength(0); i++)
                {

                    for (int j = 0; j < 4; j++)
                    {

                        if (j == 0 )
                        {
                            matrizCompleta[i, j] = matriz[i, 0];
                        }
                        if (j==1)
                        {
                            matrizCompleta[i, j] = 0;
                        }

                        if (j == 2)
                        {
                            matrizCompleta[i, j] = matriz[i, 1] ;
                        }
                        if (j == 3)
                        {
                            int k = (int)matriz[i, 0];

                            double prob = Math.Exp(-Plambda) * Math.Pow(Plambda, k) / Factorial(k);

                            matrizCompleta[i, j] = Math.Round(prob * (NumerosGenerados.Count));
                        }
                    }
                }


                //Determina si corresponde Chi o KS y lo hace
                chiCalculado = ValidarChiKS(matrizCompleta, numerosGenerados.Count());

                contadas = matrizCompleta;
                gradosLibertad = gradosLibertad - 2;
            }

            return  chiCalculado;
        }


        public void generarPantallaHistograma(double[,] freqEsperada, double valorCalculado, int tamaño)
        {
            var pant = new PantallaHistogramaChi(freqEsperada, valorCalculado, tamaño, gradosLibertad);
            pant.ShowDialog();
        }

        public void generarPantallaHistogramaPoisson(double[,] freqEsperada, double valorCalculado, int tamaño)
        {
            var pant = new PantallaResultadoPoisson(freqEsperada, valorCalculado, tamaño, gradosLibertad);
            pant.ShowDialog();
        }


        public double ValidarChiKS(double[,] matrizCompleta, int n)
        {
            
            double valorCalculado = 0;

            Contar contador = new Contar();

            if (n >= 10 && n <= 30 && modoSeleccionado != 4)
            {
                valorCalculado = contador.PruebaKS(matrizCompleta, NumerosGenerados.Count());
                //Determina el k
                gradosLibertad = matrizCompleta.GetLength(0);
            }
            else if (n > 30 || modoSeleccionado == 4)
            {

                double[] chi = contador.PruebaChi(matrizCompleta);

                //Determinamos el k
                gradosLibertad = Convert.ToInt32(chi[1]);
                valorCalculado = chi[0];

                
            }

            return valorCalculado;
        }

        private static double Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

    }
}
