using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary10_.Models;
using ClassLibrary10_.Models.Model;
using ConsoleApp_10.Main.Utils;
using ConsoleApp_10.Main.Utils.Enums;

namespace ConsoleApp_10.Main.Cadastros
{
    public class CadastroMedico
    {

        public CadastroMedico()
        {

        }

        public void MenuCadastro()
        {
            int opcao = 0;


            do
            {
                Console.WriteLine("----- Cadastro de Medicos -----");
                   
                Console.WriteLine("----- 1 - Lista de Medicos -----");
                Console.WriteLine("----- 2 - Cadastro de Medicos -----");
                Console.WriteLine("----- 3 - Alterar Medicos -----");
                Console.WriteLine("----- 4 - Alterar Medicos -----");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("----- 0 - Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao); 

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarMedico();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarMedico();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarMedico();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirMedico();
                        break;
                    case (int)MenuEnums.SAIR:
                        Sair();
                        break; 
                    default:
                        break;


                }





            } while (!opcao.Equals(MenuEnums.SAIR)); 

        }

        public void ListarMedico()
        {
            Console.Clear();

            for (int i = 0; i < Program.Mock.ListaMedicos.Count; i++)
            {
                Medico m = Program.Mock.ListaMedicos[i];
                Console.WriteLine($"For \n| ID -> {m.Codigo} | Nome -> {m.Nome} | CPF -> {m.CGCCPF} | CRM -> {m.CRM} | Especialidade -> {m.Especial}");
                 
                Console.WriteLine("----------------------------------------------\n");
            }

            //foreach (Medico p in mock.ListaMedicos)
            foreach (Medico m in Program.Mock.ListaMedicos)
            {
                Console.WriteLine($"ForEach \n| ID -> {m.Codigo} | Nome -> {m.Nome} | CPF -> {m.CGCCPF} | CRM -> {m.CRM} | Especialidade -> {m.Especial} ");
                Console.WriteLine("----------------------------------------------\n");
            }
        }

        public void CadastrarMedico()
        {

        }

        public void AlterarMedico()
        {

        }

        public void ExcluirMedico()
        {

        }

        public void Sair()
        {
            Environment.Exit(0);
            //Process.Start("SUA_APLICACAO.exe");
        }


    }
}
