using System;
using System.Security.Cryptography;
using System.Text;

namespace GetAppInstalled
{
    public static class RSAEncryptUltility
    {
        private const string publicKey = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>" +
                                            @"<RSAKeyValue>
                                                <Modulus>x54dI2ZG6wSEAXOGMWJjELQ9a8bBIgqIyGuh+BWWmMlvKLF+C/K7YEGqpZKPOzTj+v4QAXvxxM4M6s9Xs8Ds1XbNEELV0D5BYmNCIo4BdkaBuFW9LgaYAXwGfzFWADlC5GPy9DKYg2bYOLVMRl+YbHu//4TXIF2gKAXTRaEe5ME=</Modulus>
                                                <Exponent> AQAB</Exponent>
                                            </RSAKeyValue>";

        private static readonly Guid md5Key = Guid.NewGuid();


       private static string Encrypt(string data, bool IsPadding)
        {
            byte[] inputBytes = UTF8Encoding.UTF8.GetBytes(data), outputBytes = null;
            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {
                    rsa.FromXmlString(publicKey);
                    outputBytes = rsa.Encrypt(inputBytes, IsPadding);
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }

            }
            return Convert.ToBase64String(outputBytes);
        }

        public static string GetEncryptedKey()
        {
            return Encrypt(md5Key.ToString(), false);
        }

        public static string MD5Encrypt(string data)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdsp = new TripleDESCryptoServiceProvider())
                {
                    tdsp.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(md5Key.ToString()));
                    tdsp.Mode = CipherMode.ECB;
                    tdsp.Padding = PaddingMode.PKCS7;

                    using (var transform = tdsp.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(data);
                        byte[] transformedBytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(transformedBytes);
                    }

                }
            }

        }

        


    }
}
