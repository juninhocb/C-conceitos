using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_4_RevConditionals
{
    internal class Program
    {
        static void Main()
        {

            Console.WriteLine("Seja bem vindo ao programa e Esocolha uma opção\n\n");
            Console.WriteLine("1- Exemplo 1");
            Console.WriteLine("2- Exemplo 2");
            Console.WriteLine("----------------");
            Console.WriteLine("0- Sair");
            Int32.TryParse(Console.ReadLine(), out int opcao);

            if (opcao == 1)
            {
                ExRev1();
            }
            else if (opcao == 2)
            {
                ExRev2();
            }


            Console.ReadKey();
        }

        public static void ExRev1()
        {
            Console.WriteLine("***** Programa Exemplo 1 *****");
            Console.WriteLine("***** Gerar 2 números aleatórios (0 - 100) *****");
            Console.WriteLine("***** Mostrar o maior entre eles *****");
            Random random = new Random();
            int nmr1 = random.Next(1, 100);
            int nmr2 = random.Next(1, 100);


            if (nmr1 > nmr2)
            {
                Console.WriteLine($"Número 1 é maior. Numero1 = {nmr1}");
            }
            else if (nmr1 < nmr2)
            {
                Console.WriteLine($"Número 2 é maior. Numero2 = {nmr2}");
            }
            else
            {
                Console.WriteLine("Os dois números são iguais");
            }

        }

        public static void ExRev2()
        {
            Console.Clear();
            Console.WriteLine("***** Programa Exemplo 2 *****");
            Console.WriteLine("***** Gerar 3 números aleatórios (0 - 100) *****");
            Console.WriteLine("***** Escrevê-los em ordem decrescente *****");
            string formatResponse = "Número em ordem decrescentes "; 

            Random random = new Random();
            int nmr1 = random.Next(1, 100);
            int nmr2 = random.Next(1, 100);
            int nmr3 = random.Next(1, 100);

            if (nmr1 < nmr2 &&
                nmr1 < nmr3)
            {
                formatResponse += $"{nmr1}, ";
                if (nmr2 < nmr3)
                {
                    formatResponse += $"{nmr2}, {nmr3}";
                }
                else
                {
                    formatResponse += $"{nmr3}, {nmr2}";
                }
            }
            else if (nmr2 <  nmr1 &&
                    nmr2 < nmr3)
            {
                formatResponse += $"{nmr2}, ";
                if (nmr1 < nmr3)
                {
                    formatResponse += $"{nmr1}, {nmr3}";
                }
                else
                {
                    formatResponse += $"{nmr3}, {nmr1}";
                }
            }
            else
            {
                formatResponse += $"{nmr3}, ";
                if (nmr1 < nmr2)
                {
                    formatResponse += $"{nmr1}, {nmr2}";
                }
                else
                {
                    formatResponse += $"{nmr2}, {nmr1}";
                }
            }

            Console.WriteLine($"Ordem crescente: {formatResponse}");

        }

    }


}
