/* change -version 0.1 - authored by Max Austin
 * For use in CSCI305 Fall 2016 Lab #4 - ATM 
 * 
 * change stores the amount of money needed to be dispensed by the ATM
 * as an integer, with associated getter and setter methods.
 *
 */

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
