using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        //member variables
        string Name; //name of the sweepstakes?yes
        bool enter = true;
        Dictionary<int, string> contestants = new Dictionary<int, string>();

        //ctor

        public Sweepstakes(string name) 
        {
            Name = name;
        }

        //member methods
        

        public void RegisterContestant(Contestant contestant) //
        {
            
            contestants.Add(contestant.registrationNumber, contestant.firstName);
        }

        public string PickWinner()
        {
            string theWinner = "lorem ipsum"; // = first name + last name of winner
            return theWinner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }

        public bool Enter()
        {
            Console.WriteLine("enter sweepstakes again?");
            string response = Console.ReadLine();
            if (response == "y")
            {
                enter = true;
            }
            else
            {
                enter = false;
            }
            return enter;
        }
        public void RunSweepstakes()
        {
            //PUT ALL FUNCTIONAL BITS LIKE METHOD CALLS AND STRAY LOGIC IN HERE INSTEAD OF THE PROGRAM CLASS
            //have like a branch situation where you can choose to enter or select winner but in order to select 
            //a winner you need valid login credentials
            //saltyhashygoodness?

            //HASA userinterface tHerefOre
            UserInterface newUI = new UserInterface();

            while (enter == true)
            {
                newUI.GetFirstName();
                newUI.GetLastName();
                newUI.GetEmailAddress();
                newUI.AssignRegistrationNumber();
                newUI.NewContestant(newUI.fNameInput, newUI.lNameInput, newUI.emailInput, newUI.regNumber);
                RegisterContestant(newUI.newContestant);
                Enter();
            }


        }
        //last line of main bits
    }
}
/*
Uses dictionary data structure

have the following methods with full implementation (write the functionality) of each method:

Sweepstakes(string name)

void RegisterContestant(Contestant contestant)

string PickWinner()

void PrintContestantInfo(Contestant contestant)
*/
