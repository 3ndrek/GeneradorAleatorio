using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorAleatorio.Helpers.Distribucion_Normal
{
    internal class ChiCuadrado


    {

        private double[,] GenerarMarcaDeClase(double[,] matriz) {

            double[,] matrizConMarca = new double[matriz.GetLength(0), 4];

       

            // Copio los valores que tenia la matriz original y le agrego la nueva colummna de marca de clase

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                // Obtengo los valores desde y hasta para usarlos en el calculo
                double desde = matriz[i, 0];
                double hasta = matriz[i, 1];

                // Copio los valores respectivos de la matriz original a la matriz con marca 
                matrizConMarca[i, 0] = desde;
                matrizConMarca[i, 1] = hasta;
                matrizConMarca[i, 2] = matriz[i, 2];

                // Efectúo cálculo de marca de clase y lo asigno a la nueva columna
                double marcaClase = (desde + hasta) / 2;
                matrizConMarca[i, 3] = marcaClase;
            }

                     
            // Devuelvo la matriz original mas la marca de clase
            return matrizConMarca;

        }

        private double[,] GenerarMatrizConProbabilidadYFrecuencia(double[,] matriz, float media, float deviation, int n)
        {
            // Genero nueva matriz que agrega dos columnas mas a la anterior teniendo probabilidad y frecuencia esperada
            double[,] matrizConFrecuencia = new double[matriz.GetLength(0), 6];

           
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                //La idea es que voy por fila, entonces hago un for interno por cada fila que recorre todas las columnas asi tengo los datos de la matriz que me pasan por parametro y le asigno lo que queda
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matrizConFrecuencia[i, j] = matriz[i, j];
                }


                // Asigno variables que voy a necesitar para calcular la probabilidad
                double marca = matriz[i, 3];
                double x = (marca - media) / deviation;

                double desde = matriz[i, 0];
                double hasta = matriz[i, 1];


                // Agregar el valor de la probabilidad a la columna 5 que es una de las dos que agregue
                matrizConFrecuencia[i, 4] =(( Math.Pow(Math.E, -0.5*( Math.Pow(x, 2))) ) / deviation * Math.Sqrt(2 * Math.PI)) * (hasta - desde );


                // Agregar el valor de la frecuencia esperada a la columna 6 que surge de multiplicar [i,4] que es la columna que calcule recien (de probabilidad) por la cantidad de muestra
                matrizConFrecuencia[i, 5] = matrizConFrecuencia[i,4] * n;

            }

            

            return matrizConFrecuencia;

        }

        private double[,] EliminarMarcaClaseYProbabilidad(double[,] matriz)
        {

            
     

            // Definimos una nueva matriz con una columna menos que la original
            double[,] matrizNueva = new double[matriz.GetLength(0), matriz.GetLength(1) - 2];

            // Copiamos todos los valores excepto los de las columnas 4 y 5
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                //  nuevaColumna me sirve para decir el numero de columna que estoy agregando mas adelante
                int nuevaColumna = 0;


                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (j != 3 && j != 4)
                    {
                        matrizNueva[i, nuevaColumna] = matriz[i, j];
                        //sumo 1 a nueva columna para que en la siguiente vuelta asigne un numero a esa columna sigueinte
                        nuevaColumna++;
                    }
                }
            }

            // La matrizNueva tendrá las columnas 4 y 5 eliminadas



            return matrizNueva;

        }



        public double[,] DevolverMatrizChi(double[,] matriz, float mediaN, float deviation, int n)
        {

            //Divido mi metodo en trs partes para facilitar lectura, comprension y responsabilidad unica 


            //Genero una matriz que es copia de la original agregando la columna de la marca de clase
            double[,] matrizConMarca = GenerarMarcaDeClase(matriz);



            //Genero una matriz que es copia de la anterior que tiene la marca de clase y le agrego la frecuencia esperada y probabilidad
            double[,] matrizCompleta = GenerarMatrizConProbabilidadYFrecuencia(matrizConMarca, mediaN, deviation, n);



            // Genero una matriz que es copia de la completa pero le elimino la columna marca de clase y probabilidad para que sea compatible con la exponencial negativa de las chicas y usar sus mismos metodos
            double[,] matrizFinal = EliminarMarcaClaseYProbabilidad(matrizCompleta);

            return matrizFinal;
        }
    }
}
