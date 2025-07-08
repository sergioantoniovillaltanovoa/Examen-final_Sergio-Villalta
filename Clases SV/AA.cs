using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases_SV;    

namespace Clases_SV
{
    public class AA
    // Una tienda ha registrado durante una semana completa las ventas diarias de siete artículos. La información ha sido organizada en la siguiente matriz, donde cada fila representa un artículo y cada columna indica la cantidad de unidades vendidas en un día específico desde el lunes hasta el domingo.
    // -Sumatoria diaria de ventas durante la semana
    {
        public static void Main(string[] args)

        {

            int[,] ventas = new int[7, 7] // Matriz de ventas de artículos
                                          // Inicializar la matriz con las ventas de cada artículo durante una semana



            {

                { 153, 161, 15, 153, 132, 76, 73 }, // Artículo 1
                { 108 , 199, 27, 177, 181, 122, 53 }, // Artículo 2
                { 157, 62, 92, 186, 13, 81, 160 }, // Artículo 3
                { 90, 163, 76, 43, 49, 135,159  }, // Artículo 4
                { 37 , 32, 146, 63, 80, 157, 154 }, // Artículo 5
                { 180, 52, 89, 61, 151, 109, 40 }, // Artículo 6
                { 108, 99, 165, 186, 29, 165,31 } // Artículo 7

            };
            for (int i = 0; i < ventas.GetLength(0); i++)   // Inicializar la primera columna a cero


            {
                for (int j = 0; j < ventas.GetLength(1); j++) // Recorre cada fila y columna de la matriz

                {
                    Console.Write(ventas[i, j] + " "); // Imprime el valor de cada elemento de la matriz

                }
                Console.WriteLine();

            }
        }
    }
}
