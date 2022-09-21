using ClassLibrary10_.Models;
using ConsoleApp_10.Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_10.Main
{
    internal class Program
    {
        public static Mocks Mock { get; set; }
        static void Main()
        {
            Console.Title = "Aula 10";
            Mock =  new Mocks();
            ViewListPacientes();
            Console.ReadKey();
        }


        public static void ViewListPacientes()
        {
            Console.Clear(); 

            for (int i = 0; i < Mock.ListaPacientes.Count; i++)
            {
                Paciente p = Mock.ListaPacientes[i];
                Console.WriteLine($"For \n| ID -> {p.Codigo} | Nome -> {p.Nome} | CPF -> {p.CGCCPF} | Convenio -> {p.Convenio}");
                Console.WriteLine("----------------------------------------------\n");
            }

            foreach (Paciente p in Mock.ListaPacientes)
            {
                Console.WriteLine($"ForEach \n| ID -> {p.Codigo} | Nome -> {p.Nome} | CPF -> {p.CGCCPF} | Convenio -> {p.Convenio}");
                Console.WriteLine("----------------------------------------------\n");
            }
        }

    }
}
