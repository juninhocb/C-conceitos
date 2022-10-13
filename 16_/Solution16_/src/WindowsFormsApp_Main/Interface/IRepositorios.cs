using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Main.Interface
{
    public interface IRepositorios
    {

        Object Save(Object obj, MySqlConnection conn);
        MySqlDataReader Load();


    }
}
