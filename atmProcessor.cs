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
