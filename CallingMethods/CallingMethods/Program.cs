using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What number do you want to use for math operation?");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number added by 100: ");
            Math.Addition(i);
            Math.Multi(i);
            Math.Divi(i);

            Console.ReadLine();
        }
    }
}
