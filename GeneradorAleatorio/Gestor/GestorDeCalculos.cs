using GeneradorAleatorio.Contador;
using GeneradorAleatorio.Pantallas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneradorAleatorio.Gestor
{
    public class GestorDeCalculos

    {
        public List<Double> NumerosGenerados;
        public int modoSeleccionado;

        private int intervalos;


        //solo para uniforme 
        private int limInf;
        private int limSup;


        // solución para pasar la matriz contada a la pantalla 
        private double[,] contadas;

        //solo para exponencial
        private double mediaE;
        
        public GestorDeCalculos(List<Double> doubles, int modo, double media) 
        {
            NumerosGenerados= doubles;
            modoSeleccionado = modo;
            mediaE = media;


            // carga la pantalla 
            PantallaResultados pantallaResultados = new PantallaResultados(NumerosGenerados, this);


            pantallaResultados.Show();

        }


        // la pantalla llama a este punto, setea la cantidad de intervalos 
        public void asignarIntervalos(int intervalo)
        {
            intervalos = intervalo;

            var prueba = PasaPrueba(NumerosGenerados, modoSeleccionado); // devuelve el valor de chi

            generarPantallaHistograma(contadas);

        }



        // esto es solo para la uniforme, no creo que les haga falta setear los intervalos en sí 
        public void SetIntervalos(int sup, int inf)
        {
            limSup = sup;
            limInf = inf;

        }


        /// modo seleccionado proviene desde el generador, se le pasa que se va calcular 1= unif, 2= normal, 3 = exp, 4= poisson
        private double PasaPrueba(List<double> numerosGenerados, int modoSeleccionado)
        {
            double chiCalculado = 0;
            // uniforme 

            if (modoSeleccionado==1 )
            {
                var contador = new Contar();

                var matriz = contador.ContarEntreIntervalosParaUniforme(NumerosGenerados, intervalos,limInf,limSup );
                
                //asigno a la global para darle visibilidad a la pantalla 

                double[,] freqEsperada = new double[matriz.GetLength(0), 4];
                contadas = freqEsperada;

                //calcular probabilidad del intervalo 

                double prob = (matriz[0,1]- limInf)/(limSup-limInf);

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
                        if (j==3)
                        {
                            freqEsperada[i, j] = acumulador * prob;
                        }
                    }
                }

                var matrizChi = contador.PruebaChi(freqEsperada);

                for (int i = 0; i < matrizChi.GetLength(0); i++)
                {

                    for (int j = 0; j < 6; j++)
                    {

                        if (j == 4) 
                        {
                            chiCalculado += matrizChi[i, j];
                        }
                    }
                }
            }
            if (modoSeleccionado == 3)
            {
                var contador = new Contar();

                var matriz = contador.contarEntreIntervalos(NumerosGenerados, intervalos);

                double[,] matrizCompleta = new double[matriz.GetLength(0), 5];

                //recorremos filas de la matriz
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    //recorremos columnas de la matriz
                    for(int j = 0; j < 5; j++)
                    {
                        double prob = (1 - Math.Exp(-(1 / mediaE) * matriz[i,1]))- (1 - Math.Exp(-(1 / mediaE) * matriz[i, 0]));

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
                            matrizCompleta[i, j] = prob;
                        }
                        if (j == 4)
                        {
                            matrizCompleta[i, j] = prob * (numerosGenerados.Count);
                        }
                    }
                }

            }
            return  chiCalculado;
        }


        public void generarPantallaHistograma(double[,] freqEsperada)
        {
            var pant = new PantallaHistogramaChi(freqEsperada);
            pant.ShowDialog();
        }



    }
}
