using ClassLibrary_Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Models
{
    public class Patient : Person
    {
        public Int32 PatientCode { get; set; }
        public string HealthInsurance { get; set; }

        public Patient()
        {

        }

        public Patient(Int32 codigo, String nome, string cpf, string convenio)
        {
            Code = codigo;
            Name = nome;
            Cpf = cpf;
            PersonType = EPersonType.PF ;
            HealthInsurance = convenio;
        }

        public string FormatedString()
        {
            return $"Codigo: {Code} \n" +
                $"Nome: {Name} \n" +
                $"CPF: {Cpf} \n" +
                $"Tipo: {EPersonType.PF}\n" +
                $"Convenio: {HealthInsurance}\n";

        }
    }
}
