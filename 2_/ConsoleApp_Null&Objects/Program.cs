using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main()
        {
            
            Console.Title = "Aula_2 Valors nulos e Objetos";
            string nomeNull;
            //string nomeNaoIniciado; comentado apenas para não gerar warnings, pois esta variável não sera utilizada! 
            nomeNull = null;
            Console.WriteLine("Valor nulo da string: " + nomeNull);
            //Console.WriteLine("Valor do nome não inicado: " + nomeNaoIniciado); erro pois não há inicialização da variável

            //conversão de uma variável TIPO VALOR para TIPO REFERENCIA e vice-versa
            int i = 123;
            object o = i;  //conversão BOXING (converter um tipo valor para referência)
            int j = (int)o; //conversão UNBOXING (converter tipo referência para tipo valor)

            Console.WriteLine($"Valor de (INT)i: {i}, Valor de (OBJECT)o: {o}, Valor de (INT)j: {j}");
            Console.WriteLine($"Tipo de i: {i.GetType()}, Tipo de o: {o.GetType()}, Tipo de j: {j.GetType()}");

            //float x = (float)o; //NÃO PERMITIDO  (1)

            /*
                Um tipo referência (object) possui uma "caixa" com um valor (do tipo valor), 
                a "caixa" é uma instância do tipo referência e dentro dela possui o tipo valor
                quando fazemos o unboxing para converter um tipo referência para o tipo valor 
                é realizada uma verificação para verificar se o tipo solicitado é igual ao tipo 
                valor armazenado dentro da "caixa", caso a verificação seja bem sucedidada, este
                valor (tipo-valor) é copiada, caso contrário, gerará uma excessão em tempo de 
                execução, percebemos que a instrução (1), é permitida, e não gera erros no compilador
                porém, haverá uma excessão ao executar este código devido a verificação de unboxing supracitada
            */

            float x = (float)i; // PERMITIDO
            Console.WriteLine($"Valor de (FLOAT)x: {x}, Tipo de x: {x.GetType()}"); // 123, System.Single

            float y = 2.4F;  
            Console.WriteLine("Valor do meu novo float: " + y + " Tipo do meu novo float: " + y.GetType()); // 2.4, System.Single

            double y1 = 2.4D;
            Console.WriteLine("Valor do meu novo double: " + y1 + " Taipo do meu novo double: " + y1.GetType()); // 2.4, System.Double

            decimal y2 = 2.4M;
            Console.WriteLine("Valor do meu novo decimal: " + y2 + " Tipo do meu novo decimal: " + y2.GetType()); // 2.4, System.Decimal
            //FLOAT = SYSTEM.SINGLE PRECISAO DE 6 a 9 DIGITOS - 4 BYTES
            //DOUBLE = SYSTEM.DOUBLE PRECISAO DE 15 a 17 DIGITOS - 8 BYTES
            //DECIMA = SYSTEM.DECIMAL PRECISAO DE 28 a 29 DIGITOS - 16 BYTES



            Console.ReadKey();

        }

        
    }
}
