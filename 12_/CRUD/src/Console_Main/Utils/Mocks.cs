using ClassLibrary_Models.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Console_Main.Utils
{
    
    public class Mocks
    {
        public List<Patient> ListaPacientes { get; set; }

        public List<Doctor> ListaMedicos { get; set; }

        public List<Recepcionist> ListaRecepcionistas { get; set; }

        public List<Provider> ListaFornecedores { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Patient>();
            ListaMedicos = new List<Doctor>();
            ListaFornecedores = new List<Provider>();
            ListaRecepcionistas = new List<Recepcionist>();

        }

        public void CargaPacientes(List <Patient> list)
        {
            foreach (Patient p in list)
            {
                ListaPacientes.Add(p);
            }
        }

        public void CargaMedicos(List <Doctor> list)
        {
            foreach (Doctor d in list)
            {
                ListaMedicos.Add(d);
            }
        }

        public void CargaRecepcionistas(List <Recepcionist> list)
        {
            foreach (Recepcionist r in list)
            {
                ListaRecepcionistas.Add(r);
            }
        }

        public void CargaFornecedores (List<Provider> list)
        {
            foreach (Provider p in list)
            {
                ListaFornecedores.Add(p);
            }
        }


    }
}
