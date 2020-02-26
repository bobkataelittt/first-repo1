using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                arr[i] = input;
            }
            Array.Reverse(arr);
            foreach (string val in arr)
            {
                Console.Write($" {val} ");
            }
            Console.ReadKey();

        }
    }
}
