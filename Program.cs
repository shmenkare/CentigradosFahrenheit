using System;
using System.Collections.Generic;
using System.Text;

namespace CentigradosFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //V 2.0
            /* 0 grados Celsius es igual a 32 grados Fahrenheit:

            0 ° C = 32 ° F
             La temperatura T en grados Fahrenheit (° F)
             * es igual a la temperatura T en grados Celsius 
             * (° C) multiplicada por 9/5 más 32:

             T (° F) = T (° C) × 9/5 + 32 */

            Console.WriteLine("Convertir Grados centigrados a grados fahrenheit");
            Centigradosafarh();
            
            Console.ReadKey();

         }
        static void Centigradosafarh()
        {
            int gradosC = 0;
            int gradosF = 0;

            Console.WriteLine("Ingresa los grados Centigrados a convertir");
            gradosC = Convert.ToInt32(Console.ReadLine());

            gradosF = gradosC * (9 / 5) + 32;

            Console.WriteLine("{0} grados centigrados son iguales a {1} grados fahrenheit", gradosC, gradosF);

        }

    }
}
