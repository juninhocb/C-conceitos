using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp_5._1
{
    internal class Program
    {
        static void print(string word) => Console.WriteLine(word);
        static string scan() => Console.ReadLine();
        static void Main()
        {
            const string WELCOME_FIRST = "Bem vindo ao programa, digite o número do exercício, ou 0 para sair! \n2- Exercicio compras \n3- Jogo 21\n4- Jogo 21 V2";
            const string ANOTHER_WELCOME = "Bem vindo novamente, digite o número do exercício ou 0 para sair, \n2- Exercicio compras \n3- Jogo 21\n4- Jogo 21 V2";
            const string TITLE = "Exercícios _5";
            Console.Title = TITLE; 
            bool isFst = false; 
            while (true)
            {
                Console.Clear();
                if (isFst) { print(WELCOME_FIRST); } else { print(ANOTHER_WELCOME); };
                bool isValid = int.TryParse(scan(), out int option);
                if (!isValid) { print("\nDigito inválido"); goto FINISH; }
                switch (option)
                {
                    case 0:
                        goto FINISH;
                    case 2:
                        ex2();
                        break;
                    case 3:
                        ex3();
                        break;
                    case 4:
                        ex4();
                        break;
                    default:
                        print("\nDigite inválido, tente novamente");
                        Thread.Sleep(2000);
                        break;
                }
            }
            
            FINISH:
            print("Saindo.....");
        }
        
        static void ex4()
        {
            Console.Clear();
            print("Bem vindo ao jogo do 21 - Versão 2. aguarde...");
            Thread.Sleep(1500);
            print("...");
            Thread.Sleep(1500);
            bool isUserTime = true;
            bool isPcTime = false;
            int result = 0;
            REDO:
            Console.Clear();
            print("Escolha um valor entre [1 e 20]");
            bool isValid = int.TryParse(scan(), out int inputUser);
            if (!isValid || (inputUser < 1 || inputUser > 20))
            {
                print("Por favor, digite um valor válido, entre 1 e 20");
                goto REDO;
            }
            print($"Você escolheu: {inputUser}, aguarde o Computador escolher o número dele");
            Thread.Sleep(2000);
            Random random = new Random();
            int pcNumber = random.Next(1, 21);
            print($"O computador escolheu o número {pcNumber}");
            int generatedNumber = random.Next(1, 21);
            int resultPc = pcNumber + generatedNumber;
            int resultUser = inputUser + generatedNumber;
            int userCount = 0;
            int pcCount = 0;
            AGAIN:
            int count = 0;
            if (isUserTime) { result = resultUser; } else { result = resultPc; }
            switch (result)
            {
                //case <= 6:  //C# 9
                case int n when  (n <= 6): 
                    count +=1;
                    break;
                case 7:
                    count += 10;
                    break;
                case int n when (n <= 8 && n<=13):
                    count += 5;
                    break;
                case 14:
                    count += 20;
                    break;
                case int n when (n >= 15 && n <= 20):
                    count += 6;
                    break;
                case 21:
                    count += 30;
                    break;
                default:
                    break;
            }
            isUserTime = false;
            if (!isPcTime) { 
                isPcTime = true; 
                userCount = count;  
                goto AGAIN; 
            }
            pcCount = count; 
            print($"Valor gerado aleatóriamente {generatedNumber}");
            Thread.Sleep(2000);
            print($"Soma do Usuário {resultUser}");
            Thread.Sleep(2000);
            print($"Soma do Computador {resultPc}");
            Thread.Sleep(2000);
            print($"Pontuação do Usuário {userCount}");
            Thread.Sleep(2000);
            print($"Pontuação do Computador {pcCount}");
            Thread.Sleep(2000);
            print("Aguarde o resultado!");
            Thread.Sleep(3000);
            if (userCount > pcCount)
            {
                print("Parabéns, você ganhou!");
            }
            else if (pcCount > userCount)
            {
                print("Que pena, você perdeu!");
            }
            else
            {
                print("Obitvemos um empate.");
            }
            REDO_CONTINUE:
            print("\nDeseja jogar novamente? Digite Y para sim ou N para não");
            ConsoleKeyInfo key = Console.ReadKey();
            
            char response = key.KeyChar;
            if (response.Equals('Y'))
            {
                goto REDO;
            }
            else if (response.Equals('N'))
            {

            }
            else
            {
                goto REDO_CONTINUE;
            }

            print("\nVoltando ao Menu");
            Thread.Sleep(1500);

        }
        static void ex3()
        {
            Console.Clear();
            print("Bem vindo ao jogo do 21, aguarde...");
            Thread.Sleep(1500);
            print("...");
            Thread.Sleep(1500);
            bool isUserTime = true;
            bool isPcTime = false;
            int result = 0;
            REDO:
            Console.Clear();
            print("Escolha um valor entre [1 e 20]");
            bool isValid = int.TryParse(scan(), out int inputUser);
            if (!isValid || (inputUser < 1 || inputUser > 20)) {
                print("Por favor, digite um valor válido, entre 1 e 20");
                goto REDO; 
            }
            print($"Você escolheu: {inputUser}, aguarde o Computador escolher o número dele");
            Thread.Sleep(2000);
            Random random = new Random();
            int pcNumber = random.Next(1, 21);
            print($"O computador escolheu o número {pcNumber}");
            int generatedNumber = random.Next(1, 21);
            int resultPc = pcNumber + generatedNumber;
            int resultUser = inputUser + generatedNumber;
            int userCount = 0;
            int pcCount = 0;
            AGAIN:
            if (isUserTime) { result = resultUser; } else { result = resultPc; }    
            switch (result)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    if (isUserTime)
                    {
                        //print("Ganhou 1 ponto USER");
                        userCount += 1;
                    }
                    else
                    {
                        //print("Ganhou 1 ponto PC");
                        pcCount += 1;
                    }
                    break;
                case 7:
                    if (isUserTime)
                    {
                        //print("Ganhou 10 ponto USER");
                        userCount += 10;
                    } else
                    {
                        //print("Ganhou 10 ponto PC");
                        pcCount += 10;
                    }
                    break;
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                    if (isUserTime)
                    {
                        //print("Ganhou 5 ponto USER");
                        userCount += 5;
                    }
                    else
                    {
                        //print("Ganhou 5 ponto PC");
                        pcCount += 5;
                    }
                    break;

                case 14:
                    if (isUserTime)
                    {
                        //print("Ganhou 14 ponto USER");
                        userCount += 14;
                    }
                    else
                    {
                        //print("Ganhou 14 ponto PC");
                        pcCount += 14;
                    }
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    if (isUserTime)
                    {
                        //print("Ganhou 6 ponto USER");
                        userCount += 6;
                    }
                    else
                    {
                        //print("Ganhou 6 ponto PC");
                        pcCount += 6;
                    }
                    break;
                case 21:
                    if (isUserTime)
                    {
                        //print("Ganhou 30 ponto USER");
                        userCount += 30;
                    }
                    else
                    {
                        //print("Ganhou 30 ponto PC");
                        pcCount += 30;
                    }
                    break;
                default:
                    break; 
            }
            isUserTime = false;
            if (!isPcTime) { isPcTime = true;  goto AGAIN; }
            print($"Valor gerado aleatóriamente {generatedNumber}");
            Thread.Sleep(2000);
            print($"Soma do Usuário {resultUser}");
            Thread.Sleep(2000);
            print($"Soma do Computador {resultPc}");
            Thread.Sleep(2000);
            print($"Pontuação do Usuário {userCount}");
            Thread.Sleep(2000);
            print($"Pontuação do Computador {pcCount}");
            Thread.Sleep(2000);
            print("Aguarde o resultado!");
            Thread.Sleep(3000);
            if (userCount > pcCount)
            {
                print("Parabéns, você ganhou!");
            } else if (pcCount > userCount)
            {
                print("Que pena, você perdeu!");
            }
            else{
                print("Obitvemos um empate.");
            }
            REDO_CONTINUE:
            print("Deseja jogar novamente? Digite Y para sim ou N para não");
            ConsoleKeyInfo key = Console.ReadKey();
            char response = key.KeyChar;
            if (response.Equals('Y'))
            {
                goto REDO;
            } else if (response.Equals('N'))
            {

            } else
            {
                goto REDO_CONTINUE;
            }

            print("\nVoltando ao Menu");
            Thread.Sleep(1500);


        }    
        static void ex2()
        {
            const string HATCH = "1";
            const string SEDAN = "2";
            const string MOTOCICLETA = "3";
            const string CAMINHONETES = "4";
            Console.Clear();
            print("Bem vindo ao exercício 2");
            Thread.Sleep(1500);
            print("...");
            Thread.Sleep(1500);
            REDO:
            print("Escolha o tipo de carro que deseja comprar...");
            print("Opções: [1]Hatch, [2]Sedan, [3]Motocicleta e [4]Caminhonetes");
            string model = scan();
            switch (model.ToUpper())
            {
                case HATCH:
                    print("Comrpa efetuada com sucesso!");
                    goto FINISH;
                case SEDAN:
                    goto DECICISION;
                case MOTOCICLETA:
                    goto DECICISION;
                case CAMINHONETES:
                    goto DECICISION;
                default:
                    print("Não trabalhamos com este tipo de automóvel aqui");
                    goto FINISH;
            }

            DECICISION:
            print("Tem certeza que prefere este modelo? [Y para sim e N para não]");
            ConsoleKeyInfo key = Console.ReadKey();
            char response = key.KeyChar;
            if (response.Equals('Y'))
            {
                print("\nCompra efetuada com sucesso!");
            }else if (response.Equals('N'))
            {
                print("\nOk... decida novamente");
                Thread.Sleep(1500);
                goto REDO;
            }else
            {
                print("\nValor Inválido, deve ser Y ou N");
                goto DECICISION;
            }
            FINISH:
            print("Voltando ao Menu!!!");
            Thread.Sleep(2000);
            
        }
    
    }
}
