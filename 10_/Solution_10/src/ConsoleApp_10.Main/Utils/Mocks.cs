using ClassLibrary10_.Models;
using ClassLibrary10_.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_10.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set;  }

        public List<Medico> ListaMedicos { get; set; }

        public List<Recepecionista> ListaRecepcionistas { get; set; }

        public List<Fornecedor> ListaForncedores { get; set; }


        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaForncedores = new List<Fornecedor>(); 
            ListaRecepcionistas = new List<Recepecionista>();

            CargaMock();
        }

        public void CargaMock()
        {
            CargaPacientes(); 
        }

        public void CargaPacientes()
        {
            for (int i=0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i}", $"{i}23456{i}9{i}{i}{i}", "Unimed" );
                ListaPacientes.Add(paciente);
            }


        }

    }
}
