using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //solves problem 1.
            string myName = "Steven";
            Console.WriteLine("Hello my name is: " + myName);

            //solves problem 2.
            string bestie = "Jennifer";
            Console.WriteLine("My best friend is: " + bestie);

            //solves problem 3.
            string[] favGames = {"Zelda", "Mario Bros.", "Metroid"};
            Console.WriteLine("My favorite games are: ");
            foreach (var item in favGames)
            {
                Console.WriteLine(item);
            }

        }
    }
}
