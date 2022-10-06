using ClassLibrary_Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Models
{
    public class Provider : Person
    {

        public Int32 ProviderCode { get; set; }
        public EProviderType ProviderType { get; set; }

        public Provider() { 
        }

        public Provider(Int32 codigo, String nome, string cpf, EProviderType eProvider)
        {
            Code = codigo;
            Name = nome;
            Cpf = cpf;
            ProviderType = eProvider;
        }

        public string FormatedString()
        {
            return $"Codigo: {Code} \n" +
                $"Nome: {Name} \n" +
                $"CPF: {Cpf} \n" +
                $"Setor: {ProviderType}\n";

        }


    }
}
