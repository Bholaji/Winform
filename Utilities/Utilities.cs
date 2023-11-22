using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utilities
{
    public class Utilities
    {
        public bool IsValidNigerianPhoneNumber(string phoneNumber)
        {
            // Define a regular expression pattern for Nigerian phone numbers
            string pattern = @"^\+?234\d{10}$|^\+?234\d{1}-\d{7}$";

            // Create a Regex object and match the phone number against the pattern
            Regex regex = new Regex(pattern);
            Match match = regex.Match(phoneNumber);

            return match.Success;
        }

       public bool IsValidEmail(string email)
        {
            // Define a regular expression pattern for email validation
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Create a Regex object and match the email against the pattern
            Regex regex = new Regex(pattern);
            Match match = regex.Match(email);

            return match.Success;
        }
    }
}
