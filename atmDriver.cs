/* atmDriver -version 0.1 - authored by Alex Reid
 * For use in CSCI305 Fall 2016 Lab #4 - ATM 
 * 
 * atmDriver reads in a file name from the command line or as a given argument
 * atmDriver then passes the file to atmProcessor as an argument for the constructor
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atm
{
    class atmDriver
    {
        static void Main(string[] args)
        {
            string filename;
            if (args.Length == 0)
            {
                Console.WriteLine("Please enter a file to open: ");
                filename = Console.ReadLine();
            }
            else
                filename = args[0];

            atmProcessor process = new atmProcessor(filename);
            process.go();
        }
    }
}
