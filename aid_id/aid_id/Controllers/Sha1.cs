using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
// https://adeshoras.wordpress.com/2008/06/23/generando-un-hash-sha1-con-aspnet-y-c-de-forma-sencilla-y-simple/
namespace aid_id.Controllers
{
    class Sha1
    {
        public string GetSHA1(String texto)
        {
            StringBuilder cadena = new StringBuilder();
            try
            {
                SHA1 sha1 = SHA1CryptoServiceProvider.Create();
                Byte[] textOriginal = ASCIIEncoding.Default.GetBytes(texto);
                Byte[] hash = sha1.ComputeHash(textOriginal);
                
                foreach (byte i in hash)
                {
                    cadena.AppendFormat("{0:x2}", i);
                }
            }
            catch (Exception) { }
            return cadena.ToString();

        }
    }
}