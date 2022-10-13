using ClassLibrary_Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Model.Classes
{
    public class Compromisso
    {
        public int Id_compromisso;

        public int Id_contato { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }

        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }

        public EStatus Estado { get; set; }

        

        public Compromisso (string t, string d, DateTime di, DateTime df){
        
            this.Titulo = t;
            this.Descricao = d; 
            this.DataInicial = di;
            this.DataFinal = df;
            this.Estado = EStatus.A; 
        }

        


    }
}
