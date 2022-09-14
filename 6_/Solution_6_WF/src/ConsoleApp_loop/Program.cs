using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_6_Loop
{

    internal class Program
    {
        static void print(string word) => Console.WriteLine(word);
        static string scan() => Console.ReadLine();

        static void makeMenu(int exercises)
        {
            for (int i = 0; i < exercises; i++)
            {
                print($"{i + 1} - Exercício {i + 1}");
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
                makeMenu(9);
                bool isValid = int.TryParse(scan(), out int option);
                if (!isValid)
                {
                    print("Digito inválido, tente novamente...");
                    goto TRY_AGAIN;
                }
                switch (option)
                {
                    case 0:
                        goto FINISH;
                    case 1:
                        ex1();
                        break; 
                    case 2:
                        ex2();
                        break;
                    case 3:
                        ex3();
                        break;
                    case 4:
                        ex4();
                        break;
                    case 5:
                        ex5();
                        break;
                    case 6:
                        ex6();
                        break;
                    case 7:
                        ex7();
                        break;
                    case 8:
                        ex8();
                        break;
                    case 9:
                        ex9();
                        break;
                    default:
                        print("Opção inválida!");
                        Thread.Sleep(2000);
                        goto TRY_AGAIN;
                }
            }

            FINISH:
            print("Adeus...");

        }
        static void ex1()
        {
            Console.Clear();
            print("Loop com WHILE");
            int controle = 1; 
            while (controle > 0)
            {
                print("Informe o código 0 para sair");
                Int32.TryParse(scan(), out controle);
            }
        }
        static void ex2()
        {
            Console.Clear();
            print("Loop com DO");

            int controle = 1;
            do //entra pelo menos uma vez!!!
            {
                print("Informe o código 0 para sair");
                Int32.TryParse(scan(), out controle);

            } while (controle > 0);
        }
        static void ex3()
        {
            Console.Clear();
            print("Este programa irá exibir todos os número ímpares de 1 até 100...");
            Thread.Sleep(1500);
            int myVar = 1; 
            while (myVar < 100)
            {
                print(myVar.ToString());
                Thread.Sleep(100);
                myVar += 2;    
            }

        }
        static void ex4()
        {
            Console.Clear();
            print("Este programa irá exibir todos os número pares de 1 até 100...");
            Thread.Sleep(1500);
            int myVar = 0;
            while (myVar <= 100)
            {
                print(myVar.ToString());
                Thread.Sleep(100);
                myVar += 2;
            }
        }
        static void ex5()
        {
            Console.Clear();
            print("Este programa irá exibir todos os número pares ou ímpares até o valor que vc escolher.");
            Thread.Sleep(1500);
            print("Por favor, escolha o número!");
            int.TryParse(scan(), out int numberChoosed);
            bool isSnd = false; 
            int myVar = 1;
            REDO:
            if (isSnd) { 
                myVar = 0;
                print("Mostrando Pares.");
            }
            if (!isSnd)
            {
                print("Mostrando ímpares.");
            }
            while (myVar <= numberChoosed)
            {
                print(myVar.ToString());
                Thread.Sleep(150);
                myVar += 2;
            }
            if (!isSnd) { 
                isSnd = true; 
                goto REDO; 
            }


        }
        static void ex6()
        {
            Console.Clear();
            print("Este programa irá exibir a soma das notas do \"alunos\" do usuário...");
            Thread.Sleep(1500);
            print("Quantos alunos você tem?");
            REDO_QUANTITY:
            bool isValid = int.TryParse(scan(), out int quantity);
            if (!isValid) {
                print("Número inválido, digite novamente.");
                goto REDO_QUANTITY;  
            }
            int alunosCounter = 0;
            int mySum = 0;
            do
            {
                print($"Digite a nota do aluno: {alunosCounter + 1}: ");
                REDO_NOTA:
                bool isValid2 = int.TryParse(scan(), out int nota);
                if (!isValid2)
                {
                    print("Número inválido, digite novamente.");
                    goto REDO_NOTA;
                }
                mySum += nota; 
                alunosCounter++;
            } while (alunosCounter < quantity);
            double mean = double.Parse(mySum.ToString())/quantity;
            print($"Soma: {mySum} {quantity}");
            print($"A media aritimética dos alunos foi de {mean}");
            Thread.Sleep(3000);
            


        }    
        static void ex7()
        {
            Console.Clear();
            print("Este programa irá exibir número de 1 a 20 embaixo e depois ao lado...");
            Thread.Sleep(1500);
            int myVar = 1;
            print("Números sendo mostrados abaixo um do outro");
            while (myVar <= 20)
            {
                print(myVar.ToString());
                Thread.Sleep(100);
                myVar ++;
            }
            myVar = 1;
            print("Números sendo mostrados ao lado um do outro");
            while (myVar <= 20)
            {
                Console.Write( myVar.ToString() );
                Thread.Sleep(150);
                myVar++;
            }

        }
        static void ex8()
        {
            Console.Clear();
            print("Este programa irá exibir todos os número divisíveis por 5 de 1000 até 1999...");
            Thread.Sleep(1500);
            int myVar = 1000;
            while (myVar <= 1999)
            {
                if (myVar % 11 == 5)
                {
                    print(myVar.ToString());
                }
                Thread.Sleep(100);
                myVar ++;
            }
        }
        static void ex9(){

            Console.Clear();
            print("Este programa irá te testar para ver se você é capaz de acertar um número aleatório [1,20] gerado pelo computador...");
            Thread.Sleep(1500);
            Random random = new Random();
            int nmrPc = random.Next(1, 21);
            int counter = 1;
            bool isCorrect = false; 
            while (counter <= 3 && !isCorrect)
            {
                REDO:
                print($"Tente acertar o número escolhido pelo computador, tentativa [{counter}]");
                bool isValid = int.TryParse(scan(), out int numberChoosed);
                if (!isValid)
                {
                    print("Digito inválido, tente novamente");
                    goto REDO;
                } 
                Thread.Sleep(100);
                isCorrect = numberChoosed == nmrPc ? true : false;
                if (isCorrect)
                {
                    print("Ok.");
                }
                else
                {
                    print("Errado");
                }
                counter++;
                
            }
            print($"Número escolhido pelo computador {nmrPc}");
            if (isCorrect == false)
            {
                print("Três tentativas e nada... treine sua intuição");
            } else {

                print("Parabéns.");
            }

            Thread.Sleep(1500);
        }
    }
}
