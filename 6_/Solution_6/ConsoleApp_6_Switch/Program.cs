using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_6_Switch
{

    internal class Program
    {
        static void print(string word) => Console.WriteLine(word);
        static string scan() => Console.ReadLine();
        
        static void makeMenu(int exercises)
        {
            for (int i = 0; i < exercises; i++)
            {
                print($"{i+1} - Exercício {i+i}");
            }
            print("0 - Sair");
        }
        static void Main()
        {
            const string TITLE = "Exercícios _6";
            const string INIT = "Bem vindo ao programa de exercícios! Escolha uma das opções abaixo.";
            const string OTHERS = "Escolha uma das opções abaixo.";
            bool isFst = true; 
            Console.Title = TITLE; 

            while (true)
            {   
                TRY_AGAIN:
                Console.Clear();
                string msg_welcome = isFst ? INIT : OTHERS;
                isFst = false; 
                print(msg_welcome);
                makeMenu(3);
                bool isValid = int.TryParse(scan(), out int option);
                if (!isValid) { 
                    print("Digito inválido, tente novamente...");
                    goto TRY_AGAIN; 
                }
                switch (option)
                {
                    case 0:
                        break;
                    default:
                        print("Opção inválida!");
                        goto FINISH; 
                }
            }

            FINISH:
            print("Adeus...");

        }
    }
}
