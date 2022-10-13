using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Model.Enums
{
    public enum EStatus
    {
        [Description("Inativo")]
        I = 1,
        [Description("Ativo")]
        A = 2,
        [Description("Concluído")]
        C = 3,
        [Description("Remarcado")]
        R = 4,

    }

    public enum EStatus_Contato
    {
        [Description("Inativo")]
        I = 1,
        [Description("Ativo")]
        A = 2
    }
}
