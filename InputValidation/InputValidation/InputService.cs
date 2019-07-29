using System;
using System.Text.RegularExpressions;

namespace InputValidation
{
    class InputService
    {
        public static bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"^([a-zA-Z]+\s*)+$");
        }

        public static bool IsValidPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");
        }

        public static bool IsValidEmail(string mail)
        {
            return Regex.IsMatch(mail, @"^([a-z0-9]+(?:[._-][a-z0-9]+)*)@([a-z0-9]+(?:[.-][a-z0-9]+)*\.[a-z]{2,})$");
        }

        public static string ReformatPhoneNumber(string number)
        {
            Match m = Regex.Match(number, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$");
            return String.Format("({0}) {1}-{2}", m.Groups[1], m.Groups[2], m.Groups[3]);
        }
    }
}
