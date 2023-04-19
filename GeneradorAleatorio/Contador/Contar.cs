using GeneradorAleatorio.Entidades;
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


            double ancho = ((maximo - minimo) / intervalos) + 0.0001;
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

        /* Código de sol 
         * 
         * 
        // Metodo que se encarga de reducir los intervalos para la prueba Ji Cuadrado
        public List<Intervalo> reducir(int distro)
        {
            // Los intervalos que tengo 
            List<Intervalo> aux = new List<Intervalo>();

            // Los que voy a obtener, reducidos
            List<Intervalo> reducidos = new List<Intervalo>();
            int prueba = 0;
            // Recorro los intervalos que tengo
            for (int i = 0; i < intervalos.Count; i++)
            {
                // Si la FE es mayor a 5
                if (intervalos[i].frecuenciaEsperada > 5)
                {
                    reducidos.Add(aux[i]);
                    prueba++;
                }
                else
                {
                    // Si no estoy en el 
                    if (i + 1 != intervalos.Count)
                    {
                        int cantidadPruebas = 0;
                        for (int j = i + 1; j < intervalos.Count; j++)
                        {

                            if (distro < 2)
                            {
                                aux[i].fusionarIntervalo(aux[j]);
                            }
                            else
                            {
                                ((ValorPoisson)aux[i]).fusionarIntervalo(aux[j]);
                            }

                            if (aux[i].frecuenciaEsperada > 5)
                            {
                                reducidos.Add(aux[i]);
                                cantidadPruebas += 2;

                                prueba += cantidadPruebas;
                                i = j;
                                break;
                            }
                            else
                            {
                                cantidadPruebas++;
                            }
                        }
                    }
                }
            }
            int faltantes = (this.intervalos.Count - prueba);
            if (faltantes > 0)
            {
                if (distro < 2)
                {
                    reducidos[reducidos.Count - 1].fusionarIntervalo(aux[intervalos.Count - faltantes]);
                }
                else
                {
                    ((ValorPoisson)reducidos[reducidos.Count - 1]).fusionarIntervalo(aux[intervalos.Count - faltantes]);
                }

            }

            return reducidos;
        }

        public void fusionarIntervalo(Intervalo i)
        {

            LimInf = (this.limInf < i.limInf) ? this.limInf : i.limInf;
            limSup = (this.limSup > i.limSup) ? this.limSup : i.limSup;


            this.frecuenciaAbsoluta += i.frecuenciaAbsoluta;
            this.frecuenciaEsperada += i.frecuenciaEsperada;
        }

        public void fusionarIntervalo(Intervalo i)
        {
            ValorPoisson valor = (ValorPoisson)i;
            frecuenciaAbsoluta += valor.frecuenciaAbsoluta;
            frecuenciaEsperada += valor.frecuenciaEsperada;

            this.titulo = titulo + ", " + ((ValorPoisson)i).valor;

        }

        */

        public double[,] PruebaChi(double[,] matrizFoFe)
        {

            double[,] matrizChi = new double[matrizFoFe.GetLength(0), 5];
            double[,] Analizar = acumularMatriz(matrizFoFe);

            for (int i = 0; i < Analizar.GetLength(0); i++)
            {

                for (int j = 0; j < 6; j++)
                {
                    if (j <= 3)
                    {
                        matrizChi[i, j] = Analizar[i, j];
                    }

                    if (j == 4)
                    {
                        matrizChi[i, j] = (Math.Pow((Analizar[i, 2] - Analizar[i, 3]), 2)) / Analizar[i, 3];

                    }
                }
            }

            return matrizChi;
        }

        //Método KS
        public double PruebaKS(double[,] matriz, int n)
        {
            double[,] matrizKS = new double[matriz.GetLength(0), 6];
            double valorCalculado = 0;

            for (int i = 0; i < matrizKS.GetLength(0); i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 0)
                    {
                        //Cálculo de probabilidad observada
                        matrizKS[i, j] = matriz[i, 2] / n;
                    }
                    if (j == 1)
                    {
                        //Cálculo de probabilidad esperada
                        matrizKS[i, j] = matriz[i, 3] / n;

                    }
                    if (j == 2)
                    {
                        //Cálculo de probabilidad observada acumulada
                        matrizKS[i, j] += matrizKS[i, 0];
                    }
                    if (j == 3)
                    {
                        //Cálculo de probabilidad esperada acumulada
                        matrizKS[i, j] += matrizKS[i, 1];
                    }
                    if (j == 4)
                    {
                        //Cálculo de diferencia absoluta entre probabilidades acumuladas
                        matrizKS[i, j] = Math.Abs(matrizKS[i, 2] - matrizKS[i, 3]);
                    }
                    if (j == 5)
                    {
                        if (valorCalculado < matrizKS[i, 4])
                        {
                            valorCalculado = matrizKS[i, 4];
                        }
                    }
                }
            }

            return valorCalculado;
        }

        public double[,] ContarPoisson(List<double> numbers)
        {
            // Obtener una lista de números únicos
            List<double> uniqueNumbers = numbers.Distinct().ToList();

            // Crear la matriz para almacenar los conteos
            double[,] result = new double[uniqueNumbers.Count, 2];

            // Recorrer los números únicos y contar cuántas veces aparece cada uno en la lista
            for (int i = 0; i < uniqueNumbers.Count; i++)
            {
                int count = 0;
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


