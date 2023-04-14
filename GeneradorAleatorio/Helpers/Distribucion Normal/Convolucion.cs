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

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[4];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < 12; j++)
                    {
                        rng.GetBytes(buffer);
                        double randomNumber = (double)BitConverter.ToUInt32(buffer, 0) / UInt32.MaxValue;
                        acum += randomNumber;
                        
                    }

                    double number = (acum - 6) * deviation + media;

                    numeros.Add(number);
                    acum = 0;
                }
            }

            return numeros;


        }
    }
}
