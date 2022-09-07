using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "2 Números Variáveis";
            //aritimetica básica
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine($"[Variável 1 = {a}] [Variável 2 = {b}] ");
            Console.WriteLine("Soma: " + c);
            c = a - b;
            Console.WriteLine("Subtração: " + c);
            c = a * b;
            Console.WriteLine("Multiplicação: " + c);
            c = a / b;
            Console.WriteLine("Divisão: " + c);
            //prioriridades = matemática (mul antes, () antes,  e etc)
            int d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine("Prioridades: " + d);
            //divisão restos e quocioente
            a = 7;
            b = 4;
            d = (a + b) / 3;
            int e = (a + b) % 3;
            Console.WriteLine("Valor do quociente da divisão de (4+7) / 3: " + d);
            Console.WriteLine("Valor do resto da divisão de (4+7) / 3: " + e);
            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"O range de valores inteiros é {min} to {max}");
            int what = max + 3;
            Console.WriteLine($"Um exemplo de overflow, somando o valor máximo + 3: {what}");
            Console.WriteLine("Acima, percebe-se que o valor é próximo do mínimo negativo, pois ao atingir overflow do número máximo, o programa volta a contar do mínimo negativo");
            //número pi e double
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Valor da área utilizando o PI: " + area);
            //decimal, double e float já foram citados em outros exemplos 



            Console.ReadKey();
        }
    }
}
