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

        public List<Fornecedor> ListaFornecedores { get; set; }

        Random random = new Random();
        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaFornecedores = new List<Fornecedor>(); 
            ListaRecepcionistas = new List<Recepecionista>();

            CargaMock();
        }

        public void CargaMock()
        {
            CargaPacientes();
            CargaMedicos();
            CargaRecepcionistas();
            CargaForncedores();
        }

        public void CargaPacientes()
        {
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i}", $"{i}23456{i}9{i}{i}{i}", "Unimed");
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedicos()
        {   
            for (int i = 0; i < 10; i++)
            {
                string[] especialidades = { "Ortopedista", "Clínico Geral", "Pediatra", "Neuro" };
                
                int randomEspeciality = random.Next(0, 4);
                Medico medico = new Medico(i, "Medico {i}", $"{i}23456{i}9{i}{i}{i}", (i * i) + 124723 + i + 2, especialidades[randomEspeciality]);
                ListaMedicos.Add(medico);
            }
        }

        public void CargaRecepcionistas()
        {
            for (int i = 0; i < 10; i++)
            {
                string[] setores = { "Atendimento", "Farmácia", "Secretária do Médico", "Bloco C" };
                
                int randomSetor = random.Next(0, 4);
                Recepecionista recepcionista = new Recepecionista(i, "Recepecionista {i}", "{i}23456{i}9{i+4}{2+i}{3+i}", setores[randomSetor]);
                ListaRecepcionistas.Add(recepcionista);
            }
        }

        public void CargaForncedores()
        {
            for (int i = 0; i < 10; i++)
            {
                string[] types = { "Logística", "Equipamentos", "Farmácias", "Remédios" };
                
                int randomtype = random.Next(0, 4);
                Fornecedor fornecedor = new Fornecedor(i, "Fornecedor {i}", $"{i}23456{i}9{i}{i}{i}", types[randomtype] );
                ListaFornecedores.Add(fornecedor);
            }
        }


    }
}
