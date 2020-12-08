using System;

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

            var stringChars = new char[length];
            var characters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYabcdefghijklmnopqrstuvwxyz";
            
            if(alphaNum == true)
            {
                characters = "ABCDEFGHIJKLMNOPQRSTUVWXYabcdefghijklmnopqrstuvwxy0123456789";
            }

            if(specials == true)
            {
                characters = "ABCDEFGHIJKLMNOPQRSTUVWXYabcdefghijklmnopqrstuvwxy0123456789$àç@#_/";
            }
            
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = characters[rng.Next(characters.Length)];
            }

            string password;
            password = new String(stringChars);
            return password;

        }
        
        
        
    }
}