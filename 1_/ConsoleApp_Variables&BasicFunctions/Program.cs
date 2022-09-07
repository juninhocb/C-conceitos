using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Meu titulo do Console"; //mudando um atributo da classe Console!
            //tipo var não são boas para serem utilizadas quando sabemos o tipo de variável a ser trabalhar
            //a motivação é para boa leitura do código
            //string e String são diferentes, String, pertence a classe e string é um tipo valor que pertence a classe System.String.. 
            //value types são os tipos de variáveis
            //reference types são tipos de objetos 
            string nomeUsuario;
            int idadeUsuario;
            var timeFutebol = "Palmeiras";
            char caractere = 'c'; 
            nomeUsuario = "Carlos Eduardo Jr";
            idadeUsuario = 22;
            //comentário em bloco ctrl+shift+;

            Console.WriteLine("Por favor, insira um nome para o programa ler!");
            string nomeSecundario = Console.ReadLine();

            Console.Write("Digite um único valor para o caractere! Este será inserido ao lado deste texto: ");
            Console.ReadLine();

            Console.WriteLine("\n\n\nNome: " + nomeUsuario + "\nIdade: " +  idadeUsuario + 
                "\nTime de Futebol: " + timeFutebol + "\nNome digitado: " + 
                nomeSecundario + "\nCaractere instânciado: " + caractere);

            //tamanhos de strings
            string var1 = "minha string";
            string var2 = "minha outra string ";
            String var3 = "minha String"; 
            Console.WriteLine("\n\n\nTamanho da string 1: " + var1.Length);
            Console.WriteLine("Tamanho da string 2: " + var2.Length);
            Console.WriteLine("Acessando o segundo caractere da string: " + var1[1] + "\n");

            //descobrindo tipos de variáveis 
            Console.WriteLine("Tipo da variável var2[1]: " + var2[1].GetType());
            Console.WriteLine("Tipo da variável declarada com string: " + var1.GetType());  //Classe String
            Console.WriteLine("Tipo de variável declarada com String: " + var3.GetType());  //Classe String

            //Tamanho das variáveis do tipo valor! 
            Console.WriteLine("\nApresentação das variáveis do tipo valor...\n");

            //Interpolação de variáveis!
            string local = "Blumenau-SC";
            Console.WriteLine($"Interpolação ON! Localização: {local}");



            Console.WriteLine("\n\n\n\n\n\n\n\n\nPressione qualquer tecla para sair....");
            Console.ReadKey();  //lê apenas um valor
        }
    }
}
