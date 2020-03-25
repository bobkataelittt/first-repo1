using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace email_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = Console.ReadLine();

            if(myString.Length < 7)
            {
                Console.WriteLine("String is too small");
            }
            else
            {
                int length = myString.Length;
                                                            
                Console.WriteLine($"wihout first 3: {myString.Substring(3)}");  //tword
                Console.WriteLine($"without last 3: {myString.Substring(0, length - 3)}");
                Console.WriteLine($"without first and last 3: {myString.Substring(3, length - 6)}");

            }
            Console.ReadLine();
        }
    }
}
