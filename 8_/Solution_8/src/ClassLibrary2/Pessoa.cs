using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Pessoa
    {   
        public string Nome { get; set; }
        public string SobreNome { get; set; }   
        public int Idade { get; set; }
        public DateTime DataNascimento {get; set;}
        public string Endereco { get; set; }

        public Pessoa()
        {

        }
        public string ApresentarNomeCustom() {
            string nomeCustom = $"{SobreNome}, {Nome}";
            return nomeCustom;
        }
        
        public string ApresentarIdadeEndereco()
        {
            string str = $"Idade: {Idade}, Endereco: {Endereco}";
            return str;

        }


    }
}
