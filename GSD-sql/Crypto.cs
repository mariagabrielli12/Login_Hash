using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Login_Hash
{
    public static class LoginHash
    {
        // Método para gerar o hash de um texto usando MD5
        public static string MD5Encrypt(string frase)
        {
            using (MD5 md5hasher = MD5.Create())
            {
                byte[] hashedDataBytes = md5hasher.ComputeHash(Encoding.UTF8.GetBytes(frase));
                return ByteArrayToString(hashedDataBytes);
            }
        }

        // Método para gerar o hash de um texto usando SHA1
        public static string SHA1Encrypt(string frase)
        {
            using (SHA1 sha1hasher = SHA1.Create())
            {
                byte[] hashedDataBytes = sha1hasher.ComputeHash(Encoding.UTF8.GetBytes(frase));
                return ByteArrayToString(hashedDataBytes);
            }
        }

        // Método para gerar o hash de um texto usando SHA256
        public static string SHA256Encrypt(string frase)
        {
            using (SHA256 sha256hasher = SHA256.Create())
            {
                byte[] hashedDataBytes = sha256hasher.ComputeHash(Encoding.UTF8.GetBytes(frase));
                return ByteArrayToString(hashedDataBytes);
            }
        }

        // Método para gerar o hash de um texto usando SHA384
        public static string SHA384Encrypt(string frase)
        {
            using (SHA384 sha384hasher = SHA384.Create())
            {
                byte[] hashedDataBytes = sha384hasher.ComputeHash(Encoding.UTF8.GetBytes(frase));
                return ByteArrayToString(hashedDataBytes);
            }
        }

        // Método para gerar o hash de um texto usando SHA512
        public static string SHA512Encrypt(string frase)
        {
            using (SHA512 sha512hasher = SHA512.Create())
            {
                byte[] hashedDataBytes = sha512hasher.ComputeHash(Encoding.UTF8.GetBytes(frase));
                return ByteArrayToString(hashedDataBytes);
            }
        }

        // Método auxiliar para converter um array de bytes em uma string hexadecimal
        private static string ByteArrayToString(byte[] inputArray)
        {
            StringBuilder output = new StringBuilder(inputArray.Length * 2);
            foreach (byte b in inputArray)
            {
                output.Append(b.ToString("X2"));
            }
            return output.ToString();
        }
    }
}
