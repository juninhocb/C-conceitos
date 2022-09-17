using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Recepcionista : Pessoa
    {
        public static int CodigoConsulta { get; set;}
        public int NumeroCracha { get; set; }   
        public Recepcionista (int nmr, string nm, string sn)
        {
            this.NumeroCracha = nmr; 
            this.Nome = nm;
            this.SobreNome = sn;
        }
        public string AgendarConsulta()
        {
            CodigoConsulta++; 
            return $"Consulta de {ApresentarNomeCustom()} número de cracha: {NumeroCracha} Agendada!"; 
        }

    }
}
