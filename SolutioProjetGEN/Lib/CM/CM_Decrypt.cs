using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
   public class Decrypt
    {

        public static string EncryptDecrypt(string textToEncrypt, string encryptionKey)
        {

      
            StringBuilder outSb = new StringBuilder(textToEncrypt.Length);


            for (int j = 0, l = textToEncrypt.Length; j < l; ++j)
            {
                char character = textToEncrypt[j];
                uint charCode = (uint)character;

                int keyPosition = j % encryptionKey.Length;
                char keyChar = encryptionKey[keyPosition];

                uint keyCode = (uint)keyChar;
                uint combinedCode = charCode ^ keyCode;
                char combinedChar = (char)combinedCode;

                outSb.Append(combinedChar);
            }

            return outSb.ToString();
        }
    }
}
