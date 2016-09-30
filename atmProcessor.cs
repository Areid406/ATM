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
 *
 * NOTE!!! : atmProcessor.cs has been replaced by processor.cs
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    public class Processer
    {
        private static string[] input;
        private static int[] nums = new int[6];
        private ATM atm = new ATM();
        private Change change = new Change();
        private string outFile = "out.txt";
      

        Processer() { }

        public void makeChange()
        {

            int changeAmt = change.getAmt();
            int five = 5;
            int ten = 10;
            int twenty = 20;
            int fifty = 50;
            int hund = 100;

            int hunAmt = (int)(changeAmt / hund);
            int fiftyAmt = (int)((changeAmt % hund) / fifty);
            int twentyAmt = (int)(((changeAmt % hund) % fifty) / twenty);
            int tenAmt = (int)((((changeAmt % hund) % fifty) % twenty) / ten);
            int fiveAmt = (int)(((((changeAmt % hund) % fifty) % twenty) % ten) / five);

            int fiveLeft = atm.getFive() - fiveAmt;
            int tenLeft = atm.getTen() - tenAmt;
            int twentyLeft = atm.getTwenty() - twentyAmt;
            int fiftyLeft = atm.getFifty() - fiftyAmt;
            int hunLeft = atm.getHun() - hunAmt;

            
            try
            {
                if (File.Exists(outFile))
                {
                    File.Delete(outFile);
                }

                using (StreamWriter sw = new StreamWriter(outFile))
                {
                    sw.WriteLine("[" + fiveLeft + " " + tenLeft + " " + twentyLeft + " " + fiftyLeft + " " + hunLeft + "]");
                    Console.WriteLine("[" + fiveLeft + " " + tenLeft + " " + twentyLeft + " " + fiftyLeft + " " + hunLeft + "]");
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
                
            }
        }
        public void go(string filename)
        {
            string line = "";
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(filename))
                {

                    // Read and display lines from the file until the end of 
                    // the file is reached.
                    while (sr.Peek() >= 0)
                    {
                        line = sr.ReadLine();
                        line = line.Remove(0, 1);
                        line = line.Remove(line.Length - 1, 1);
                        input = line.Split(',');
                        for (int i = 0; i < input.Length; i++)
                        {
                            if (input[i] == " " || input[i] == "")
                            {
                                input[i] = "0";
                            }
                            nums[i] = Int32.Parse(input[i]);
                        }

                        change.setAmt(nums[0]);
                        atm.setFive(nums[1]);
                        atm.setTen(nums[2]);
                        atm.setTwenty(nums[3]);
                        atm.setFifty(nums[4]);
                        atm.setHun(nums[5]);

                        Console.WriteLine(change.getAmt());
                        Console.WriteLine(atm.getFive());
                        Console.WriteLine(atm.getTen());
                        Console.WriteLine(atm.getTwenty());
                        Console.WriteLine(atm.getFifty());
                        Console.WriteLine(atm.getHun());

                        makeChange();



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

        public static void Main(string[] args)
        {
            Processer processer = new Processer();
            string filename;
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a file to open: ");
                filename = Console.ReadLine();
            }
            else
                filename = args[0];

            Console.WriteLine(filename);
            processer.go(filename);
            
            Console.WriteLine("Please enter any key to exit");
            Console.ReadKey();
        }

    }


}
