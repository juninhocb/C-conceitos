using ClassLibrary_Models.Enums;
using ClassLibrary_Models.Models;
using Console_Main.Interface;
using Console_Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Main.Command_line_Interface
{
    public class URecepcionist : Util, ICrud
    {

        private static List<Tuple<int, string>> LIST_UPROVIDER_MENU = new List<Tuple<int, string>>
            {
                Tuple.Create(5, "VOLTAR AO MENU PRINCIPAL"),
                Tuple.Create(40, "LISTAR RECEPCIONISTAS"),
                Tuple.Create(41, "CADASTRAR RECEPCIONISTAS"),
                Tuple.Create(42, "ALTERAR RECEPCIONISTAS"),
                Tuple.Create(43, "REMOVER RECEPCIONISTAS")
            };

        public Recepcionist ChooseAndFindRecepcionist(Mocks mock)
        {

            //TODO: Resolver esses métodos de uma forma melhor.
            int pCount = 1;
            int updateIndex = -1;
            foreach (Recepcionist r in mock.ListaRecepcionistas)
            {
                Print($"{pCount}- " + r.Name.ToString());
                pCount++;
            }
            try
            {
                updateIndex = int.Parse(Scan());
            }
            catch (Exception exception)
            {
                Print(exception.StackTrace);
            }

            if (updateIndex > mock.ListaRecepcionistas.Count || updateIndex < 0)
            {
                Print(INVALID_INDEX);
                return null;
            }

            return mock.ListaRecepcionistas.Find(r => r.Code == updateIndex);
        }

        public void Delete(Mocks mock)
        {
            Print(DELETE_MSG);
            Print(SEPARATOR);
            Recepcionist delRecepcionist = ChooseAndFindRecepcionist(mock);
            mock.ListaRecepcionistas.Remove(delRecepcionist);
            WaitFast();
            Print(OPERATION_SUCESS);
        }

        public void List(Mocks mock)
        {
            List<Recepcionist> recepcionistList = mock.ListaRecepcionistas;
            foreach (Recepcionist r in recepcionistList)
            {
                Print(r.FormatedString());
            }
        }

        public void Register(Mocks mock)
        {
            int code = mock.ListaRecepcionistas.Count + 1;
            Print(GET_NAME);
            string name = Scan();
            Print(GET_CPF);
            string cpf = Scan();
            Print(GET_TYPE);
            char sector = (char)Console.ReadKey().Key;


            Recepcionist newRecepcionist = new Recepcionist(
                code,
                name,
                cpf,
                sector
                );


            mock.ListaRecepcionistas.Add(newRecepcionist);
            WaitFast();
            Print(OPERATION_SUCESS);
        }
        public void Start(Mocks mock)
        {
            TRY_AGAIN:
            Console.Clear();
            Print(WELCOME_UI_MESSAGE(3));
            Print(SEPARATOR);
            MakeMenu(LIST_UPROVIDER_MENU);
            Print(SEPARATOR);
            bool isValid = Int32.TryParse(Scan(), out int userOption) && OptionValidate(false, userOption - 30);
            WaitFast();
            if (!isValid)
            {
                Print(ERR_OPT);
                WaitNewInterface();
                goto TRY_AGAIN;
            }

            switch (userOption)
            {
                case (int)EMenu.GET_REC:
                    WaitNewInterface();
                    List(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.POST_REC:
                    WaitNewInterface();
                    Register(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.PUT_REC:
                    WaitNewInterface();
                    Update(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.DEL_REC:
                    WaitNewInterface();
                    Delete(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.BACK:
                    break;
                default:
                    goto TRY_AGAIN;

            }

            return;



        }

        public void Update(Mocks mock)
        {
            Print(UPDATE_MSG);
            Recepcionist updateRecepcionist = ChooseAndFindRecepcionist(mock);
            if (updateRecepcionist == null) { return; }
            WaitFast();
            Print(updateRecepcionist.FormatedString());
            Print(SEPARATOR);
            Print(UPDATE_SND_MSG_R);
            string updateField = Scan();
            if (updateField.ToLower().Equals("nome"))
            {
                Print(GET_NAME);
                updateRecepcionist.Name = Scan();
            }
            else if (updateField.ToLower().Equals("cpf"))
            {
                Print(GET_CPF);
                updateRecepcionist.Cpf = Scan();
            }
            else if (updateField.ToLower().Equals("setor"))
            {
                Print(GET_Sector);
                updateRecepcionist.Sector = Console.ReadKey().KeyChar.ToString().ToUpper()[0];
                Print("\n");
            }
            else
            {
                Print(INVALID_INDEX);
                return;
            }

            WaitFast();
            Print(OPERATION_SUCESS);
        }
    }
}
