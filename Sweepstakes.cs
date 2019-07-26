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
        public string Name; 
        public bool enter = true;
        public Dictionary<int, string> contestants = new Dictionary<int, string>();
        public string theWinner;
        public int winner;


        //ctor

        public Sweepstakes(string name) 
        {
            Name = name;
        }

        //member methods
        

        public void RegisterContestant(Contestant contestant) 
        {
            
            contestants.Add(contestant.registrationNumber, contestant.firstName);
        }

        public int RandomNumber(int min, int max)
        {
            Random winningNumber = new Random();
            return winningNumber.Next(min, max);
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
            //HASA userinterface tHerefOre
            UserInterface newUI = new UserInterface();
            newUI.EnterOrEnd();
            if (newUI.response == "Y" || newUI.response == "yes" || newUI.response == "YES" || newUI.response == "yes" || newUI.response == "y")
            {
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
                if (enter == false)
                {
                    newUI.EndSweepstakes();
                    EndSweepstakes(newUI);
                }
            }
            else
            {
                newUI.EndSweepstakes();
                EndSweepstakes(newUI);

            }




        }

        public void EndSweepstakes(UserInterface newInterface)
        {
            if (newInterface.noResponse == "Y" || newInterface.noResponse == "yes" || newInterface.noResponse == "YES" || newInterface.noResponse == "yes" || newInterface.noResponse == "y")
            {
                newInterface.EnterUser();
                newInterface.EnterPass();
                if (newInterface.userResponse == "admin" && newInterface.passResponse == "admin")
                {
                    PickWinner(newInterface);
                    PrintContestantInfo(newInterface.newContestant);
                }
            }
            else
            {
                this.RunSweepstakes();
            }
        }

        public void PickWinner(UserInterface userInterface)
        {
            winner = RandomNumber(10001, userInterface.regNumber);
            theWinner = contestants[winner];
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine($"The winner is {theWinner}!");
            Console.ReadLine();
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
