using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeWars
{

    /*
    EXPLANATION:
    
    For building the encrypted string:
    Take every 2nd char from the string, then the other chars, that are not every 2nd char, and concat them as new String.
    Do this n times!
    */

    public class SimpleEncryption
    {
        public static string Encrypt(string text, int n)
        {
            if (text == null)
                return text;

            if (n == 0)
                return text;

            //Encrypt n times
            for (int i = 0; i < n; i++)
            {
                string evenChars = ""; //String all even chars get placed in
                string unevenChars = text; //String all even chars get removed from
                int j = 1; //Counter for while loop

                while (j < unevenChars.Length)
                {
                    evenChars += unevenChars[j];
                    unevenChars = unevenChars.Remove(j, 1);
                    j++;
                }
                text = evenChars + unevenChars; //Set encryped text to text in case multiple runs are wanted
            }
            return text;
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if (encryptedText == "")
                return "";

            //Decrypt n times
            for (int i = 0; i < n; i++)
            {
                int stringSize = encryptedText.Length / 2; //Gets rounded down in case of uneven string size

                string unevenChars = encryptedText.Substring(stringSize); //Uneven chars
                string evenChars = encryptedText.Replace(unevenChars, ""); //Even chars

                string decryptedString = "";
                int j = 0;

                //While decrypted string shorter as encyped build decrypted string
                while (decryptedString.Length < encryptedText.Length)
                {
                    decryptedString = (j % 2 == 0 ? unevenChars.FirstOrDefault() : evenChars.FirstOrDefault()) + decryptedString; //Is j even get char from even string part else get first char from uneven string part

                    //Remove the added char from string
                    if (j % 2 == 0)
                    {
                        unevenChars = unevenChars.Substring(1);
                    }
                    else
                    {
                        if (evenChars.Length > 0)
                            evenChars = evenChars.Substring(1);
                    }
                    j++;
                }

                encryptedText = new string(decryptedString.Reverse().ToArray()); ;
            }
            return encryptedText;
        }
    }
}
