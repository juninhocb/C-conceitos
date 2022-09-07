using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // programa para explicitar as diferenças de variáveis criadas por tipo de valor e por referência
            int i = 1;  //tipo valor
            int j = i; 
            j++;
            Teste t1 = new Teste();  //referência
            Teste t2 = t1;
            t1.x = 20;
            t1.y = 30;
            Console.WriteLine("O valor de i é {0} e o valor de j é {1}", i, j);
            Console.WriteLine(t2.ToString());
            t2.y++;
            Console.WriteLine(t1.ToString());


            Console.WriteLine($"Casting j to char, give us a result like this {(char)j}");
            


            Console.WriteLine("Pressione qualquer botão para sair");
            Console.ReadKey();
           
            
        
        }
    }
    
    public class Teste
    {
        public Int32 x;
        public Int32 y;
        public int z;
        public override string ToString()
        {
            return "O Valor da instância é " + x + " para X e " + y + " para Y.";
        }

    }
}
