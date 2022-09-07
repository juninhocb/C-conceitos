using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Strings
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "2 Trabalhando com Strings";
            string falarOla = "      Olá Mundo    ";
            string olaCortado;
            //funções úteis
            //retirando espaço vazios
            Console.WriteLine("Olá mundo sem alterações: [" + falarOla + "]");
            olaCortado = falarOla.TrimEnd();
            Console.WriteLine("Olá mundo retirando os espaços do final: [" + olaCortado + "]");
            olaCortado = falarOla.TrimStart();
            Console.WriteLine("Olá mundo retirando os espaços do inicio: [" + olaCortado + "]" );
            olaCortado = falarOla.Trim();
            Console.WriteLine("Olá mundo retirando todos os espaços: [" + olaCortado + "]");
            //substituição de cadeia de caracteres
            string olaSubstituido;
            olaSubstituido = olaCortado.Replace("Olá", "Hello");
            Console.WriteLine("Olá modificado para Hello: " + olaSubstituido);
            //MAIUSCULO e minusculo
            string olaMinusculo;
            olaMinusculo = olaCortado.ToLower();
            Console.WriteLine("Olá minusculo: " + olaMinusculo);
            string olaMaiusculo;
            olaMaiusculo = olaCortado.ToUpper();
            Console.WriteLine("Olá maiusculo: " + olaMaiusculo);
            //Pesquisando uma substring dentro de uma string
            string musicaBeatles = "You say goodbye, and i say hello";
            Console.WriteLine("string " + musicaBeatles);
            // o método Contains irá retornar true ou false caso haja ou não a substring dentro da string
            Console.WriteLine(musicaBeatles.Contains("goodbye"));
            Console.WriteLine(musicaBeatles.Contains("palmeiras"));
            if (musicaBeatles.StartsWith("You"))
            {
                Console.WriteLine("Editando a musica para: " + musicaBeatles.Replace("You", "i"));
            }
            if (musicaBeatles.EndsWith("hello"))
            {
                Console.WriteLine($"Editadno a musica para: {musicaBeatles.Replace("hello", "you")}");
            }

            Console.ReadKey();
        }
    }
}
