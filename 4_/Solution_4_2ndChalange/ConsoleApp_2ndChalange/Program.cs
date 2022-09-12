using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_2ndChalange
{
    internal class Program
    {   
        
        static void Main()
        {
            Console.Title = "2nd Chalange";
            bool firstWelcome = true; 
            while (true)
            {
                Console.Clear();
                if (firstWelcome) {
                    Console.WriteLine("Bem vindo ao programa dos exercicios (IF-ELSE)");
                } else
                {
                    Console.WriteLine("Olá, bem vindo novamente!, escolha uma opção do Menu!");
                }
                firstWelcome = false;
                Console.WriteLine("1- Exercicio 3");
                Console.WriteLine("2- Exercicio 4");
                Console.WriteLine("3- Exercicio 5");
                Console.WriteLine("4- Exercicio 6");
                Console.WriteLine("5- Exercicio 7");
                Console.WriteLine("6- Exercicio 8");
                Console.WriteLine("--------------");
                Console.WriteLine("0- Sair\n");
                Int32.TryParse(Console.ReadLine(), out int opcao);
                switch (opcao)
                {
                    case 1:
                        cha1();
                        break;
                    case 2:
                        cha2();
                        break;
                    case 3:
                        cha3();
                        break;
                    case 4:
                        cha4();
                        break;
                    case 5:
                        cha5();
                        break;
                    case 6:
                        cha6();
                        break;
                    case 0:
                        goto FINISH;
                    default:
                        break;
                }
            }

            FINISH:
            Console.WriteLine("Até mais!");


            Console.ReadKey();
        }

        public static void cha1()
        {
            Console.Clear();
            Console.WriteLine("Exercício 3, gera um número aleatório (1-100) e verifica se ele é impar!!!");
            Random random = new Random();
            int nmr = random.Next(1, 101);
            Console.WriteLine($"Número aleatório = {nmr}");
            if (nmr - nmr/2*2 == 0)
            {
                Console.WriteLine("Número Par, FALSO!!!");
            }else
            {
                Console.WriteLine("Número Ímpar, VERDADEIRO!!!");
            }

            Console.WriteLine("Pressione qualquer botão para voltar ao Menu");
            Console.ReadKey();
        }

        public static void cha2()
        {
            Console.Clear();
            Console.WriteLine("Exercício 4, gera um número aleatório (1-5) seguindo as seguintes regras de negócio!!!");
            Console.WriteLine("1 - Arroz");
            Console.WriteLine("2 - Feijão");
            Console.WriteLine("3 - Farinha");
            Console.WriteLine("Outro número - Diversos");
            string name1 = "Arroz";
            string name2 = "Feijão";
            string name3 = "Farinha";
            Random random = new Random();
            int nmr = random.Next(1, 6);
            Console.WriteLine($"Número aleatório = {nmr}");
            if (nmr.Equals(1))
            {
                Console.WriteLine($"Produto: {name1}");
            } else if (nmr.Equals(2))
            {
                Console.WriteLine($"Produto: {name2}");
            } else if (nmr.Equals(3))
            {
                Console.WriteLine($"Produto: {name3}");
            } else
            {
                Console.WriteLine("Produto: Diversos");
            }

            Console.WriteLine("Pressione qualquer botão para voltar ao Menu");
            Console.ReadKey();
        }

        public static void cha3()
        {
            Console.Clear();
            Console.WriteLine("Recebe uma idade e mostra se o indivíduo é maior ou menor de idade!!!\n\n");
            Console.WriteLine("Informe o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade");
            Int32.TryParse(Console.ReadLine(), out int idade);

            bool permissao = idade >= 18 ? true : false;

            if (permissao)
            {
                Console.WriteLine($"{nome} é maior de idade"); 
            } else
            {
                Console.WriteLine($"{nome} é menor de idade");
            }

            Console.WriteLine("Pressione qualquer botão para voltar ao Menu");
            Console.ReadKey();
        }

        public static void cha4()
        {
            Console.Clear();
            Console.WriteLine("Este programa irá ler o ano do nascimento de uma pessoa e dirá se ela poderá votar ou não\n\n");
            Console.WriteLine("Digite a data do seu nascimento no modelo YYYY");
            Int32.TryParse(Console.ReadLine(), out int ano); 
            bool permissao = DateTime.Now.Year - ano >= 16 ? true : false;
            if (permissao)
            {
                Console.WriteLine("Poderá votar!");
            }else
            {
                Console.WriteLine("Não poderá votar!");
            }

            Console.WriteLine("Pressione qualquer botão para voltar ao Menu");
            Console.ReadKey();
        }

        public static void cha5()

        {
            Console.Clear();
            Console.WriteLine("O exercício abaixo irá verificar se a pessoa pode ou não se aposentar, partindo de um número aleatório");
            Console.WriteLine("\nAs regras de negócio sao: APOSENTADO (IDADE MAIOR QUE 65 ANOS) ou (TEMPO DE TRABALHO MAIOR QUE 25 ANOS)");
            Random random = new Random();
            int idade = random.Next(50, 80);
            int tempoTrabalho = random.Next(15, 40);

            Console.WriteLine($"\nIdade aleatória gerada {idade}, tempo de trabalho aleatório gerado {tempoTrabalho}");

            if ((idade > 65) || (tempoTrabalho > 25))
            {
                Console.WriteLine("Pessoa aleatória poderá se aposentar!");
            } else
            {
                Console.WriteLine("A pessoa aleatória não poderá se aposentar.");
            }
            Console.WriteLine("Pressione qualquer botão para voltar ao Menu");
            Console.ReadKey();

        }

        public static void cha6()
        {
            Console.WriteLine("O programa a seguir irá fazer a validação de uma senha digitada pelo usuário");
            Console.WriteLine("\n\nPor favor digite a senha para o programa realizar a validação!!!");
            const string SENHA = "1234";
            string senhaInput = Console.ReadLine();

            if (senhaInput.Equals(SENHA))
            {
                Console.WriteLine("Usuário permitido");
            } else {
                Console.WriteLine("Senha inválida");
            }


            Console.WriteLine("Pressione qualquer botão para voltar ao Menu");
            Console.ReadKey();
        }
    }
}
