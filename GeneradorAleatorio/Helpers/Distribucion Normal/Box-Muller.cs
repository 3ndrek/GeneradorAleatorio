using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GeneradorAleatorio.Helpers.Distribucion_Normal
{
    internal class Box_Muller
    {

        public List<double> GenerateBoxMuller(float media, float deviation, int n) {

            List<double> numeros = new List<double>();

            var rand1 = new Random();
          
            double actualRand1 = 0;
            double actualRand2 = 0;


    
            // El metodo box muller genera valores aletorias de a pares, entonces deberia dar n/2 vueltas en teoria para que si le mando que genere 100 numeros, no haga 100 vueltas y genere 200
            // pero aplico un ternario porque si le pido una cantidad impar como 101 tendria que redondear o truncar, entonces lo que hago es restarle 1 para que quede par, luego dividir por 2
            // y al resultado le sumo 1, entonces 101 - 1 = 100 / 2 =  50 +1 = 51 * 2 = 102 numeros
            int vueltas = n % 2 == 0 ? n / 2 : (((n-1) / 2) + 1);



            for (int i = 0; i < vueltas; i++)
            {
               
                    // Genero par de randoms
                    actualRand1 = rand1.NextDouble();
                    actualRand2 = rand1.NextDouble();

                // Genero las variables aleatorias
                float number1 = (float)(Math.Sqrt(-2 * Math.Log(actualRand1)) * Math.Cos(2 * Math.PI * actualRand2) * deviation + media);
                float number2 = (float)(Math.Sqrt(-2 * Math.Log(actualRand1)) * Math.Sin(2 * Math.PI * actualRand2) * deviation + media);

          
                //Los agrego al arreglo
                numeros.Add(number1);
                numeros.Add(number2);

            }

            // Como genere 102 numeros (siguiendo el ejemplo del codigo comentario anterior)
            // porque el calculo para vueltas impares arroja en si un numero par simplemente
            // remuevo el ultimo, entonces en vez de tener 102, tengo los 101 solicitados
            if (n % 2 != 0) {

                int lastIndex = numeros.Count - 1;
                numeros.RemoveAt(lastIndex);
            }

          
            // Devuelvo los numeros calculados
            return numeros;
            
        }
    }
}
