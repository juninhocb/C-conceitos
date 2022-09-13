using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_5_Switch_Loop
{


    internal class Program
    {
        static void print(string word) => Console.WriteLine(word);
        static string scan() => Console.ReadLine();
        static void Main()
        {
            Console.Title = "Switch and Loopings";
            string codigo;
            const string CODIGO_1 = "A23";
            const string CODIGO_2 = "A35";
            const string CODIGO_3 = "Z16";
            const string CODIGO_4 = "A21";
            const string CODIGO_5 = "A22";
            const string CODIGO_6 = "A24";


            print(CODIGO_1);
            print(CODIGO_2);
            print(CODIGO_3);
            print(CODIGO_4);
            print(CODIGO_5);
            print(CODIGO_6);


            print("Escolha um código para ver a descrição");
            codigo = scan();

            print("Escolha um valor para A");
            int a = int.Parse(scan());
            print("Escolha um valor para B");
            int b = int.Parse(scan());
            bool myComparison = string.Equals(codigo, "astringvalue", StringComparison.OrdinalIgnoreCase);
            print(myComparison.ToString());
            switch (codigo.ToUpper())
            {
                case CODIGO_1 when a > b:
                    print("A23: Materiais");
                    ex1();
                    break;
                case CODIGO_1 when b > a:
                    print("A23: Materiais");
                    break;
                case CODIGO_2:
                    print("A35: Produtos perecíveis");
                    break;
                case CODIGO_3:
                    print("Produtos Químicos");
                    break;
                case CODIGO_4:
                    print("OPA");
                    break;
                case CODIGO_5:
                    print("OPAAAS");
                    break;
                case CODIGO_6:
                    print("Blez");
                    break;
                default:
                    print("Produto não cadastrado");
                    break;
            }

            Console.ReadKey();
        }

        static void ex1(){

            string fruta;

            print("Escolha entre maçã, kiwi ou melância.");
            fruta = scan();
            print("Fruta + sua substring(0,2)" + fruta.Substring(0, 2));
            switch (fruta.ToLower())
            {
                case "maçã":
                    print("Não vendemos esta fruta aqui.");
                    break;
                case "kiwi":
                    print("Estamos com escassez de kiwis.");
                    break;
                case "melância":
                    print("Aqui está, são 3 reais o quilo.");
                    break;
                default:
                    print("Não temos informação sobre esta opção escolhida");
                    break; 
            }

            print("Fruta + sua substring(0,2)" + fruta.Substring(0, 2));
            print("Fruta + com replace (a,y)" + fruta.Replace("a","y"));

        }
    }
}
