using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class Security
    {
        public static string Encrypt(string plain_text)
        {
            byte[] encrypted = Encoding.Unicode.GetBytes(plain_text);
            return Convert.ToBase64String(encrypted);
        }

        public static string Decrypt(string encrypted)
        {
            byte[] decrypted = Convert.FromBase64String(encrypted);
            return Encoding.Unicode.GetString(decrypted);
        }

        public static bool ComparePassword(string password, string password_encrypt)
        {
            string decrypted = Decrypt(password_encrypt);
            return (password == decrypted) ? true : false;
        }

        public static string generateIdNumber()
        {
            var id_number = DateTime.Now.Subtract(DateTime.MinValue).TotalSeconds.ToString().Split('.');
            return id_number[0];
        }
    }
}
