using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordChecker
{
    public class PasswordChecker
    {
        public int CheckPassword(string password)
        {
            Regex numbersRegex = new Regex(@"(?=.*?[0-9])");
            Regex upperLettersRegex = new Regex(@"(?=.*?[a-z])");
            Regex lowerLettersRegex = new Regex(@"(?=.*?[A-Z])");
            Regex charsRegex = new Regex(@"(?=.*?[#?!@$%^&*-])");
            int value = 0;
            try
            {
                if (password.Length > 7)
                {
                    value += 1;
                }
                if (numbersRegex.IsMatch(password))
                {
                    value += 1;
                }
                if (upperLettersRegex.IsMatch(password))
                {
                    value += 1;
                }
                if (lowerLettersRegex.IsMatch(password))
                {
                    value += 1;
                }
                if (charsRegex.IsMatch(password))
                {
                    value += 1;
                }
                return value;
            }
            catch 
            {
                return 0;
            }
        }
    }
}
