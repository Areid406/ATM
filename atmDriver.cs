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
