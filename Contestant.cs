using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Contestant
    {
        //member variables
        public string firstName;
        public string lastName;
        public string emailAddress;
        public int registrationNumber;
        //ctor
        public Contestant(string first, string last, string email, int registration)
        {
            firstName = first;
            lastName = last;
            emailAddress = email;
            registrationNumber = registration;

        }
        //member methods

        //last line of main bits
    }
}
/* 
 Has a first name, last name, email address, and registration number.

*/