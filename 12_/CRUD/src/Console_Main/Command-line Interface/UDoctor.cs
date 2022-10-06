using ClassLibrary_Models.Enums;
using ClassLibrary_Models.Models;
using Console_Main.Interface;
using Console_Main.Utils;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Console_Main.Command_line_Interface
{
    public class UDoctor : Util, ICrud
    {
        private static List<Tuple<int, string>> LIST_UDOCTOR_MENU = new List<Tuple<int, string>>
            {
                Tuple.Create(5, "VOLTAR AO MENU PRINCIPAL"),
                Tuple.Create(10, "LISTAR DOUTORES"),
                Tuple.Create(11, "CADASTRAR DOUTORES"),
                Tuple.Create(12, "ALTERAR DOUTORES"),
                Tuple.Create(13, "REMOVER DOUTORES")
            };

        #region Methods
        public int ChooseEnum()
        {
            Print("Escolha uma das opções abaixo!");
            for (int count = 0; count < 11; count++)
            {
                Print($"[{count}]- " + (ESpeciality)count);
            }

            int especialityIndex = int.Parse(Scan());
            if (especialityIndex > 10 || especialityIndex < 0)
            {
                Print(INVALID_INDEX + "\n***Será atribuida a especialidade de clínco geral");
                especialityIndex = 1;
            }

            return especialityIndex;
        }

        public Doctor ChooseAndFindDoctor(Mocks mock)
        {
            int dCount = 1;
            int updateIndex = -1; 
            foreach (Doctor d in mock.ListaMedicos)
            {
                Print($"{dCount}- " + d.Name.ToString());
                dCount++;
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

            return mock.ListaMedicos.Find(d => d.Code == updateIndex);
        }

        #endregion
        public void Delete(Mocks mock)
        {
            Print(DELETE_MSG);
            Print(SEPARATOR);
            Doctor delDoctor = ChooseAndFindDoctor(mock);
            mock.ListaMedicos.Remove(delDoctor);
            WaitFast();
            Print(OPERATION_SUCESS);
        }

        public void List(Mocks mock)
        {

            List<Doctor> doctorList = mock.ListaMedicos; 
            foreach (Doctor d in doctorList)
            {
                Print(d.FormatedString());
                
            }
        }

        public void Register(Mocks mock)
        {

            int code = mock.ListaMedicos.Count + 1;
            Print(GET_NAME);
            string name = Scan();
            Print(GET_CPF);
            string cpf = Scan();
            Print(GET_Adress);
            string adr = Scan(); //Obsoleto
            Print(GET_CRM);
            int crm = int.Parse(Scan());
            int especialityIndex = ChooseEnum();


            Doctor newDoctor = new Doctor(
                code, 
                name,
                cpf,
                crm, 
                (ESpeciality)especialityIndex
                );
            

            mock.ListaMedicos.Add(newDoctor);
            WaitFast();
            Print(OPERATION_SUCESS);
            
           
        }

        public void Start(Mocks mock)
        {
            TRY_AGAIN:
            Console.Clear();
            Print(WELCOME_UI_MESSAGE(0));
            Print(SEPARATOR);
            MakeMenu(LIST_UDOCTOR_MENU);
            Print(SEPARATOR);
            bool isValid = Int32.TryParse(Scan(), out int userOption) && OptionValidate(false, userOption);
            WaitFast();
            if (!isValid)
            {
                Print(ERR_OPT);
                WaitNewInterface();
                goto TRY_AGAIN;
            }

            switch (userOption)
            {
                case (int)EMenu.GET_DOC:
                    WaitNewInterface();
                    List(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.POST_DOC:
                    WaitNewInterface();
                    Register(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.PUT_DOC:
                    WaitNewInterface();
                    Update(mock);
                    ReturnStatement();
                    goto TRY_AGAIN;
                case (int)EMenu.DEL_DOC:
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
            Doctor updateDoctor = ChooseAndFindDoctor(mock);
            if (updateDoctor == null) { return;  }
            WaitFast();
            Print(updateDoctor.FormatedString());
            Print(SEPARATOR);
            Print(UPDATE_SND_MSG);
            string updateField = Scan();
            if (updateField.ToLower().Equals("nome"))
            {
                Print(GET_NAME);
                updateDoctor.Name = Scan();
            } else if (updateField.ToLower().Equals("cpf")) {
                Print(GET_CPF);
                updateDoctor.Cpf = Scan();
            } else if (updateField.ToLower().Equals("crm"))
            {
                Print(GET_CRM);
                updateDoctor.Crm = int.Parse(Scan());
            } else if (updateField.ToLower().Equals("especialidade"))
            {
                int espcialityIndex = ChooseEnum();
                updateDoctor.Speciality = (ESpeciality)espcialityIndex;
            } else
            {
                Print(INVALID_INDEX);
                return;
            }

            WaitFast();
            Print(OPERATION_SUCESS);

        }
    }
}
