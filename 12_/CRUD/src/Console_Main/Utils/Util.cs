using ClassLibrary_Models.Enums;
using ClassLibrary_Models.Models;
using Console_Main.Command_line_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Console_Main.Utils
{
    public class Util
    {

        static String[] uiNames = { "Doutores", "Pacientes", "Fornecedeores", "Recepcionistas" };
        private const string WAIT_MSG = "Por Favor, Aguarde";
        private const string WAITING = "...";
        private const string WAIT_FAST_MSG = "Por Favor, Aguarde um momento!";
        public const string ERR_OPT = "Opção inválida, por favor, tente novamente!";
        public const string SEPARATOR = "--------------------------------------------------------";
        public const string USER_OUT_MENU = "Digite qualquer tecla para voltar ao menu anterior.";
        public const string GET_NAME = "Por favor, Digite um Nome";
        public const string GET_CPF = "Por favor, Digite o CPF";
        public const string GET_CRM = "Por favor, Digite o CRM";
        public const string GET_CONVENIO = "Por favor, Digite o convênio";
        public const string GET_TYPE = "Por favor, Escolhao o índice de fornecedor de acordo com a lista";
        public const string GET_Adress = "Por favor, Digite o Endreço";
        public const string GET_Sector = "Por favor, Digite um caractere relacionado ao setor.";
        public const string OPERATION_SUCESS = "Operação concluida com Sucesso!";
        public const string UPDATE_MSG = "Por favor, Digite o índice da pessoa que quer alterar.";
        public const string DELETE_MSG = "Por favor, Digite o índice da pessoa que quer excluir.";
        public const string INVALID_INDEX = "Índice inválido!";
        public const string BACK_MAIN_MENU = "Voltando ao menu inicial";
        public const string UPDATE_SND_MSG = "Por favor, Digite qual campo deseja alterar \n" +
            "Campos: [Nome] - [CPF] - [CRM] - [ESPECIALIDADE]";
        public const string UPDATE_SND_MSG_P = "Por favor, Digite qual campo deseja alterar \n" +
            "Campos: [Nome] - [CPF] - [Convenio]";
        public const string UPDATE_SND_MSG_F = "Por favor, Digite qual campo deseja alterar \n" +
            "Campos: [Nome] - [CPF] - [Tipo]";
        public const string UPDATE_SND_MSG_R = "Por favor, Digite qual campo deseja alterar \n" +
            "Campos: [Nome] - [CPF] - [Setor]";


        //UMenu mainMenu = new UMenu();

        #region ALL_PROGRAM
        public void Print(string word) => Console.WriteLine(word);

        public void PrintInLine(string word) => Console.Write(word);

        public string Scan() => Console.ReadLine();

        public void ReturnStatement()
        {
            Print(SEPARATOR + $"\n{USER_OUT_MENU}");
            Console.ReadKey();
        }

        
        public void MakeMenu(List<Tuple<int, string>>  list)
        { 
            foreach (Tuple<int, string> menuData in list)
            {
                Print($"{menuData.Item1}- {menuData.Item2}");      
            } 

        }

        public bool OptionValidate(bool isMainMenu, int opt)
        {
            if (isMainMenu && (opt == 1 || opt == 2 || opt == 3 || opt == 4 || opt == 0) )
            {
                return true;
            } else if (!isMainMenu && (opt == 5 || opt == 10 || opt == 11 || opt == 12 || opt == 13 || opt == -5 || opt == -15 || opt == -25) )
            {
                return true; 
            } 

            return false; 
        }

        public void WaitNewInterface() {
            Print(WAIT_MSG);
            Thread.Sleep(2000);
            PrintInLine(WAITING);
            Thread.Sleep(1000);
            PrintInLine(WAITING);
            Thread.Sleep(1000);
            PrintInLine(WAITING);
            Console.Clear();
        }
        public void WaitFast() {
            Print(WAIT_FAST_MSG); 
            Thread.Sleep(1000);
            Print(WAITING);
            Thread.Sleep(1000); 
            Console.Clear();
        }
        public string WELCOME_UI_MESSAGE(short uType) => $"Bem vindo a interface de {uiNames[uType]}";


        #endregion



    }
}
