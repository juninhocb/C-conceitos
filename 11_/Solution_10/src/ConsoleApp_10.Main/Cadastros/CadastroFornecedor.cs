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
    public class CadastroFornecedor
    {

        public CadastroFornecedor()
        {

        }

        public void MenuCadastro()
        {
            int opcao = 0;


            do
            {
                Console.WriteLine("----- Cadastro de Fornecedores -----");
                   
                Console.WriteLine("----- 1 - Lista de Fornecedores -----");
                Console.WriteLine("----- 2 - Cadastro de Fornecedores -----");
                Console.WriteLine("----- 3 - Alterar Fornecedores -----");
                Console.WriteLine("----- 4 - Alterar Fornecedores -----");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("----- 0 - Sair -----");
                Int32.TryParse(Console.ReadLine(), out opcao); 

                switch (opcao)
                {
                    case (int)MenuEnums.LISTAR:
                        ListarFornecedor();
                        break;
                    case (int)MenuEnums.CADASTRAR:
                        CadastrarFornecedor();
                        break;
                    case (int)MenuEnums.ALTERAR:
                        AlterarFornecedor();
                        break;
                    case (int)MenuEnums.EXCLUIR:
                        ExcluirFornecedor();
                        break;
                    case (int)MenuEnums.SAIR:
                        Sair();
                        break; 
                    default:
                        break;


                }





            } while (!opcao.Equals(MenuEnums.SAIR)); 

        }

        public void ListarFornecedor()
        {
            Console.Clear();

            for (int i = 0; i < Program.Mock.ListaFornecedores.Count; i++)
            {
                
                Fornecedor f = Program.Mock.ListaFornecedores[i];
                Console.WriteLine($"For \n| ID -> {f.Codigo} | Nome -> {f.Nome} | CPF -> {f.CGCCPF} | Tipo de Fornecedor -> {f.TipoFornecedor}");
                Console.WriteLine("----------------------------------------------\n");
            }

            //foreach (Fornecedor p in mock.ListaFornecedors)
            foreach (Fornecedor f in Program.Mock.ListaFornecedores)
            {
                Console.WriteLine($"ForEach \n| ID -> {f.Codigo} | Nome -> {f.Nome} | CPF -> {f.CGCCPF} | Tipo de Fornecedor -> {f.TipoFornecedor}");
                Console.WriteLine("----------------------------------------------\n");
            }
        }

        public void CadastrarFornecedor()
        {

        }

        public void AlterarFornecedor()
        {

        }

        public void ExcluirFornecedor()
        {

        }

        public void Sair()
        {
            Environment.Exit(0);
        }


    }
}
