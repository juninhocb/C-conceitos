using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp4_1_IF_ELSE
{
    internal class Program
    {
        static string getWelcomemsg(bool fstEntry) => fstEntry ? "Bem vindo ao programa de exercicios, escolha uma opção!" : "Escolha uma opção";
        static void print(string word) => Console.WriteLine(word);
        static void makeMenu(int exercises)
        {
            for (int i = 0; i < exercises; i++)
            {
                print($"{i + 1} - Exercício {i + 1}");
            }

            print("0 - Sair");
        }

        static void makeStatement(int noExercise, string typeExercise)
        {
            Console.Clear();
            print($"Exercício {noExercise}\n{typeExercise}");
        }


        static bool isContinue() {
            START:
            Thread.Sleep(1000);
            print("\nDeseja executar o exercício novamente? Digite Y se sim ou N se não");
            ConsoleKeyInfo key = Console.ReadKey();
            char option = key.KeyChar;
            if (option.Equals('Y'))
            {
                Console.Clear();
                return true; 
            }
            else if (option.Equals('N'))
            {
                return false;
            }
            goto START;
        }
        static void returnMenu()
        {
            print("\nSaindo do exercício e voltando ao Menu...");
            Thread.Sleep(2000);
            Console.Clear();
        } 
        static void Main()
        {
            bool isFst = true;
            do
            {
                print(getWelcomemsg(isFst));
                makeMenu(7);
                bool isValid = int.TryParse(Console.ReadLine(), out int opcao);
                print("Carregando..."); 
                Thread.Sleep(1000);
                switch (opcao)
                {
                    case 0:
                        if (!isValid) { goto WRONG_DIGIT; };
                        goto FINISH_BY_USER;
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
                    default:
                        goto INVALID_EXERCISE;
                        
                }

                isFst = false;  

            } while (true);


            INVALID_EXERCISE:
            print("Exercício inexistente, saindo...");
            goto EXIT_APPLICATION;

            WRONG_DIGIT:
            print("Valor númerico inválido, sanido...");
            goto EXIT_APPLICATION;

            FINISH_BY_USER:
            print("Saindo... adeus!");
            goto EXIT_APPLICATION;

            EXIT_APPLICATION:
            Thread.Sleep(1500);
            Environment.Exit(1);

        }
        
        static void ex7()
        {
            makeStatement(7, "O Programa a seguir irá solicitar os valores do ângulo (em graus) de um triângulo e dizer sua característica");
            REDO:
            print("Por favor, digite o valor do primeiro ângulo (em graus) do triângulo");
            bool isValid = int.TryParse(Console.ReadLine(), out int a1);
            UInt32 a1Conv = uint.Parse(a1.ToString());
            if (!isValid || a1Conv > 178) { print("\nValor inválido! [Triângulos devem possuir uma soma de 180°]"); goto EXIT; }
            print("Por favor, digite o valor do segundo ângulo (em graus) do triângulo");
            bool isValid2 = int.TryParse(Console.ReadLine(), out int a2);
            UInt32 a2Conv = uint.Parse(a2.ToString());
            if (!isValid2 || ((a1Conv  + a2Conv) > 179)) { print("\nValor inválido! [Triângulos devem possuir uma soma de 180°]"); goto EXIT; }
            UInt32 a3Conv = 180 - a1Conv - a2Conv; 
            if(a1Conv.Equals(90) || a2.Equals(90) || a3Conv.Equals(90))
            {
                print($"Triângulo Retângulo. Ângulos [ {a1Conv}° | {a2Conv}° | {a3Conv}° ] ");
            } else if (a1Conv > 90 || a2Conv > 90 || a3Conv > 90)
            {
                print($"Triângulo Obtusângulo. Ângulos [ {a1Conv}° | {a2Conv}° | {a3Conv}° ] ");
            } else
            {
                print($"Triângulo Acutângulo. Ângulos [ {a1Conv}° | {a2Conv}° | {a3Conv}° ] ");
            }
            if (isContinue()) { goto REDO; }
            EXIT:
            returnMenu();
        }
        static void ex6()
        {
            makeStatement(6, "O Programa a seguir irá solicitar os valores do lado do triângulo e dizer seu tipo");
            REDO:
            print("Por favor, digite o valor do primeiro lado do triângulo");
            bool isValid = int.TryParse(Console.ReadLine(), out int s1);
            if(!isValid) { print("\nValor inválido!"); goto EXIT; }
            print("Por favor, digite o valor do segundo lado do triângulo");
            bool isValid2 = int.TryParse(Console.ReadLine(), out int s2);
            if (!isValid2) { print("\nValor inválido!"); goto EXIT; }
            print("Por favor, digite o valor do terceiro lado do triângulo");
            bool isValid3 = int.TryParse(Console.ReadLine(), out int s3);
            if (!isValid3) { print("\nValor inválido!"); goto EXIT; }
            if (s1 == s2 && s1 == s3) { print("Triângulo Equilatero."); 
            } else if (s1 == s3 || s2 == s3) { print("Triângulo Isóceles.");  
            } else { print("Triângulo Escaleno."); }
            if (isContinue()) { goto REDO; }
            EXIT:
            returnMenu();
        }
        static void ex5()
        {
            string ISNT_POLYGON = "NÃO É UM POLÍGONO";
            string IS_POLYGON = "É UM POLÍGONO";
            makeStatement(5, "O Programa a seguir irá solicitar os lados de um polígono e irá tratar-los!");
            REDO:
            print("Por favor, digite quantos lados o polígono possui");
            bool isValid = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int sides);
            if (!isValid || sides == 0) { print("\nValor de número de lados inválido!"); goto EXIT; }
            if (sides == 3)
            {
                Console.Clear();
                print("Figura: TRIÂNGULO. Por favor, aguarde um momento...");
                Thread.Sleep(1500);
                print("...");
                Thread.Sleep(1500);
                print("Por favor, digite a altura do triângulo em centímetros");
                bool isValid2 = int.TryParse(Console.ReadLine(), out int hTri);
                if (!isValid2) { print("\nValor de altura inválido!"); goto EXIT; }
                print("Por favor, digite o valor do lado do triângulo em centímetros");
                bool isValid3 = int.TryParse(Console.ReadLine(), out int lTri);
                if (!isValid3) { print("\nValor do lado de inválido!"); goto EXIT; }
                print($"A Figura {ISNT_POLYGON} e possui área de {(double.Parse(hTri.ToString())*double.Parse(lTri.ToString()))/2} cm².");
            } else if (sides == 4) {
                Console.Clear();
                print("Figura: QUADRADRO. Por favor, aguarde um momento...");
                Thread.Sleep(1500);
                print("...");
                Thread.Sleep(1500);
                print("Por favor, digite o valor do lado do quadrado em centímetros");
                bool isValid2 = int.TryParse(Console.ReadLine(), out int sQua);
                if (!isValid2) { print("\nValor do lado inválido!"); goto EXIT; }
                print($"A Figura {IS_POLYGON} e possui área de {sQua*sQua} cm².");
            } else if (sides == 5)
            {
                Console.Clear();
                print($"A Figura {IS_POLYGON} é um PENTÁGONO.");
            } else
            {
                Console.Clear();
                print($"A Figura {IS_POLYGON} não identificado.");
            }
            if (isContinue()) { goto REDO; }
            EXIT:
            returnMenu();
        }

        static void ex4()
        {
            makeStatement(4, "O Programa a seguir irá solicitar seu sexo e sua altura e informará seu peso ideal");
            REDO:
            print("Por favor, digite seu sexo\n1 - Feminino \n2 - Masculino");
            bool isValid = int.TryParse(Console.ReadKey().KeyChar.ToString(), out int sex);
            if (!isValid || (sex != 1 && sex != 2)) { print("\nValor inválido!"); goto EXIT; }
            print("\nPor favor, digite a sua altura em centímetros (cm)");
            bool isValid2 = int.TryParse(Console.ReadLine(), out int height);
            if (!isValid2 || !(130 < height && 210 > height)) { print("\nValor inválido! O PROGRAMA TRABALHA COM ALTURAS ENTRE 130 A 210 CM"); goto EXIT; }
            if (sex == 1)
            {
                print($"O seu peso ideal é de: {(77.7D * (height*0.01D)) - 58D} KG.");
            } else
            {
                print($"O seu peso ideal é de: {(62.1D * (height*0.01D)) - 44.7D} KG.");
            }
            if (isContinue()) { goto REDO; }
            EXIT:
            returnMenu();
        }

        static void ex3()
        {
            makeStatement(3, "O Programa a seguir irá exibir ao usuário o maior valor digitado por ele");
            REDO:
            print("Por favor, digite o valor do primeiro número");
            bool isValid = int.TryParse(Console.ReadLine(), out int fstNmr);
            if (!isValid) { print("Valor inválido!"); goto EXIT; }
            print("Por favor, digite o valor do segundo número");
            bool isValid2 = int.TryParse(Console.ReadLine(), out int sndNmr);
            if (!isValid2) { print("Valor inválido!"); goto EXIT; }
            bool isNmrBigger = fstNmr > sndNmr ? true : false;
            if (isNmrBigger) { print($"O primeiro valor digitado é maior {fstNmr}"); } else { print($"O segundo valor digitado é maior {sndNmr}"); }
            if (isContinue()) { goto REDO; }
            EXIT:
            returnMenu();
        }

        static void ex1()
        {
            makeStatement(1, "O Programa a seguir irá calcular o valor da compra de maçãs!");
            REDO:
            print("Por favor, digite o número de maças que deseja comprar");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            if (!isValid) { print("Valor inválido!");  goto EXIT;}
            decimal total = quantity >= 12 ? quantity * 0.25M : quantity * 0.3M;
            print($"O valor total da compra será de R$ {total}.");
            if(isContinue()){ goto REDO; }
            EXIT:
            returnMenu();
        }

        static void ex2()
        {
            makeStatement(2, "O programa a seguir irá ler 3 valores inteiros (não repetidos) e exibirá-los em ordem crescente");
            REDO:
            string formatResponse = "Ordem crescente dos valores digitados:";
            print("Por favor, digite o primeiro valor");
            bool isValid = int.TryParse(Console.ReadLine(), out int value1);
            print("Por favor, digite o segundo valor");
            bool isValid2 = int.TryParse(Console.ReadLine(), out int value2);
            print("Por favor, digite o terceiro valor");
            bool isValid3 = int.TryParse(Console.ReadLine(), out int value3);
            if (!isValid || !isValid2 || !isValid3) { print("Algum dos valores digitados não é válido!"); goto EXIT; }
            if (value1 == value2 || value2 == value3 || value3 == value1) { print("Valores repetidos..."); goto EXIT; }
            if (value1 < value2 && value1 < value3)
            {
                formatResponse += $" ({value1})";
                if (value2 < value3)
                {
                    formatResponse += $" ({value2}) ({value3}).";
                }
                else
                {
                    formatResponse += $" ({value3}) ({value2}).";
                }

            } else if(value2 < value3 && value2 < value1)
            {
                formatResponse += $"({value2})";
                if (value1 < value3)
                {
                    formatResponse += $" ({value1}) ({value3}).";
                } else
                {
                    formatResponse += $" ({value3}) ({value1}).";
                }
            }
            else
            {
                formatResponse += $" ({value3})";
                if (value1 < value2)
                {
                    formatResponse += $" ({value1}) ({value2}).";
                }else
                {
                    formatResponse += $" ({value2}) ({value1}).";
                }
            }
            print(formatResponse);
            if (isContinue()) { goto REDO; }
            EXIT:
            returnMenu();
        }
    }


}
