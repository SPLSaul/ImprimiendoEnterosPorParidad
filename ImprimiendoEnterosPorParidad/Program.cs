using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImprimiendoEnterosPorParidad
{
    internal class Program
    {
        static int N, P;
        static void Main(string[] args)
        {
            Console.Write("Numeros en en arreglo: ");
            N = int.Parse(Console.ReadLine());
            Random random = new Random();
            int[] arreglo = new int[N];            
            for(int i = 0; i < N; i++)
            {
                arreglo[i] = random.Next(0,100);
            }
            Console.WriteLine("Arreglo entero");
            for (int i = 0; i < N; i++) { Console.Write($"{arreglo[i]} "); }
            Console.WriteLine();
            Console.Write("Introduce P: ");
            P = int.Parse(Console.ReadLine());
            Console.ReadKey();

            if (P == 0) { 
                Console.WriteLine("Pares"); 
                for(int i = 0; i < N; i++)
                {
                    if (arreglo[i] % 2 == 0) { Console.WriteLine($"{arreglo[i]} " ); }                    
                }
                Console.WriteLine();
            }
            else if (P == 1) { 
                Console.WriteLine("Impares");
                for (int i = 0; i < N; i++)
                {
                    if (arreglo[i] % 2 >0) { Console.Write($"{arreglo[i]} " ); }
                }
                Console.WriteLine();
            }
            else { Console.WriteLine("No aplica"); }
            Console.ReadKey();          
        }
    }
}
