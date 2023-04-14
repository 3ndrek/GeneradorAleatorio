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


    

            int vueltas = n % 2 == 0 ? n / 2 : (n-1 / 2) + 1;

            for (int i = 0; i < vueltas; i++)
            {
               
                    actualRand1 = rand1.NextDouble();
                    actualRand2 = rand1.NextDouble();


                float number1 = (float)(Math.Sqrt(-2 * Math.Log(actualRand1)) * Math.Cos(2 * Math.PI * actualRand2) * deviation + media);
                float number2 = (float)(Math.Sqrt(-2 * Math.Log(actualRand1) * Math.Sin(2 * Math.PI * actualRand2) * deviation + media));

          

                numeros.Add(number1);
                numeros.Add(number2);

            }

            if (n % 2 != 0) {

                int lastIndex = numeros.Count - 1;
                numeros.RemoveAt(lastIndex);
            }

          

            return numeros;
            
        }
    }
}
