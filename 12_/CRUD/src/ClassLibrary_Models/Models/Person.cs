using ClassLibrary_Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Models
{
    public abstract class Person
    {
        public Int32 Code { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Adress { get; set; }

        public EPersonType PersonType { get; set; }

    }
}
