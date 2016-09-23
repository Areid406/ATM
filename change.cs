using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    /*This class handles the amount of change wanted from the ATM*/
    class change
    {
        //The current change being processed
        private int changeAmt;

        /*Setter to set the current change amount*/
        void setAmt(int newChange)
        {
            changeAmt = newChange;
        }//setAmt()

        /*Getter to get the current change amount*/
        int getAmt()
        {
            return changeAmt;
        }//getAmt()

        int main()
        {
            denom test = new denom();
            return 0;
        }
    }
}
