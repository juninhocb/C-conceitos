using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_3_Conditions
{
    internal class Program
    {

        static void Main()
        {
            Console.Title = "Condicionais - Seletores!";

            Console.WriteLine("Digite\n1 - (SysSchool)\n2 - (exercício 1)\n" +
                "3 - (exercício 2 maior nmr)\n4 - (exercício 2 menor nmr)\n0 - SAIR\n");
            Int32.TryParse(Console.ReadLine(), out int value);
            switch (value)
            {
                case 0:
                    return;
                case 1:
                    Exemplo();
                    break;
                case 2:
                    Ex1();
                    break;
                case 3:
                    Ex2();
                    break;
                case 4:
                    Ex3();
                    break;
                default:
                    break;
            }

            Console.ReadKey();

        }
    
    static void Ex3()
        {   

            Console.WriteLine("Digite quatro valores em sequência, o programa irá retornar o menor valor digitado! ");
            try {
                int resultado = recursivo(recursivo(recursivo(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())), Int32.Parse(Console.ReadLine())), Int32.Parse(Console.ReadLine()));
                Console.WriteLine($"Menor número digitado: {resultado}");
            } catch (Exception e) { 
                Console.WriteLine(e.StackTrace);
            
            };
                    
        }
    static int recursivo(int vlr1, int vlr2)
        {
            return vlr1 <
                vlr2 ? vlr1 : vlr2;
        }
    static void Ex2()
        {
            Console.WriteLine("Exercício 2: Programa que verifica o maior entre quatro valores!!! \n\n");
            Console.WriteLine("Digite o valor para o primeiro valor");
            Int32.TryParse(Console.ReadLine(), out int value1);
            Console.WriteLine("Digite o valor para o segundo valor");
            Int32.TryParse(Console.ReadLine(), out int value2);
            Console.WriteLine("Digite o valor para o terceiro valor");
            Int32.TryParse(Console.ReadLine(), out int value3);
            Console.WriteLine("Digite o valor para o quarto valor");
            Int32.TryParse(Console.ReadLine(), out int value4);

            if (value1 > value2 && value1 > value3 && value1 > value4)
            {
                Console.WriteLine("Valor 1 é o maior número de todos");
            }
            else if (value2 > value3 && value2 > value4)
            {
                Console.WriteLine("Valor 2 é o maior número de todos");
            }
            else if (value3 > value4) {
                Console.WriteLine("Valor 3 é o maior número de todos");
            } else
            {
                Console.WriteLine("Valor 4 é o maior número de todos");
            }
        }
    static void Ex1()
        {
            bool exit = false;
            Console.WriteLine("Digite o valor do primeiro número");
            string numStr = Console.ReadLine();
            

            if (numStr.Equals("") || !Char.IsDigit(numStr[0]))
            {
                exit = true;
                goto Error;
            }

            Console.WriteLine("Digite o valor do segundo número");
            string numStr2 = Console.ReadLine();

            if (numStr.Equals("") || !Char.IsDigit(numStr2[0]))
            {
                exit = true;
                goto Error;
            }

            if (Int32.Parse(numStr) > Int32.Parse(numStr2) ? true : false)
            {
                Console.WriteLine("O primeiro valor digitado é maior que o segundo");
            }
            else
            {
                Console.WriteLine("O segundo valor digitado é maior que o primeiro");
            }

            Error:
            if (exit)
            {
                Console.Write("Digite um valor válido");

            }
        }
    static void Exemplo()
        {
            string textoSaida;
            string nomeCandidato;
            bool exit = false;
            int idadeCandidato, notaCandidato;

            Console.WriteLine("|***** Bem vindo ao programa SysSchool *****|\n\n");

            Console.WriteLine("Informe o nome do candidato:");
            nomeCandidato = Console.ReadLine();

            Console.WriteLine("Informe a Idade do Candidato: ");
            string idadeStr = Console.ReadLine();

            if (idadeStr.Equals("") || !Char.IsDigit(idadeStr[0]))
            {
                exit = true;
                goto Finish;
            }
            else
            {
                idadeCandidato = Int16.Parse(idadeStr);
            }

            Console.WriteLine("Digite a nota do candidato");
            string notaStr = Console.ReadLine();
            if (idadeStr.Equals("") || !Char.IsDigit(idadeStr[0]))
            {
                exit = true;
                goto Finish;
            }
            else
            {
                notaCandidato = Int16.Parse(notaStr);
                if (notaCandidato > 10 || notaCandidato < 0)
                {
                    exit = true;
                    goto Finish;
                }
            }

            textoSaida = $"Candidato {nomeCandidato}\n";
            textoSaida += $"Idade {idadeCandidato} ";
            // Verificar se o candidato é maior de idade
            if (idadeCandidato < 18)
            {
                textoSaida += "(Menor de idade)\n";
            }
            else
            {
                textoSaida += "(Maior de idade)\n";
            }


            textoSaida += $"Nota Final: {notaCandidato}\n";

            if (notaCandidato > 5)
            {
                textoSaida += @"*******************
*** APROVADO!!! ***
*******************";
            }
            else
            {
                textoSaida += "| REPROVADO :( |";
            }

            Console.WriteLine(textoSaida);


            Finish:
            if (exit)
            {
                Console.WriteLine("Digite um valor válido");
            }

            Console.ReadKey();
}

    }
}
