using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Clases_SV;
namespace Ejecucion_SV
{
   public class Program
    {
        public static void Main(string[] args)
         
        {
            AA aA = new AA(); // Crear una instancia de la clase AA
            Console.WriteLine("Bienvenido a la tienda de ventas de artículos");
            Console.WriteLine("                                                                              ");
            Console.WriteLine("A continuación se mostrarán las ventas de cada artículo durante la semana:    ");
            Console.WriteLine("                                                                              ");
            Console.WriteLine(
                "Artículo 1: 153, 161, 15, 153, 132, 76, 73\n" +  
                "Artículo 2: 108, 199, 27, 177, 181, 122, 53\n" +
                "Artículo 3: 157, 62, 92, 186, 13, 81, 160\n" +
                "Artículo 4: 90, 163, 76, 43, 49, 135,159\n" +
                "Artículo 5: 37 ,32 ,146 ,63 ,80 ,157 ,154\n" +
                "Artículo 6:180 ,52 ,89 ,61 ,151 ,109 ,40\n" +
                "Artículo 7:108 ,99 ,165 ,186 ,29 ,165 ,31");

            Console.WriteLine("                                                                              ");

            Console.WriteLine("Preciona la siguuiente tecla para mostrar las ventas");
            Console.ReadKey(); // Espera a que el usuario presione una tecla antes de continuar
            Console.Clear(); // Limpia la consola para mostrar los resultados de las sumatorias
            Console.WriteLine("                                                                              ");
            Console.WriteLine("Bienvenido a la tienda de ventas de artículos"); // Mensaje de bienvenida
            Console.WriteLine("                                                                              ");
           Console.WriteLine(
                "A continuación se mostrarán las sumatorias diarias de ventas durante la semana:");
            int[,] ventas = new int[7, 7]; // Matriz de ventas de artículos
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            ventas[0, 0] = 153; ventas[0, 1] = 161; ventas[0, 2] = 15; ventas[0, 3] = 153; ventas[0, 4] = 132; ventas[0, 5] = 76; ventas[0, 6] = 73; // Inicializar la matriz con las ventas de cada artículo durante una semana
            ventas[1, 0] = 108; ventas[1, 1] = 199; ventas[1, 2] = 27; ventas[1, 3] = 177; ventas[1, 4] = 181; ventas[1, 5] = 122; ventas[1, 6] = 53;
            ventas[2, 0] = 157; ventas[2, 1] = 62; ventas[2, 2] = 92; ventas[2, 3] = 186; ventas[2, 4] = 13; ventas[2, 5] = 81; ventas[2, 6] = 160;
            ventas[3, 0] = 90; ventas[3, 1] = 163; ventas[3, 2] = 76; ventas[3, 3] = 43; ventas[3, 4] = 49; ventas[3, 5] = 135; ventas[3, 6] = 159;
            ventas[4, 0] = 37; ventas[4, 1] = 32; ventas[4, 2] = 146; ventas[4, 3] = 63; ventas[4, 4] = 80; ventas[4, 5] = 157; ventas[4, 6] = 154;
            ventas[5, 0] = 180; ventas[5, 1] = 52; ventas[5, 2] = 89; ventas[5, 3] = 61; ventas[5, 4] = 151; ventas[5, 5] = 109; ventas[5, 6] = 40;
            ventas[6, 0] = 108; ventas[6, 1] = 99; ventas[6, 2] = 165; ventas[6, 3] = 186; ventas[6, 4] = 29; ventas[6, 5] = 165; ventas[6, 6] = 31;
            int[] sumatoriaDiaria = new int[7]; // Array para almacenar la sumatoria diaria de ventas
            for (int j = 0; j < ventas.GetLength(1); j++)

            {
                for (int i = 0; i < ventas.GetLength(0); i++)
                {
                    sumatoriaDiaria[j] += ventas[i, j];
                }
                Console.WriteLine($"Ventas del día {j + 1}: {sumatoriaDiaria[j]} unidades");
                Console.WriteLine();
            }



        }

    }

}

