using ClassLibrary10_.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10_.Models
{
    public abstract class Pessoa
    {

        public Int32 Codigo { get; set; } 
        public string Nome { get; set; }
        public string CGCCPF { get; set; }
        public string Endereco { get; set; }

        public TipoPessoa TipoPessoa { get; set; }


    }
}
