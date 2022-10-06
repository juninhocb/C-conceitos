using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ClassLibrary_Models.Enums;
using ClassLibrary_Models.Models;
using Console_Main.Utils;

namespace Console_Main.Command_line_Interface
{
    
    public class UMenu : Util
    {
        private const string WELCOME_MESSAGE = "Bem vindo ao CRUD, escolha uma opção!";
        private const string WELCOME_AGAIN = "Escolha uma opção";
        private const string EXIT_MESSAGE = "Fechando a aplicação... adeus...";
        private static List<Doctor> DEFAULT_LIST_OF_DOCTORS = new List<Doctor>
        {
            new Doctor(
            1,
            "Dr. Pedro",
            "438.343.234-53",
            124432,
            ESpeciality.ANESTESIOLOGISTA
            ),

            new Doctor(
            2,
            "Dr. José",
            "123.313.999-59",
            127832,
            ESpeciality.CARDIOLOGISTA
            ),

            new Doctor(
            3,
            "Dra. Simone",
            "865.333.125-51",
            025698,
            ESpeciality.DERMATOLOGISTA
            ),

            new Doctor(
            4,
            "Dra. Ana",
            "235.456.236-35",
            242346,
            ESpeciality.PSIQUIATRA
            ),

            new Doctor(
            5,
            "Dra. Paula",
            "534.456.896-39",
            294864,
            ESpeciality.ONCOLOGISTA
            ),

        };
        private static List<Patient> DEFAULT_LIST_OF_PATIENTS = new List<Patient>
        {   
            new Patient(
            1,
            "Ricado",
            "438.343.234-53",
            "UNIMED"
            ),

            new Patient(
            2,
            "Paula",
            "234.333.934-32",
            "SUL AMERICA"
            ),

            new Patient(
            3,
            "Ana",
            "345.012.431-15",
            "SUL AMERICA"
            ),

            new Patient(
            4,
            "Plinio",
            "234.423.121-90",
            "SUS"
            ),

            new Patient(
            5,
            "Joao",
            "120.000.121-12",
            "UNIMED"
            ),


        };
        private static List<Provider> DEFAULT_LIST_OF_PROVIDERS = new List<Provider>
        {
            new Provider(
            1,
            "José",
            "124.453.111-12",
            EProviderType.FROTA
            ),

            new Provider(
            2,
            "Maria",
            "683.332.239-83",
            EProviderType.REMEDIOS
            ),

            new Provider(
            3,
            "Joaquina",
            "213.222.214-53",
            EProviderType.SERVICOS_GERAIS
            ),

            new Provider(
            4,
            "Zé",
            "534.756.423-34",
            EProviderType.TECNOLOGIA
            ),

            new Provider(
            5,
            "Beatriz",
            "125.632.987-43",
            EProviderType.PAPELARIA
            ),




        };
        private static List<Recepcionist> DEFAULT_LIST_OF_RECEPCIONISTS = new List<Recepcionist>
        {
            new Recepcionist(
            1,
            "Carla",
            "121.120.124-12",
            'C'
            ),

            new Recepcionist(
            2,
            "Maria",
            "113.656.645-35",
            'A'
            ),

            new Recepcionist(
            3,
            "Rebeca",
            "777.211.438-63",
            'A'
            ),

            new Recepcionist(
            4,
            "Zeca",
            "182.971.112-31",
            'B'
            ),

            new Recepcionist(
            5,
            "Rui",
            "126.938.923-34",
            'A'
            ),




        };
        private static List<Tuple<int, string>> LIST_MAIN_MENU = new List<Tuple<int, string>>
            {
                Tuple.Create(0, "SAIR"),
                Tuple.Create(1, "DOUTORES"),
                Tuple.Create(2, "PACIENTES"),
                Tuple.Create(3, "FORNECEDORES"),
                Tuple.Create(4, "RECEPCIONISTAS")
            };

        Mocks mock = new Mocks();
        UDoctor doctorInterface = new UDoctor();
        UPatient patientInterface = new UPatient();
        UProvider providerInterface = new UProvider();
        URecepcionist recepcionistInterface = new URecepcionist();


        public void Start(bool isRestart)
        {   
            if (!isRestart) { ChargeMock(mock); }
            TRY_AGAIN:
            WaitNewInterface();
            Print(GetWelcomeMsg(isRestart));
            isRestart = true;
            Print(SEPARATOR);
            MakeMenu(LIST_MAIN_MENU);
            Print(SEPARATOR);
            bool isValid = Int32.TryParse(Scan(),out int userOption) && OptionValidate(true, userOption);
            WaitFast(); 
            if (!isValid) { 
                Print(ERR_OPT); 
                goto TRY_AGAIN;
            }
            
            switch (userOption) {
                case (int)EMenu.DOCTORS:
                    WaitNewInterface();
                    doctorInterface.Start(mock); 
                    goto TRY_AGAIN;
                case (int)EMenu.PATIENTS:
                    WaitNewInterface();
                    patientInterface.Start(mock);
                    goto TRY_AGAIN;
                case (int)EMenu.PROVIDERS:
                    WaitNewInterface();
                    providerInterface.Start(mock);
                    break;
                case (int)EMenu.RECEPCIONISTS:
                    WaitNewInterface();
                    recepcionistInterface.Start(mock);  
                    break;
                case (int)EMenu.EXIT:
                default:
                    break;
            }

            
            Print(EXIT_MESSAGE);
            Thread.Sleep(1000);
        }

        internal static string GetWelcomeMsg(bool fstEntry) => !fstEntry ? WELCOME_MESSAGE : WELCOME_AGAIN;

        internal static void ChargeMock(Mocks mock)
        {
            
            mock.CargaMedicos(DEFAULT_LIST_OF_DOCTORS);
            mock.CargaPacientes(DEFAULT_LIST_OF_PATIENTS);
            mock.CargaFornecedores(DEFAULT_LIST_OF_PROVIDERS);
            mock.CargaRecepcionistas(DEFAULT_LIST_OF_RECEPCIONISTS);

        }

    }
}
