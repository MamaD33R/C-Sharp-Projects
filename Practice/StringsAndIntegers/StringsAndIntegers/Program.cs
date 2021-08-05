using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Format exception
            // Divide by 0 exception

            try
            {
                List<int> numbers = new List<int>();
                List<int> numbers2 = new List<int>();

                numbers.Add(240);
                numbers.Add(50);
                numbers.Add(100);
                numbers.Add(40);
                numbers.Add(10);

                Console.WriteLine("Please select a number to divide with!");
                int divide = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    int divide2 = number / divide;
                    Console.WriteLine(divide2);
                }

                Console.ReadLine();
            }
            catch (FormatException ex) // if they enter a string
            {
                Console.WriteLine("Wrong format. Please enter a number!");
            }
            catch (DivideByZeroException ex) // if they divide by zero
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // For general issues
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("The program has emerged from try/catch block");
            }
            Console.ReadLine();
        }
    }
}
