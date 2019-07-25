using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        //member variables
        public string fNameInput;
        public string lNameInput;
        public string emailInput;
        public int regNumber = 10000;
        public Contestant newContestant;

        //ctor
        public UserInterface()
        {

        }

        //member methods

        public Contestant NewContestant(string first, string last, string email, int regNum)
        {
            newContestant = new Contestant(first, last, email, regNum);
            return newContestant;
        }


        public void GetFirstName()
        {
            Console.WriteLine("Enter first name");
            fNameInput = Console.ReadLine();
        }

        public void GetLastName()
        {
            Console.WriteLine("Enter last name.");
            lNameInput = Console.ReadLine();
        }

        public void GetEmailAddress()
        {
            Console.WriteLine("Enter email address");
            emailInput = Console.ReadLine();
        }

        public int AssignRegistrationNumber()
        {
            regNumber++;
            Console.WriteLine($"Your registration number is: {regNumber}");
            return regNumber;
        }

        //last line of main bits
    }
}
/*
Collects any information the application would need to get from the user. 

Ex: functionality to assign a contestant object a first name, last name, email adress, and registration number
*/