﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary10_.Models
{
    public class Fornecedor : Pessoa
    {
        public Int32 CodigoPessoa { get; set; }
        //public int  codigoPessoa { get; set; }
        public string TipoFornecedor { get; set; }

    }
}
