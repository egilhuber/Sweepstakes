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
        string Name;
        //ctor
        public Sweepstakes(string name)
        {
            Name = name;
        }
        //member methods

        Contestant newContestant = new Contestant();
        

        public void RegisterContestant(Contestant contestant) //
        {
            Dictionary<int, string> contestants = new Dictionary<int, string>();
            contestants.Add(contestant.registrationNumber, contestant.firstName);
        }

        public string PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

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
