using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Models.Enums
{
    public enum EMenu
    {

        
        // Main Menu
        EXIT = 0,
        DOCTORS = 1,
        PATIENTS = 2,
        PROVIDERS = 3,
        RECEPCIONISTS = 4,
        BACK = 5,

        // Doctor Menu
        GET_DOC = 10,
        POST_DOC = 11,
        PUT_DOC = 12,
        DEL_DOC = 13,
        
        // Patient Menu
        GET_PAT = 20,
        POST_PAT = 21,
        PUT_PAT = 22,
        DEL_PAT = 23,

        // Provider Menu
        GET_PRO = 30,
        POST_PRO = 31,
        PUT_PRO = 32,
        DEL_PRO = 33,

        // RECEPCIONIST Menu
        GET_REC = 40,
        POST_REC = 41,
        PUT_REC = 42,
        DEL_REC = 43

    }

}

