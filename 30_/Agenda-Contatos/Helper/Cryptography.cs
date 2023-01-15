using System.Security.Cryptography;
using System.Text;

namespace Agenda_Contatos.Helper
{
    public static class Cryptography
    {
        public static string GerarHash(this string value)
        {
            var hash = SHA1.Create();
            var encoding = new ASCIIEncoding();
            var array = encoding.GetBytes(value);

            array = hash.ComputeHash(array);

            var strHex = new StringBuilder();

            foreach (var item in array)
            {
                strHex.Append(item.ToString("x2"));
            }

            return strHex.ToString();

        }
    }
}
