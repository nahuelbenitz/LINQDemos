using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemos.Utils
{
    public class Printer
    {
        public static void Print(int data)
        {
            Console.WriteLine(data);
        }
        public static void Print(IEnumerable<string> data)
        {
            // Verificamos que hay datos para imprimir
            if (data == null || !data.Any())
            {
                Console.WriteLine("No hay datos para mostrar.");
                return;
            }

            // Calculamos la longitud máxima de los elementos para definir el ancho de la columna
            int maxLength = data.Max(item => item.Length) + 2; // +2 para espacio adicional a cada lado

            // Creamos una línea separadora con asteriscos
            string separator = new string('*', maxLength + 4); // +4 por los bordes laterales

            // Imprimimos un encabezado (opcional)
            Console.WriteLine(separator);
            Console.WriteLine($"* {"Elemento".PadRight(maxLength, ' ')} *");
            Console.WriteLine(separator);

            // Imprimimos cada elemento en una fila de la tabla
            foreach (var item in data)
            {
                string paddedItem = $"* {item.PadRight(maxLength, ' ')} *";
                Console.WriteLine(paddedItem);
            }

            // Imprimimos la línea separadora al final
            Console.WriteLine(separator);
        }
    }
}
