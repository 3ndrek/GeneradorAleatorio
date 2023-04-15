using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace GeneradorAleatorio.Helpers.Distribucion_Normal
{
    internal class Convolucion
    {

        public List<double> GenerateConvolution(float media, float deviation, int n) {


            List<double> numeros = new List<double>();

            double acum = 0;

            // El metodo convolucion exige 12 randoms por cada variable aleatoria y que, una vez usados, no se repitan nunca. Entonces para asegurar esto
            // chagpt me sugirio que use un generador criptografico seguro que utiliza variables internas de la computadora para generar los random entonces
            // hace que sea dificil que se repitan.

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                // genero un numero de 4 bytes
                byte[] buffer = new byte[4];


                // Mi metodo de convolucion es que por cada vuelta, adentro hago un nuevo for que me genere 12 numeros random y los vaya acumulando ya que la formula de
                // convolucion es restar la acumulacion menos seis. El resto del codigo se entiende creeria por si mismo
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        rng.GetBytes(buffer);
                        // traduzco el numero generador para poder usarlo como random
                        double randomNumber = (double)BitConverter.ToUInt32(buffer, 0) / UInt32.MaxValue;
                        acum += randomNumber;
                        
                    }

                    double number = (acum - 6) * deviation + media;

                    numeros.Add(number);

                    // Reinicio mi acumulador para la siguiente variable aleatoria
                    acum = 0;
                }
            }

            return numeros;


        }
    }
}
