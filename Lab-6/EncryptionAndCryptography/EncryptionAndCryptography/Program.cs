using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptionAndCryptography
{
    class Program
    {

        static public string ConvertToHex(byte[] inBytes)
        {
            string outstr = "";
            foreach (byte b in inBytes)
            {
                outstr += b.ToString("x2");
            }

            return outstr;
        }

        static public byte[] RSAEncrypt(byte[] in_message, RSAParameters rsp)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(rsp);
                    byte[] mess = rsa.Encrypt(in_message, false);
                    return mess;
                }

            }
            catch (CryptographicException e){
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        static public byte[] RSADecrypt(byte[] in_message, RSAParameters rsp)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(rsp);
                    byte[] mess = rsa.Decrypt(in_message, false);
                    return mess;
                }
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
            }
            return null;
        }

        static void AssymetricEncyption()
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            byte[] input = new ASCIIEncoding().GetBytes("Hello World");

            byte[] encrypted_str = RSAEncrypt(input, rsa.ExportParameters(false));
            string output = ConvertToHex(input);
            Console.WriteLine(output);

            byte[] decrypted_str = RSADecrypt(encrypted_str, rsa.ExportParameters(true));
            Console.WriteLine(new ASCIIEncoding().GetString(decrypted_str));
        }

        static void HashingExample()
        {
            byte[] my_mess = new ASCIIEncoding().GetBytes("hello world");
            SHA1 mysha = new SHA1CryptoServiceProvider();
            byte[] result = mysha.ComputeHash(my_mess);

            SHA256 mybiggersha = new SHA256CryptoServiceProvider();
            byte[] result2 = mybiggersha.ComputeHash(my_mess);

            Console.WriteLine(result);

            string output = "";
            string output2 = "";

            int sha1len = 0;
            int sha256len = 0;

            foreach (byte b in result)
            {
                output += b.ToString("x2");
                sha1len += 2;
            }

            foreach (byte b in result2)
            {
                output2 += b.ToString("x2");
                sha256len += 2;
            }

            //'hello world' = 2aae6c35c94fcfb415dbe95f408b9ce91ee846ed.

            Console.WriteLine("SHA1 output: {0}, str len: {1}", output, sha1len);
            Console.WriteLine("SHA256 output: {0}, str len: {1}", output2, sha256len);
        }
        static void Main(string[] args)
        {
            AssymetricEncyption();

        }

    }
}
