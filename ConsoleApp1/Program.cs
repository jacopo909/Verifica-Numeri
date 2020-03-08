using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                double n = double.Parse(Console.ReadLine());
                int n1 = (int)n;
                if (n == n1)
                {
                    Console.WriteLine("il numero" + (n) + "è un intero");
                }
                else
                {
                    Console.WriteLine("il numero: " + (n) + " non è un intero");
                    n1 = Class1.Arrotondamento(n);
                    if (Class1.Pari_Dispari(n1))
                    {
                        Console.WriteLine("il numero: " + (n1) + " è pari");
                    }
                    else
                    {
                        Console.WriteLine("il numero: " + (n1) + " è dispari");
                    }
                }

            }catch(Exception e)
            {
                Console.WriteLine("si puo inserire solo dei numeri: " + e.Message);
            }
            Console.ReadKey();
        }
    }
}
