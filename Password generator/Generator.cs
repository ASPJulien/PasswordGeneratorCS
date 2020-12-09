using System;
using System.Collections.Generic;

namespace Password_generator
{
    public class Generator
    {
        
        public static string Generate(bool isAdvanced)
        {
            if (isAdvanced != true)
            {
                if (MainWindow.Security == 0)
                    return Password(6, false, false);
                else if (MainWindow.Security == 1)
                    return Password(8, true, false);
                else if (MainWindow.Security == 2)
                    return Password(10, true, true);
                else
                    return "";
            }
            else
            {
                return Password(Window1.Length, Window1.IsAlphaNum, Window1.IsSpecial);
            }
        }   


        private static Random rng = new Random();
        private static string Password(int length, bool alphaNum, bool specials)
        {

            List<char> password = new List<char>();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYabcdefghijklmnopqrstuvwxyz";
            string SpeChars = "$àç@#_/";
            string NumChars = "0123456789";
            int num1 = rng.Next(length);
            int num2 = rng.Next(length);

            while (num1 == num2)
                num2 = rng.Next(length);

            if(alphaNum == true)
                characters += NumChars;

            if(specials == true)
                characters += SpeChars;

            for (int i = 0; i < length; i++)
                password.Add(characters[rng.Next(characters.Length)]);
                
            if (specials)
                password[num1] = SpeChars[rng.Next(SpeChars.Length)];
            
            if (alphaNum)
                password[num2] = NumChars[rng.Next(NumChars.Length)];
            
            return new string(password.ToArray());
        }
    }
}   