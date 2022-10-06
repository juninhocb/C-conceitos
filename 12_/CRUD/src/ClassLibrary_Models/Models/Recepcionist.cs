using ClassLibrary_Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Models
{
    public class Recepcionist : Person
    {

        public Int32 RecepcionistCode { get; set; }
        public char Sector { get; set; }

        public Recepcionist(Int32 codigo, String nome, string cpf, char setor)
        {
            Code = codigo;
            Name = nome;
            Cpf = cpf;
            Sector = setor;
        }

        public string FormatedString()
        {
            return $"Codigo: {Code} \n" +
                $"Nome: {Name} \n" +
                $"CPF: {Cpf} \n" +
                $"Setor: {Sector}\n";

        }

    }
}
