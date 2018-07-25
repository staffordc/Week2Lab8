using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentsInfoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var Repeat = true;
            while (Repeat)
            {
                //infos about students [3 rows matrix]
                string[,] StudentsInformation = new string[,] 
                {
                    {"a", "b", "c" },
                    {"d", "e", "f" },
                    {"g", "h", "i" },
                };
                
                //student nums; name out
                var number = ReadLineButItHasToBeANumberBetweenOneAndTwenty();
                //student is...
                var index = number - 1;
                Console.WriteLine($"student {number} is {StudentsInformation[index,0]}");
                //student info 1, or info 2?
                Console.WriteLine($"would you like to know more about {StudentsInformation[index, 0]}? put in either favorite color or favorite beer.");
                int choice = returnEitherFavColorOrFavBeer();
                if (choice == 1)
                {
                    Console.WriteLine($"Their favorite color is {StudentsInformation[index, 1]}");
                }
                else if (choice == 2)
                {
                    Console.WriteLine($"Their favorite beer is {StudentsInformation[index, 2]}");
                }
                Repeat = Retry();
            }

        }

        static int returnEitherFavColorOrFavBeer()
        {
            var input = Console.ReadLine().ToLower();
            if (input == "favorite color")
            {
                return 1;
            }
            else if (input == "favorite beer")
            {
                return 2;
            }
            else
            {
                Console.WriteLine("please input favorite beer or favorite color");
                return returnEitherFavColorOrFavBeer();
            }
        }

        static int ReadLineButItHasToBeANumberBetweenOneAndTwenty()
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out var number) && number >= 1 && number <= 20)
            {
                return number;
            }
            else 
            {
                Console.WriteLine("I noticed this is not a number between 1 and 20. could you make it be a number between one and twenty?");
                return ReadLineButItHasToBeANumberBetweenOneAndTwenty();
            }
        }

        static bool Retry()
        {
            Console.WriteLine("\n continue? yes or no please.");
            String Answer = Console.ReadLine().ToUpper();

            if (Answer == "Y" || Answer == "YES")
            {
            return true;
            }
            else if (Answer == "N" || Answer == "NO")
            {
            return false;
            }
            else
            {
            Console.WriteLine("\n i don't know that. please input y or n.");
            return Retry();
            }
        }
    }
}
