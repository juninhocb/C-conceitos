using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Enums
{
    public enum ESpeciality
    {
        [Description("DERMATOLOGISTA")]
        DERMATOLOGISTA = 0,
        [Description("CLINICO GERAL")]
        CLINICO_GERAL = 1,
        [Description("CARDIOLOGISTA")]
        CARDIOLOGISTA = 2,
        [Description("ORTOPEDISTA")]
        ORTOPEDISTA = 3,
        [Description("ANESTESIOLOGISTA")]
        ANESTESIOLOGISTA = 4,
        [Description("PEDIATRA")]
        PEDIATRA = 5,
        [Description("PSIQUIATRA")]
        PSIQUIATRA = 6,
        [Description("ONCOLOGISTA")]
        ONCOLOGISTA = 7,
        [Description("ENDOCRINOLOGISTA")]
        ENDOCRINOLOGISTA = 8,
        [Description("HEMATOLOGISTA")]
        HEMATOLOGISTA = 9,
        [Description("CIRURGIAO PLASTICO")]
        CIRURGIAO_PLASTICO = 10

    }
}
 