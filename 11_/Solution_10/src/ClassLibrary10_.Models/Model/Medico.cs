using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10_.Models.Model
{
    public class Medico : Pessoa
    {
        
        public Int32 CodigoMedico { get; set; }
        public Int32 CRM  { get; set; }

        public string Especial { get; set; }

        string[] especialidades = { "Ortopedista", "Clínico Geral", "Pediadra", "Neuro" };

        Random random = new Random();

        public Medico(Int32 codigo, String nome, string cpf, int crm, string especial)
        {
            Codigo = codigo;
            Nome = nome;
            CGCCPF = cpf;
            CRM = crm;
            Especial = especial;
        }

    }
}
