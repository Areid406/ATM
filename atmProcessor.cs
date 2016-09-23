/* atmProcessor -version 0.1 - authored by Alex Reid
 * For use in CSCI305 Fall 2016 Lab #4 - ATM 
 * 
 * atmProcessor attempts to process the file gotten from atmDriver
 * and determine the amount of money needed to be dispensed and the 
 * amount of each denomination. Will return exception if file not found.
 *
 * atmProcessor should also handle cases where amounts for a
 * certain denomination(s) may not be given due to incorrect 
 * input formatting. i.e. = [m, n5, n10, , , ]
 *                          [m, n5, n10]
 *                          [m, n5]
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public class atmProcessor
    {
        private string filename;
        public atmProcessor()
        {}

        public atmProcessor(string filename)
        {
            this.filename = filename;

        }

       public void go()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(filename))
                {
                    string line;
                    int amount, five, ten, twenty, fifty, hundred;
                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        line = sr.ReadLine();
                        char[] nums = line.ToCharArray(); //unsure how to break up input to give change and denom correct values

                        if(nums.Length < 6) //condition to handle if less than 6 args are in a line (amt + 5 denoms)
                        {
                            for (int i = 0; i < nums.Length; i++) //loop through and assign vals to declared ints for denoms?
                            {
                                
                            }
                        }
                            
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

    }
    
    
}
