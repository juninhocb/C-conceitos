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
    public class UPatient : Util, ICrud
    {

        private static List<Tuple<int, string>> LIST_UPACIENTE_MENU = new List<Tuple<int, string>>
            {
                Tuple.Create(5, "VOLTAR AO MENU PRINCIPAL"),
                Tuple.Create(20, "LISTAR PACIENTES"),
                Tuple.Create(21, "CADASTRAR PACIENTES"),
                Tuple.Create(22, "ALTERAR PACIENTES"),
                Tuple.Create(23, "REMOVER PACIENTES")
            };

        public Patient ChooseAndFindPatient(Mocks mock)
        {
            int pCount = 1;
            int updateIndex = -1;
            foreach (Patient p in mock.ListaPacientes)
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

            if (updateIndex > mock.ListaMedicos.Count || updateIndex < 0)
            {
                Print(INVALID_INDEX);
                return null;
            }

            return mock.ListaPacientes.Find(p => p.Code == updateIndex);
        }
        public void Delete(Mocks mock)
        {
            Print(DELETE_MSG);
            Print(SEPARATOR);
            Patient delPatient = ChooseAndFindPatient(mock);
            mock.ListaPacientes.Remove(delPatient);
            WaitFast();
            Print(OPERATION_SUCESS);
        }

        public void List(Mocks mock)
        {
            List<Patient> patientList = mock.ListaPacientes;
            foreach (Patient p in patientList)
            {
                Print(p.FormatedString());
            }
        }

        public void Register(Mocks mock)
        {
            int code = mock.ListaPacientes.Count + 1;
            Print(GET_NAME);
            string name = Scan();
            Print(GET_CPF);
            string cpf = Scan();
            Print(GET_CONVENIO);
            string convenio = Scan();


            Patient newPatient = new Patient(
                code,
                name,
                cpf,
                convenio
                );


            mock.ListaPacientes.Add(newPatient);
            WaitFast();
            Print(OPERATION_SUCESS);
        }


        public void Start(Mocks mock)
        {
            TRY_AGAIN:
            Console.Clear();
            Print(WELCOME_UI_MESSAGE(1));
            Print(SEPARATOR);
            MakeMenu(LIST_UPACIENTE_MENU);
            Print(SEPARATOR);
            bool isValid = Int32.TryParse(Scan(), out int userOption) && OptionValidate(false, userOption-10);
            WaitFast();
            if (!isValid)
            {
                Print(ERR_OPT);
                WaitNewInterface();
                goto TRY_AGAIN;
            }

            switch (userOption)
            {
                case (int)EMenu.GET_PAT:
                    WaitNewInterface();
                    List(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.POST_PAT:
                    WaitNewInterface();
                    Register(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.PUT_PAT:
                    WaitNewInterface();
                    Update(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.DEL_PAT:
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
            Patient updatePatient = ChooseAndFindPatient(mock);
            if (updatePatient == null) { return; }
            WaitFast();
            Print(updatePatient.FormatedString());
            Print(SEPARATOR);
            Print(UPDATE_SND_MSG_P);
            string updateField = Scan();
            if (updateField.ToLower().Equals("nome"))
            {
                Print(GET_NAME);
                updatePatient.Name = Scan();
            }
            else if (updateField.ToLower().Equals("cpf"))
            {
                Print(GET_CPF);
                updatePatient.Cpf = Scan();
            }
            else if (updateField.ToLower().Equals("convenio"))
            {
                Print(GET_CONVENIO);
                updatePatient.HealthInsurance = Scan();
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
