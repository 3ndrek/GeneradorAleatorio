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


        public GestorDeCalculos(List<Double> doubles, int modo ) 
        {
            NumerosGenerados= doubles;
            modoSeleccionado = modo;


            PantallaResultados pantallaResultados = new PantallaResultados(NumerosGenerados, this);
            pantallaResultados.Show();

        }

        public void asignarIntervalos(int intervalo)
        {
            intervalos = intervalo;
            var contador = new Contar();

            var matriz = contador.contarEntreIntervalos(NumerosGenerados,intervalos);

        }







        private int PasaPrueba(List<double> numerosGenerados, int modoSeleccionado)
        {
            // uniforme 
            if (modoSeleccionado==1 )
            {
                
            }


            return  0;
        }
    }
}
