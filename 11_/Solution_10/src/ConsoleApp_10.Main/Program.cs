using ClassLibrary10_.Models;
using ConsoleApp_10.Main.Cadastros;
using ConsoleApp_10.Main.Utils;
using ConsoleApp_10.Main.Utils.Enums;
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
            int opcao = 0;


            do
            {
                Console.Clear();
                Console.WriteLine("----- 10- Cadastro de Pacientes -----");
                Console.WriteLine("----- 20- Cadastro de Médicos -----");
                Console.WriteLine("----- 30- Cadastro de Rececpionistas -----");
                Console.WriteLine("----- 40- Cadastro de Fornecedores -----");
                Console.WriteLine("----- 50- Agenda -----");
                Console.WriteLine("----- 60- Prontuário -----");
                Console.WriteLine("----- 70- Financeiro -----");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("----- 0- Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao);

                switch (opcao)
                {
                    case (int)MenuEnums.CAD_PAC:
                        CadastroPaciente ModuloCadastroPacientes = new CadastroPaciente();
                        ModuloCadastroPacientes.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_MED:
                        CadastroMedico ModuloCadastroMedicos = new CadastroMedico();
                        ModuloCadastroMedicos.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_REC:
                        CadastroRecepcionista ModuloCadastroRecepcionistas= new CadastroRecepcionista();
                        ModuloCadastroRecepcionistas.MenuCadastro();
                        break;
                    case (int)MenuEnums.CAD_FOR:
                        CadastroFornecedor ModuloCadastroFornedcedores = new CadastroFornecedor();
                        ModuloCadastroFornedcedores.MenuCadastro();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        //ExcluirPaciente(mock);
                        break;
                    case (int)MenuEnums.SAIR:
                        Sair();
                        break;
                    default:
                        break;
                }

            } while (!opcao.Equals(MenuEnums.SAIR)); 
            Console.ReadKey();
        }


        public static void Sair()
            {
                Environment.Exit(0);
            }

        }
}
