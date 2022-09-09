using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_3_Conditions
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "1st chalange";

            Console.WriteLine("Digite seu nome: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite o nome da sua cidade: ");
            string city = Console.ReadLine();
            Console.WriteLine($"\n\n\nBem vindo {name}, morador da cidade {city}.");

            Console.ReadKey();
        }
    }
}
