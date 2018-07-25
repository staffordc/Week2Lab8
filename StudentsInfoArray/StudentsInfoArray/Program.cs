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
                Console.WriteLine("want to hear about students from another dimension? I know of twenty of them. input 1 to 20");
                string[,] StudentsInformation = new string[,] 
                {
                    {"Grimblo Bim", "Puce", "Grimbrew's Brew" },
                    {"Beefaroni Phoney", "Purple", "Phoney Baloney" },
                    {"Shmaple Apple", "Red Delicious", "Apple Thumpkin Gang" },
                    {"Figgy Pudding", "Goldenrod", "Gromblo's Brew" },
                    {"Ham Hocks", "Gold", "Apple Thumpkin Ale" },
                    {"Little Debbie", "Fire Brick", "Gromb's Cookie Stout" },
                    {"Hanonymus Bosch", "Peach Puff", "Gromb's Peach Delight" },
                    {"Billy billy von Billy", "Deep Sky Blue", "Blue Gold Apple" },
                    {"Fitzhugh Nicely", "Pale Turquoise", "Skrumpkin Lager" },
                    {"Bob the Beggar", "Plum", "Skrumpkin Ale" },
                    {"Half-wit Henry", "Medium Sea Green", "Skrumpkin Stout" },
                    {"Legs Akimbo", "Beige", "Grimbrew's Brew: Gold" },
                    {"Rott Weiler", "Green", "Grimbrew's St. Paddy's Day Cider" },
                    {"Tito Watts", "Chartreuse", "Gromblo's Ale" },
                    {"Henry Bo Benry", "Medium Purple", "Gromblo's Stout" },
                    {"John Silva", "Tan", "Gromblo's Pommblo Stout" },
                    {"Gnome Johnson", "Orange", "Gromblo's Orange Saison" },
                    {"Jerome Smonson", "Dark Green", "Gromblo's Light Ale" },
                    {"Som Wattson", "Green Yellow", "Gromblo's Lemon Shandy" },
                    {"Ratt Chatterson", "Burly Wood", "Grimbrew's Yummy Scrumptious Stout" },
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
            Console.WriteLine("\ncontinue? yes or no please.");
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
            Console.WriteLine("\ni don't know that. please input y or n.");
            return Retry();
            }
        }
    }
}
