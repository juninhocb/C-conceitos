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
    public class UProvider : Util, ICrud
    {

        private static List<Tuple<int, string>> LIST_UPROVIDER_MENU = new List<Tuple<int, string>>
            {
                Tuple.Create(5, "VOLTAR AO MENU PRINCIPAL"),
                Tuple.Create(30, "LISTAR FORNECEDORES"),
                Tuple.Create(31, "CADASTRAR FORNECEDORES"),
                Tuple.Create(32, "ALTERAR FORNECEDORES"),
                Tuple.Create(33, "REMOVER FORNECEDORES")
            };

        #region Methods

        public int ChooseEnum()
        {
            Print("Escolha uma das opções abaixo!");
            for (int count = 0; count < 7; count++)
            {
                Print($"[{count}]- " + (EProviderType)count);
            }

            int especialityIndex = int.Parse(Scan());
            if (especialityIndex > 6 || especialityIndex < 0)
            {
                Print(INVALID_INDEX + "\n***Será atribuida ao setor \"outros\"");
                especialityIndex = 6;
            }

            return especialityIndex;
        }

        public Provider ChooseAndFindProvider(Mocks mock)
        {
            int pCount = 1;
            int updateIndex = -1;
            foreach (Provider p in mock.ListaFornecedores)
            {
                Print($"{pCount}- " + p.Name.ToString());
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

            if (updateIndex > mock.ListaFornecedores.Count || updateIndex < 0)
            {
                Print(INVALID_INDEX);
                return null;
            }

            return mock.ListaFornecedores.Find(p => p.Code == updateIndex);
        }


        #endregion

        public void Delete(Mocks mock)
        {
            Print(DELETE_MSG);
            Print(SEPARATOR);
            Provider delProvider = ChooseAndFindProvider(mock);
            mock.ListaFornecedores.Remove(delProvider);
            WaitFast();
            Print(OPERATION_SUCESS);
        }

        public void List(Mocks mock)
        {
            List<Provider> providerList = mock.ListaFornecedores;
            foreach (Provider p in providerList)
            {
                Print(p.FormatedString());
            }
        }

        public void Register(Mocks mock)
        {
            int code = mock.ListaMedicos.Count + 1;
            Print(GET_NAME);
            string name = Scan();
            Print(GET_CPF);
            string cpf = Scan();
            Print(GET_TYPE);
            int providerIndex = ChooseEnum();


            Provider newProvider = new Provider(
                code,
                name,
                cpf,
                (EProviderType)providerIndex
                );


            mock.ListaFornecedores.Add(newProvider);
            WaitFast();
            Print(OPERATION_SUCESS);
        }

        public void Start(Mocks mock)
        {
            TRY_AGAIN:
            Console.Clear();
            Print(WELCOME_UI_MESSAGE(2));
            Print(SEPARATOR);
            MakeMenu(LIST_UPROVIDER_MENU);
            Print(SEPARATOR);
            bool isValid = Int32.TryParse(Scan(), out int userOption) && OptionValidate(false, userOption - 20);
            WaitFast();
            if (!isValid)
            {
                Print(ERR_OPT);
                WaitNewInterface();
                goto TRY_AGAIN;
            }

            switch (userOption)
            {
                case (int)EMenu.GET_PRO:
                    WaitNewInterface();
                    List(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.POST_PRO:
                    WaitNewInterface();
                    Register(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.PUT_PRO:
                    WaitNewInterface();
                    Update(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.DEL_PRO:
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
            Provider updateProvider = ChooseAndFindProvider(mock);
            if (updateProvider == null) { return; }
            WaitFast();
            Print(updateProvider.FormatedString());
            Print(SEPARATOR);
            Print(UPDATE_SND_MSG_F);
            string updateField = Scan();
            if (updateField.ToLower().Equals("nome"))
            {
                Print(GET_NAME);
                updateProvider.Name = Scan();
            }
            else if (updateField.ToLower().Equals("cpf"))
            {
                Print(GET_CPF);
                updateProvider.Cpf = Scan();
            }
            else if (updateField.ToLower().Equals("tipo"))
            {
                int typeIndex = ChooseEnum();
                updateProvider.ProviderType = (EProviderType)typeIndex;
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
