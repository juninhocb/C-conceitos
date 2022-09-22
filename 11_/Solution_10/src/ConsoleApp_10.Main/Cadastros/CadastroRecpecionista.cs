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
    public class CadastroRecepcionista
    {

        public CadastroRecepcionista()
        {

        }

        public void MenuCadastro()
        {
            int opcao = 0;


            do
            {
                Console.WriteLine("----- Cadastro de Recepcionistas -----");
                   
                Console.WriteLine("----- 1 - Lista de Recepcionistas -----");
                Console.WriteLine("----- 2 - Cadastro de Recepcionistas -----");
                Console.WriteLine("----- 3 - Alterar Recepcionistas -----");
                Console.WriteLine("----- 4 - Alterar Recepcionistas -----");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("----- 0 - Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao); 

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarRecepcionista();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarRecepcionista();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarRecepcionista();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirRecepcionista();
                        break;
                    case (int)MenuEnums.SAIR:
                        Sair();
                        break; 
                    default:
                        break;


                }





            } while (!opcao.Equals(MenuEnums.SAIR)); 

        }

        public void ListarRecepcionista()
        {
            Console.Clear();

            for (int i = 0; i < Program.Mock.ListaRecepcionistas.Count; i++)
            {
                
                Recepecionista r = Program.Mock.ListaRecepcionistas[i];
                Console.WriteLine($"For \n| ID -> {r.Codigo} | Nome -> {r.Nome} | CPF -> {r.CGCCPF} | Setor -> {r.Setor}");
                Console.WriteLine("----------------------------------------------\n");
            }

            //foreach (Recepcionista p in mock.ListaRecepcionistas)
            foreach (Recepecionista r in Program.Mock.ListaRecepcionistas)
            {
                Console.WriteLine($"ForEach \n| ID -> {r.Codigo} | Nome -> {r.Nome} | CPF -> {r.CGCCPF} | Setor -> {r.Setor}");
                Console.WriteLine("----------------------------------------------\n");
            }
        }

        public void CadastrarRecepcionista()
        {

        }

        public void AlterarRecepcionista()
        {

        }

        public void ExcluirRecepcionista()
        {

        }

        public void Sair()
        {
            Environment.Exit(0);
        }


    }
}
