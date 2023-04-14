using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorAleatorio.Contador
{
    public class Contar
    {
        private int ContarValoresEnIntervalo(List<Double> numeros, double min, double max)
        {
            int contador = 0;

            double valorMax = numeros.Max();

            foreach (double numero in numeros)
            {
                if ((numero >= min && numero < max) || (numero >= min && numero == valorMax)) // creo que toma bien el {) intervalo 
                {
                    contador++;
                }
            }
            return contador;
        }

        /// este busca min y max del arreglo y devuelve la matriz, hay que checkear como cuenta el contar en intervalo, pero creo que está bien 
        public double[,] contarEntreIntervalos(List<Double> numeros, int intervalos)
        {
            double minimo = numeros.Min();
            double maximo = numeros.Max();

            double limIntervalo = minimo;


            double ancho = (maximo - minimo) / intervalos;
            double[,] retorno = new double[intervalos, 3];
            // selecciona fila 

            for (int i = 0; i < intervalos; i++)
            {

                // selecciona columnas 

                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        retorno[i, j] = minimo;
                        limIntervalo = minimo + ancho;
                    }

                    if (j == 1)
                    {
                        retorno[i, j] = limIntervalo;

                    }

                    if (j == 2)
                    {
                        retorno[i, j] = ContarValoresEnIntervalo(numeros, minimo, limIntervalo);

                        minimo = limIntervalo;
                    }

                }

            }


            return retorno;
        }

        // este contador es para uniforme nomás, no hace falta que los usen, no utiliza los intervalos del arreglo del número sino que usa fijos a-b
        public double[,] ContarEntreIntervalosParaUniforme(List<Double> numeros, int intervalos, int min, int max)
        {
            double minimo = min;
            double maximo = max;

            double limIntervalo = minimo;


            double ancho = (maximo - minimo) / intervalos;
            double[,] retorno = new double[intervalos, 3];

            // selecciona fila 

            for (int i = 0; i < intervalos; i++)
            {

                // selecciona columnas 

                for (int j = 0; j < 4; j++)
                {
                    if (j == 0)
                    {
                        retorno[i, j] = minimo;
                        limIntervalo = minimo + ancho;
                    }

                    if (j == 1)
                    {
                        retorno[i, j] = limIntervalo;

                    }

                    if (j == 2)
                    {
                        retorno[i, j] = ContarValoresEnIntervalo(numeros, minimo, limIntervalo);

                        minimo = limIntervalo;
                    }

                }

            }
            return retorno;
        }


        private double[,] BusquedaHastaFondo(double[,] matrizz)
        {
            double[,] retorno = new double[matrizz.GetLength(0), 4];


            double[,] posicionAcumulada = new double[matrizz.GetLength(0), 4];
            double[,] posicionAnterior = new double[matrizz.GetLength(0), 4];

            double[,] matrizMenor5 = new double[matrizz.GetLength(0), 4];



            // armar matriz de < 5, considerando que no puedan venir intervalos salteados 

            int filaanterior = 0;
            for (int i = 0; i < matrizz.GetLength(0); i++)
            {
                filaanterior++;

                if (matrizz[i, 3] < 5)
                {

                    for (int j = 0; j < 4; j++)
                    {
                        matrizMenor5[i, j] = matrizz[i, j];

                        if (filaanterior == 1)
                        {
                            posicionAnterior[1, j] = matrizz[(i - 1), j];
                        }
                    }
                }
            }

            if (matrizMenor5.GetLength(0)==0 )
            {
                return matrizz;
            }

            posicionAcumulada[0, 1] = 0;
            // armamos una matriz de 1 fila que sea acumulada 
            for (int i = 0; i < matrizMenor5.GetLength(0); i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    ///aseguro el intervalo inferior 
                    if (j == 0)
                    {
                        posicionAcumulada[0, 0] = matrizMenor5[0, 0];
                    }

                    if (j == 1)
                    {
                        if (posicionAcumulada[0, 1] < matrizMenor5[i, j])
                        {
                            posicionAcumulada[0, 1] = matrizMenor5[i, j];
                        }
                    }

                    /// sumador de esperadas o observadas
                    if (j == 2 || j == 3)
                    {
                        posicionAcumulada[0, j] += matrizMenor5[i, j];
                    }
                }
            }





            if (posicionAcumulada[0,2]< 5)
            {
                for (int i = 0; i < matrizz.GetLength(0); i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (j==0 )
                        {
                            posicionAcumulada[i, j] = posicionAnterior[i, j];
                        }

                        if (j==2 || j ==3)
                        {
                            posicionAcumulada[i, j] += posicionAnterior[i, j];
                        }
                    }
                       
                }
            }


            bool BRfilaInicio = false;
            bool BRfilafin = false;
            


            for (int i = 0; i < matrizz.GetLength(0); i++)
            {
                    for (int j = 0; j < 4; j++)
                    {
                        if (BRfilafin == false)
                          {


                            if (j == 0)
                        {
                            if (matrizz[i, j] == posicionAcumulada[i, j])
                            {
                                retorno[i, j] = posicionAcumulada[i, j];
                                BRfilaInicio = true;
                            }
                            else
                            {
                                retorno[i, j] = matrizz[i, j];
                            }
                        }
                            if (j == 1 || j == 2)
                        {
                            if (BRfilaInicio)
                            {
                                retorno[i, j] = posicionAcumulada[i, j];
                            }
                            else
                            {
                                retorno[i, j] = matrizz[i, j];
                            }
                        }

                            if (j == 3)
                        {
                            if (BRfilaInicio)
                            {
                                retorno[i, j] = posicionAcumulada[i, j];
                                BRfilafin = true;
                            }
                            else
                            {
                                retorno[i, j] = matrizz[i, j];
                            }
                        }
                          }
                        else
                    {
                        return retorno;
                        break;
                    }
                    }



                
            }

            return retorno;

        }







        public double[,] PruebaChi(double[,] matrizFoFe)
        {


            double[,] matrizChi = new double[matrizFoFe.GetLength(0), 5];
            double[,] Analizar= BusquedaHastaFondo(matrizFoFe);

            for (int i = 0; i < Analizar.GetLength(0); i++)
            {

                for (int j = 0; j < 6; j++)
                {
                    if (j <= 3 )
                    {
                        matrizChi[i, j] = Analizar[i,j];
                    }

                    if (j == 4) /// cambiar tengo el acumulado 
                    {
                        matrizChi[i, j] = (Math.Pow((Analizar[i, 2] - Analizar[i, 3]), 2)) / Analizar[i, 3];

                    }
                }
            }

            return matrizChi;
        }


    }
}

