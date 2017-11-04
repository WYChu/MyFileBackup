using System.IO;
using System.Security.Cryptography;

namespace MyFileBackup.Services
{
    internal class SecurityEncoding
    {
        public byte[] AesEncoding(byte[] input, string password, string salt)
        {
            byte[] output = null;
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] saltBytes = System.Text.Encoding.UTF8.GetBytes(salt);

            RijndaelManaged aes = new RijndaelManaged
            {
                KeySize = 256,
                BlockSize = 128,
                Padding = PaddingMode.PKCS7
            };

            var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 50000);

            aes.Key = key.GetBytes(aes.KeySize / 8);
            aes.IV = key.GetBytes(aes.BlockSize / 8);
            aes.Mode = CipherMode.CFB;

            MemoryStream memoryStream = new MemoryStream();
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
            {
                cryptoStream.Write(input, 0, input.Length);
            }

            output = memoryStream.ToArray();

            return output;
        }
    }
}