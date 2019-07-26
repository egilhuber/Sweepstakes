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
        public string response;
        public string noResponse;
        public string user = "admin";
        public string pass = "admin";
        public string userResponse;
        public string passResponse;

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

        public string EnterOrEnd()
        {
            
            Console.WriteLine("Would you like to enter the sweepstakes?");
            response = Console.ReadLine();
            return response;
        }

        public string EndSweepstakes()
        {
            Console.WriteLine("Would you like to select the winner?");
            noResponse = Console.ReadLine();
            return noResponse;
        }

        public string EnterUser()
        {
            Console.WriteLine("Enter username");
            userResponse = Console.ReadLine();
            return userResponse;

        }

        public string EnterPass()
        {
            Console.WriteLine("Enter password");
            passResponse = Console.ReadLine();
            return passResponse;
        }

        //last line of main bits
    }
}
/*
Collects any information the application would need to get from the user. 

Ex: functionality to assign a contestant object a first name, last name, email adress, and registration number
*/