using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            char operat;
            String result;

            Console.WriteLine("Hello welcome to the calculator program");
            Console.WriteLine("Please enter your first number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Pick second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What kind of operation would you like to do");

            operat = Convert.ToChar(Console.ReadLine());

            if (operat == 'a') 
            {
                result = Convert.ToString(num1 + num2);     
            }
            else if (operat == 'd')
            {
                result = Convert.ToString(num1 + num2); 
            }
            else if (operat == 'm')
            {
                result = Convert.ToString(num1 + num2);
            }
            else if (operat == 's')
            {
                result = Convert.ToString(num1 + num2); 
            }
            else
            {
                result = "Improper operation chosen please choose s,m,d,or a";
            }

            Console.WriteLine(result);


            //this basicaly just makes the program wait for us to tap a key befor closing
            Console.ReadKey();
        }
    }
}
