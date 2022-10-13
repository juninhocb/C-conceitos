using ClassLibrary_Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Model.Classes
{
    public class Contato
    {
        public int id_contato;

        public string Nome { get; set; }
        //private string telefone { get; set; }
        public string Celular { get; set; }

        public string Email { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public EStatus_Contato StatusCtt { get; set; }

        public Contato(
            string n,
            string c,
            string e,
            string r,
            int nmr,
            string b, 
            string ci,
            string uf 
            )
        {
            this.Nome = n;
            this.Celular = c;
            this.Email = e;
            this.Rua = r;
            this.Numero = nmr;
            this.Bairro = b;
            this.Cidade = ci;
            this.Uf = uf;
            this.StatusCtt = EStatus_Contato.A;
        }



    }
}
