using System;
using System.Collections.Generic;

namespace AnagramMatcherConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            AnagramMatcher anagramMatcher = new AnagramMatcher();
            Console.WriteLine("\nTo match anagrams, enter filename in the following format:" +
                "\napple_car_cider_tar_itch_rat_cried_helicopter_arc.txt" +
                "\n\nEnter 'EXIT' to close the program");

            while (true)
            {
                var userInput = Console.ReadLine();

                //EXIT COMMAND
                if (userInput.Equals("EXIT"))
                {
                    return;
                }
                //MATCH ANAGRAMS COMMAND
                if(userInput.Length > 1)
                {
                    Console.WriteLine(Environment.NewLine);
                    anagramMatcher.Match(userInput);
                    Console.WriteLine("Enter a new filename to check another, enter 'EXIT' to exit");
                }
            }
        }
    }
}
