using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string i = "5";
            int x = 20;
            decimal y = 2.2m;

            int result1 = Math.Add(x);
            Console.WriteLine(result1);

            decimal result2 = Math.Add(y);
            Console.WriteLine(result2);

            int result3 = Math.Add(i);
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
