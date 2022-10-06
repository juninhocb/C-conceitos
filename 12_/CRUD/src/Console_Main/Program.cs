using Console_Main.Command_line_Interface;
using Console_Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Main
{


    internal class Program
    {   
        static void Main()
        {
            
            Console.Title = "12_CRUD";
            UMenu userInteractStart = new UMenu();
            userInteractStart.Start(false);

        }
    }
}
