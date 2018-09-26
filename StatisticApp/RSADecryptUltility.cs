using System;
using System.Security.Cryptography;
using System.Text;

namespace StatisticApp
{
    public static class RSADecryptUltility
    {

        private const string privateKey = "<?xml version=\"1.0\" encoding=\"ISO-8859-1\"?>" +
                                            @"<RSAKeyValue>
                                                <Modulus>x54dI2ZG6wSEAXOGMWJjELQ9a8bBIgqIyGuh+BWWmMlvKLF+C/K7YEGqpZKPOzTj+v4QAXvxxM4M6s9Xs8Ds1XbNEELV0D5BYmNCIo4BdkaBuFW9LgaYAXwGfzFWADlC5GPy9DKYg2bYOLVMRl+YbHu//4TXIF2gKAXTRaEe5ME=</Modulus>
                                                <Exponent> AQAB</Exponent>
                                                <P>8fwgrWxOXXvL9Xkgqt/feJ1PESuTY0QiA96c95MbUFPMySD6NR+21uvz0LAqnwMaLlh+e5GBh5FmkDCzrKRl6w==</P>
                                                <Q>0y3QSejTIjCREs9uCrHTZejKQ0d+RtU9+pTnttgctC+8U2ztRtJ5hIZW65QshCRFiOi6n/aJmZANW8/Ze4lZAw==</Q>
                                                <DP>kwDMxS3niWj8ZZp5GvU3p+lAsDidqA8q7tjc2JXYYPsXjBPpjD5A792VV3C9462ZyQ/ffqfNXZMaEHxVmoqgkw==</DP>
                                                <DQ>TEcoDQpD+P2B6UFzhfllWlITfOm9+ufbUz+l0q2M8KitZZTav9IWgn/jtYP38GMJmsI1ZsIuQYF+0cLp021w8Q==</DQ>
                                                <InverseQ>CmGGwIKhkFlQXlbX4OfEGaRPqbZpV6k8qT6nLdO0mdy07wLYUVMEFXPh69K1ZW/cV2uMXHKoxz3uK19iHeOeUg==</InverseQ>
                                                <D>aFrTVs9AIdrBe9S+AZEywufG+FH2Y2poaYZDLWNz0Dn2H6ryfyKNLFwH7vj4YfZbfLpW+b+m+8DQZeyxJ6qi5GSIJ3McOb4uP5d4w/6xJtF0bIKLENqV5Ky2KrpILRPOOdTQEd5mgyGBTvASYtIRM6CBug4RpsNyZYrea0vmnWU=</ D >
                                            </ RSAKeyValue > ";
        private static  string md5Key;


        public static string MD5Decrypt(string encryptedData)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdsp = new TripleDESCryptoServiceProvider())
                {
                    tdsp.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(md5Key.ToString()));
                    tdsp.Mode = CipherMode.ECB;
                    tdsp.Padding = PaddingMode.PKCS7;

                    using (var transform = tdsp.CreateDecryptor())
                    {
                        byte[] encryptedBytes = Convert.FromBase64String(encryptedData);
                        byte[] textBytes = transform.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                        return UTF8Encoding.UTF8.GetString(textBytes);
                    }
                }
            }
        }

        public static void SetMD5Key(string encryptedKey)
        {
            md5Key = Decrypt(encryptedKey, false);
        }

        private static string Decrypt(string data, bool IsPadding)
        {
            byte[] inputBytes = Convert.FromBase64String(data), outputBytes = null;
            using (var rsa = new RSACryptoServiceProvider())
            {
                try
                {

                    rsa.FromXmlString(privateKey);
                    outputBytes = rsa.Decrypt(inputBytes, IsPadding);
                }
                catch (CryptographicException e)
                {
                    Console.WriteLine(e.Message);
                    return null;
                }

            }
            return UTF8Encoding.UTF8.GetString(outputBytes);

        }
    }
}
