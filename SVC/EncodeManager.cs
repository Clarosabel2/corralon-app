using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SVC
{
    public class EncodeManager
    {
        public static string HashValue(string password)
        {
            SHA256 encryptor = SHA256.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream;
            StringBuilder sb = new StringBuilder();
            stream = encryptor.ComputeHash(encoding.GetBytes(password));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        public static bool CompareHash(string toHash, string hashed)
        {
            return hashed.Equals(HashValue(toHash));
        }
    }
}
