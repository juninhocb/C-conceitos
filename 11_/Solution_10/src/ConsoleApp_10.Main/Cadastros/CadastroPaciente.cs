using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary10_.Models;
using ConsoleApp_10.Main.Utils;
using ConsoleApp_10.Main.Utils.Enums;

namespace ConsoleApp_10.Main.Cadastros
{
    public class CadastroPaciente
    {

        public CadastroPaciente()
        {

        }

        public void MenuCadastro()
        {
            int opcao = 0;


            do
            {
                Console.WriteLine("----- Cadastro de Pacientes -----");
                   
                Console.WriteLine("----- 1 - Lista de Pacientes -----");
                Console.WriteLine("----- 2 - Cadastro de Pacientes -----");
                Console.WriteLine("----- 3 - Alterar Pacientes -----");
                Console.WriteLine("----- 4 - Alterar Pacientes -----");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("----- 0 - Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao); 

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarPaciente();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarPaciente();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarPaciente();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirPaciente();
                        break;
                    case (int)MenuEnums.SAIR:
                        Sair();
                        break; 
                    default:
                        break;


                }





            } while (!opcao.Equals(MenuEnums.SAIR)); 

        }

        public void ListarPaciente()
        {
            Console.Clear();

            for (int i = 0; i < Program.Mock.ListaPacientes.Count; i++)
            {
                Paciente p = Program.Mock.ListaPacientes[i];
                Console.WriteLine($"For \n| ID -> {p.Codigo} | Nome -> {p.Nome} | CPF -> {p.CGCCPF} | Convenio -> {p.Convenio}");
                Console.WriteLine("----------------------------------------------\n");
            }

            //foreach (Paciente p in mock.ListaPacientes)
            foreach (Paciente p in Program.Mock.ListaPacientes)
            {
                Console.WriteLine($"ForEach \n| ID -> {p.Codigo} | Nome -> {p.Nome} | CPF -> {p.CGCCPF} | Convenio -> {p.Convenio}");
                Console.WriteLine("----------------------------------------------\n");
            }
        }

        public void CadastrarPaciente()
        {

        }

        public void AlterarPaciente()
        {

        }

        public void ExcluirPaciente()
        {

        }

        public void Sair()
        {
            Environment.Exit(0);
        }


    }
}
