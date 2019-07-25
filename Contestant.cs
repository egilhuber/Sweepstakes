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

    make a method that assigns a registration number in order between 10000 and x (x is 10000 + however many entries user would like to allow)
        and then adds that registration number to a dictionary? THE SELECT WINNER METHOD DEALIO CAN SELECT A NUMBER BETWEEN 10000 AND WHATEVER THE MAX
        VALUE IN THE DICTIONARY IS?YES?
*/