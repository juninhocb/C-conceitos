using Console_Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Main.Interface
{
    public interface ICrud
    {
        //Int32 MenuCadastro();
        void List(Mocks mock);
        void Register(Mocks mock);
        void Update(Mocks mock);
        void Delete(Mocks mock);



    }
}
