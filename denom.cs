using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public class ATM
    {
        //Denomimations available in the atm
        private int numFive = 0;
        private int numTen = 0;
        private int numTwenty = 0;
        private int numFifty = 0;
        private int numHun = 0;

        //Default constructor
        public ATM() { }

        //Constructor that originally instantiates all of the denominations
        public ATM(int numFive, int numTen, int numTwenty, int numFifty, int numHun)
        {
            this.numFive = numFive;
            this.numTen = numTen;
            this.numTwenty = numTwenty;
            this.numFifty = numFifty;
            this.numHun = numHun;
        }//constructor()

        //Default deconstructor
        ~ATM() { }

        /*Getters for the amount of each denomination*/

        public int getFive()
        {
            return numFive;
        }//getFive()

        public int getTen()
        {
            return numTen;
        }//getTen()

        public int getTwenty()
        {
            return numTwenty;
        }//getTwenty()

        public int getFifty()
        {
            return numFifty;
        }//getFifty()

        public int getHun()
        {
            return numHun;
        }//getHun()

        /*Setters to set each individual denomination amount*/

        public void setFive(int numFive)
        {
            if (numFive >= 0)
                this.numFive = numFive;
            else
                Console.WriteLine("Invalid denomination amount");
        }//setFive()

        public void setTen(int numTen)
        {
            if (numTen >= 0)
                this.numTen = numTen;
            else
                Console.WriteLine("Invalid denomination amount");
        }//setTen()

        public void setTwenty(int numTwenty)
        {
            if (numTwenty >= 0)
                this.numTwenty = numTwenty;
            else
                Console.WriteLine("Invalid denomination amount");
        }//setTwenty()

        public void setFifty(int numFifty)
        {
            if (numFifty >= 0)
                this.numFifty = numFifty;
            else
                Console.WriteLine("Invalid denomination amount");
        }//setFifty()

        public void setHun(int numHun)
        {
            if (numHun >= 0)
                this.numHun = numHun;
            else
                Console.WriteLine("Invalid denomination amount");
        }//setHun()

    }
}
