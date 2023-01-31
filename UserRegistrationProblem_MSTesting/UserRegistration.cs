using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationProblem_MSTesting
{
    public class UserRegistration
    {
        public bool FirstNameAndLastName(string Name)
        {
            Regex firstLastName = new Regex(@"^([A-Z]{1}[a-z]{2,})$");
            bool matches = firstLastName.IsMatch(Name);

            return matches;
        }
    }
}
