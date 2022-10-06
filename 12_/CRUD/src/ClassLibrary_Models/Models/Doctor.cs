using ClassLibrary_Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Models
{
    public class Doctor : Person
    {

        public Int32 DoctorCode { get; set; }
        public Int32 Crm { get; set; }

        public ESpeciality Speciality { get; set; }

        public Doctor()
        {

        }

        //string[] especialidades = { "Ortopedista", "Clínico Geral", "Pediadra", "Neuro" };
        public Doctor(Int32 codigo, String nome, string cpf, int crm, ESpeciality especial)
        {
            Code = codigo;
            Name = nome;
            Cpf = cpf;
            Crm = crm;
            Speciality = especial;
        }

        public string FormatedString()
        {
            return $"Codigo: {Code} \n" +
                $"Nome: {Name} \n" +
                $"CPF: {Cpf} \n" +
                $"CRM: {Crm}\n" +
                $"Especialidade: {Speciality}\n"; 

        }

    }
}
