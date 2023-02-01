using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem_MSTesting
{
    public class UserRegistrations
    {
        public bool FirstNameAndLastName(string Name)
        {
            Regex firstLastName = new Regex(@"^([A-Z]{1}[a-z]{2,})$");
            bool matches = firstLastName.IsMatch(Name);

            return matches;
        }
        public bool Email(string email)
        {
            Regex emailID = new Regex(@"^(abc)[a-za-Z0-9_\+\-\.]*[@](b1)*[.](co)*[.][a-z]{3}$");
            bool matches = emailID.IsMatch(email);
            return matches;
        }
        public bool MobileNumber(string MobileNumber)
        {
            Regex number = new Regex(@"^*[+][1-9]{1,3}\s[1-9]{1}[0-9]{9}$");
            bool matches = number.IsMatch(MobileNumber);
            return matches;
        }
        public bool Password(string password)
        {
            Regex pass = new Regex(@"^(?=.*[a-z])(?=.*[A-Z].{8,}$");
            bool match = pass.IsMatch(password);
            return match;
        }
    }
}
