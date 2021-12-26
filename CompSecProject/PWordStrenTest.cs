using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace CompSecProject
{
    class PWordStrenTest
    {
        private readonly string symbolList = "!#$%&'()*+,-./:;<=>?@[]^_`{|}~";

        public (double, string) PasswordStrengthTest(string passwordInput)
        {
            string passwordTest = passwordInput;
            string passwordTips = string.Empty;

            if (passwordTest == string.Empty)
            {
                passwordTips = "No password was entered." + Environment.NewLine;
                return (0, passwordTips);
            }

            double symbolScore = 0, upperLowerScore, lengthScore;
            if (passwordTest.Length < 3)
            {
                lengthScore = 0;
            }
            else if (passwordTest.Length < 5)
            {
                lengthScore = 1;
            }
            else if (passwordTest.Length > 5 && passwordTest.Length < 10)
            {
                lengthScore = 2;
            }
            else
            {
                lengthScore = 3;
            }

            bool atLeast3Caps = false, atLeast3Lowers = false;
            int numCaps = 0, numLowers = 0;

            foreach (char letter in passwordTest)
            {
                if (symbolList.Contains(letter) || Char.IsNumber(letter))
                {
                    if (symbolScore < 3)
                    {
                        symbolScore += .75;
                    }
                }
                else if (Char.IsUpper(letter))
                {
                    numCaps++;
                    if(numCaps >= 4)
                    {
                        atLeast3Caps = true;
                    }
                }
                else if (Char.IsLower(letter))
                {
                    numLowers++;
                    if(numLowers >= 4)
                    {
                        atLeast3Lowers = true;
                    }
                }
            }

            if (!atLeast3Caps && !atLeast3Lowers)
            {
                upperLowerScore = 1;
            }
            else if ((!atLeast3Caps && atLeast3Lowers) || (!atLeast3Lowers && atLeast3Caps))
            {
                upperLowerScore = 2;
            }
            else
            {
                upperLowerScore = 3;
            }

            if (symbolScore + upperLowerScore + lengthScore < 5)
            {
                passwordTips += "Password is very weak." + Environment.NewLine;
            }
            else if (symbolScore + upperLowerScore + lengthScore < 8.5 && symbolScore + upperLowerScore + lengthScore >= 5)
            {
                passwordTips += "Password is fairly strong." + Environment.NewLine;
            }
            else
            {
                passwordTips += "Password is very strong." + Environment.NewLine;
            }

            if (lengthScore == 0 || lengthScore == 1)
            {
                passwordTips += "Password is much too short. Try to at least double its length!" + Environment.NewLine;
            }
            else if (lengthScore == 2)
            {
                passwordTips += "Password is a little too short.Try to make it a little longer!" + Environment.NewLine;
            }
            else
            {
                passwordTips += "Password is a good length." + Environment.NewLine;
            }

            switch (upperLowerScore)
            {
                case 1:
                    passwordTips += "Password should have a good mix of upper and lowercase letters. Try mixing the cases more." + Environment.NewLine;
                    break;
                case 2:
                    passwordTips += "Password needs a little bit more of a mix of upper and lowercase letters." + Environment.NewLine;
                    break;
                case 3:
                    passwordTips += "Password has a good mix of upper and lowercase letters." + Environment.NewLine;
                        break;
            }

            if (symbolScore <= 1)
            {
                passwordTips += "Password needs much more numbers and/or symbols mixed in.Mix it up a bit!" + Environment.NewLine;
            }
            else if (symbolScore >  1 && symbolScore <=2)
            {
                passwordTips += "Password needs just a little more variety. Try a couple more numbers and/or symbols." + Environment.NewLine;
            }
            else if (symbolScore == 3)
            {
                passwordTips += "Password has a good mix of letters, numbers, and symbols. Nice!" + Environment.NewLine;
            }

            return (symbolScore + upperLowerScore + lengthScore, passwordTips);
        }

        public string EncryptString(string key, string plainText)
        {
            byte[] iv = new byte[16];
            byte[] array;

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }

                        array = memoryStream.ToArray();
                    }
                }
            }

            return Convert.ToBase64String(array);
        }

        public string DecryptString(string key, string cipherText)
        {
            byte[] iv = new byte[16];
            byte[] buffer = Convert.FromBase64String(cipherText);

            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(key);
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream memoryStream = new MemoryStream(buffer))
                {
                    using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader((Stream)cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }
    }
}
