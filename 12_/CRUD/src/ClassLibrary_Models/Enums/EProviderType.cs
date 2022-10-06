using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Enums
{
    public enum EProviderType
    {
        [Description("REMEDIOS")]
        REMEDIOS = 0,
        [Description("SUPRIMENTOS")]
        SUPRIMENTOS = 1,
        [Description("TECNOLOGIA")]
        TECNOLOGIA = 2,
        [Description("FROTA")]
        FROTA = 3,
        [Description("SERVICOS GERAIS")]
        SERVICOS_GERAIS = 4,
        [Description("PAPELARIA")]
        PAPELARIA = 5,
        [Description("OUTROS")]
        OUTROS = 6


    }
}
