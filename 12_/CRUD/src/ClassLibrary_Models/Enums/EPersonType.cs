using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Enums
{
    public enum EPersonType
    {
        [Description("Pessoa Física")]
        PF = 1,
        [Description("Pessoa Jurídica")]
        PJ = 2
    }
}
