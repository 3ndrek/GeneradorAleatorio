using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorAleatorio.Contador
{
    public class Contar
    {
        private double feChi;
        private double foChi;
        private double feChiViejo;
        private double foChiViejo;
        private double cAcumViejo;
        private double cViejo;
        private double cAcum;
        private int intervalosChi;

        public Contar()
        {
            feChi = 0;
            foChi = 0;
            cAcum = 0;
            intervalosChi = 0;
        }

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


            double ancho = ((maximo - minimo) / intervalos) + 0.0001 ;
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
        public double[,] ContarEntreIntervalosParaUniforme(List<Double> numeros, int intervalos, Double min, Double max)
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


        public double[] PruebaChi(double[,] matrizFoFe)
        {
            double[] chi = new double[2]; 
            int cantLineas = 0;

            for (int i = 0; i < matrizFoFe.GetLength(0); i++)
            {
                cantLineas++;
                calcularCoeficiente(matrizFoFe[i, 2], matrizFoFe[i, 3], cantLineas, matrizFoFe.GetLength(0));
            }

            chi[0] = cAcum; 
            chi[1] = intervalosChi;

            return chi;
        }

        private void calcularCoeficiente(double fo, double fe, int cantLineas, int cantIntervalos)
        {
            double c;
            feChi += fe;
            foChi += fo;
            if (feChi >= 5)
            {
                c = ((Math.Pow((feChi - foChi), 2) / feChi));
                cAcum += c;
                intervalosChi++;
                cAcumViejo = cAcum;
                feChiViejo = feChi;
                foChiViejo = foChi;
                cViejo = c;
                feChi = 0;
                foChi = 0;
            }
            if (cantLineas == cantIntervalos)
            {
                c = ((Math.Pow(((feChi + feChiViejo) - (foChi + foChiViejo)), 2) /
                    (feChi + feChiViejo)));
                cAcum -= cViejo;
                cAcum += c;
                feChi = 0;
                foChi = 0;
            }
        }

        //Método KS
        public double PruebaKS(double[,] matriz, int n)
        {
            double[,] matrizKS = new double[matriz.GetLength(0), 6];
            double valorCalculado = 0;

            for (int i = 0; i < matrizKS.GetLength(0); i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    if(j == 0)
                    {
                        //Cálculo de probabilidad observada
                        matrizKS[i, j] = matriz[i, 2] / n;
                    }
                    if(j == 1)
                    {
                        //Cálculo de probabilidad esperada
                        matrizKS[i, j] = matriz[i, 3] / n;

                    }
                    if(j == 2)
                    {
                        //Cálculo de probabilidad observada acumulada
                        matrizKS[i,j] += matrizKS[i, 0];
                    }
                    if(j == 3)
                    {
                        //Cálculo de probabilidad esperada acumulada
                        matrizKS[i, j] += matrizKS[i, 1];
                    }
                    if(j == 4)
                    {
                        //Cálculo de diferencia absoluta entre probabilidades acumuladas
                        matrizKS[i, j] = Math.Abs(matrizKS[i, 2] - matrizKS[i, 3]);
                    }
                    if(j == 5)
                    {
                        if(valorCalculado < matrizKS[i, 4])
                        {
                            valorCalculado = matrizKS[i, 4];
                        }
                    }
                }
            }

            return valorCalculado;
        }


        // contar cuantas veces ocurre algo para poisson 

        public double[,] CountOccurrences(List<double> numbers)
        {
            // Obtener una lista de números únicos
            List<double> uniqueNumbers = numbers.Distinct().ToList();

            // Crear la matriz para almacenar los conteos
            double[,] result = new double[uniqueNumbers.Count, 2];

            // Recorrer los números únicos y contar cuántas veces aparece cada uno en la lista
            for (int i = 0; i < uniqueNumbers.Count; i++)
            {
                double count = 0;
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (uniqueNumbers[i] == numbers[j])
                    {
                        count++;
                    }
                }
                result[i, 0] = uniqueNumbers[i];
                result[i, 1] = count;
            }

            // Devolver la matriz de conteos
            return result;
        }


    }
}

