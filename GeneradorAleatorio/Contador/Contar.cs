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
            foreach (double numero in numeros)
            {
                if (numero >= min && numero <= max)
                {
                    contador++;
                }
            }
            return contador;
        }


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

                for (int j = 0; j <4 ; j++)
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









    }
}
