using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace actfour
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)

        {
            Console.WriteLine("type a number");

            string theNumberAsAString = Console.ReadLine();
            int theNumber;
            if(int.TryParse(theNumberAsAString, out theNumber))
            {
                Console.WriteLine("the number was" + theNumber);
            }
            else
            {
                Console.WriteLine("Not a Number");
            }
            
        }
    }
}
