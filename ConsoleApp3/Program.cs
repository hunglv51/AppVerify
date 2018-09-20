﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Security.Cryptography;
using System.IO;
using System.Reflection;

namespace ConsoleApp3
{
    class Program
    {
        const string key = "K3y v3r1fy @pp f0r Kl00n";
        static void Main(string[] args)
        {
            //string testString = "Hello World 123 @";
            //string encode = EncodeData(testString);
            //string decode = DecodeData(encode);
            //Console.WriteLine(testString);
            //Console.WriteLine(encode);
            //Console.WriteLine(decode);
            //Console.WriteLine(File.Exists(Assembly.GetEntryAssembly().Location));
            Console.WriteLine(Assembly.GetEntryAssembly().Location);
            Console.ReadKey();
        }
        

        static string EncodeData(string data)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdsp = new TripleDESCryptoServiceProvider())
                {
                    tdsp.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
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

        static string DecodeData(string encryptedData)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdsp = new TripleDESCryptoServiceProvider())
                {
                    tdsp.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
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
    }
}
