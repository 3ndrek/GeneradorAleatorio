using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorAleatorio.Helpers.Distribucion_Poisson
{
    internal class probabilidad
    {

        public double[,] probabilidadYesperadas(double[,] matriz, double lambda, double cantidadMuestras)
        {
            var matrizRetorno = new double[matriz.GetLength(0),4];

            for (var i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j <4 ; j++)
                {
                    if (j ==0 )
                    {
                        matrizRetorno[i, j] = matriz[i, j];
                    }

                    if (j==2)
                    {
                        matrizRetorno[i, j] = matriz[i, 1];
                    }

                    if (j ==1 )
                    {
                        matrizRetorno[i, j] = 0 ;
                    }

                    if (j == 3) 
                    {
                        matrizRetorno[i,j]= Math.Round((( (Math.Pow(lambda , matriz[i,0]) * Math.Exp(-lambda) ) / this.Factorial(matriz[i,0]) )) * cantidadMuestras,0) ;

                    }



                }
            }

            return matrizRetorno;

        }

        public double Factorial(double n)
        {
            double result = 1;
            for (double i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }



    }
}
