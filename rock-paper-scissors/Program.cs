using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play rock-paper-scissors. Please type your answer");
            string ha;
            ha = Console.ReadLine();
            var random = new Random();
            int randomnumber = random.Next(1, 3);
            if (randomnumber == 1)
            {
                Console.WriteLine("Computer chose rock.");
                if (ha == "rock")
                {

                    Console.WriteLine("It's a tie!");
                }
                else if (ha == "paper")
                {
                    Console.WriteLine("You won!");
                }
                else
                {
                    Console.WriteLine("You lost!");
                }
            }
            else if(randomnumber==2)
            {
                Console.WriteLine("Computer chose paper.");
                if (ha == "rock")
                {
                    Console.WriteLine("You lost!");
                }
                else if (ha == "paper")
                {
                    Console.WriteLine("It's a tie!");
                }
                else
                {
                    Console.WriteLine("You won!");
                }
            }
            else
            {
                Console.WriteLine("Computer chose scissors.");
                if (ha == "rock")
                {
                    Console.WriteLine("You won!");
                }
                else if (ha == "paper")
                {
                    Console.WriteLine("You lost!");
                }
                else
                {
                    Console.WriteLine("It's a tie");
                }
            }
            Console.ReadLine();
        }
    }
}
