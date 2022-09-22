using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10_.Models
{
    public class Prontuario
    {
        public int Id { get; set; }
        public int codigoPaciente { get; set; }

        public int codigoMedicoAtend { get; set; }

        public int codigoRecepAtend { get; set; }

        public bool sinaisVais { get; set; }

        public DateTime dataEntrada { get; set; }

        public DateTime dataAlta { get; set; }

        public bool statusPaciente { get; set; }



    }
}
