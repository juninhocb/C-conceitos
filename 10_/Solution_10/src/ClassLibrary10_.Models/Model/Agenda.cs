using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10_.Models
{
    public class Agenda
    {
        public int codigo { get; set; } 
        public string tipoAgenda { get; set; }
        public int diasAtendimento { get; set; }
        public DateTime horaAtendimento { get; set; }
        public DateTime horaAtendimentoFim { get; set; }
        public int codigoMedicoAgenda { get; set; }
        public int codigoRecepAgenda { get; set; }
        public bool statusAgenda { get; set; }
    }
}
