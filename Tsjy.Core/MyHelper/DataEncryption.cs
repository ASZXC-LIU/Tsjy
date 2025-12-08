using System;
using System.Security.Cryptography;
using System.Text;

namespace Tsjy.Core.MyHelper
{
    public static class DataEncryption
    {
        private static SHA1 sha1 = SHA1.Create();
        public static string SHA1Encrypt(string input)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha1.ComputeHash(dataBytes);
            string result = BitConverter.ToString(hashBytes).Replace("-", newValue: "");
            return result;
        }
    }
}
