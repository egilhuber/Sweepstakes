using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //member variables
        ISweepstakesManager Manager;
        //ctor
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.Manager = manager;
        }
        //dependency injection goes here?

        //member methods

        //last line of main bits
    }
}
/*
Implement dependency injection so that I can utilize a sweepstakes manager
*/
