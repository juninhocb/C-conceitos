using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10_.Models
{
    public class Paciente : Pessoa
    {

        public Int32 CodigoPaciente { get; set; }
        public string Convenio { get; set; } 

        public Paciente()
        {

        }

        public Paciente (Int32 codigo, String nome, string cpf, string convenio)
        {
            Codigo = codigo;
            Nome = nome;
            CGCCPF = cpf;
            TipoPessoa = Enum.TipoPessoa.PF;
            Convenio = convenio; 
        }

    }
}
