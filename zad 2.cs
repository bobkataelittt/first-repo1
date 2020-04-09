using System;

namespace zad_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                string comm = input[0].ToLower();
                switch (comm)
                {
                    case "a":
                        {
                            phonebook.Add(input[1], input[2]);
                            break;
                        }
                    case "s":
                        {
                            if (phonebook.ContainsKey(input[1]))
                            {
                                Console.WriteLine($"Name: {input[1]} -> {phonebook[1]]}");

                            }
                            else
                            {
                                Console.WriteLine($"This contact doesnt exist");
                            }
                            break;
                        }
                    case "end":
                        {
                            return;
                        }

                }
            }
        }
    }
}
