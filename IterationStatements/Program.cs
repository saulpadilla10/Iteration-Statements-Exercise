using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading.Tasks;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        //Write a method to check whether a given number is even or odd

        //Write a method to check whether a given number is positive or negative

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        //Write a method to display the multiplication table(from 1 to 12) of a given integer


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            //PrintAGrand();

            //CountbyThrees();

            //Console.WriteLine(TwoOfAKind(4, 5));

            //OddsNEvens(5001);

            //YouVote();

            //Console.WriteLine(IfPositive(35));

            //Console.WriteLine(TensOurRange(3));

            //Ultiply(100);
        }
        
        public static void PrintAGrand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void CountbyThrees()
        {
            for (int t = 3; t <= 999; t +=3)
            {
                Console.WriteLine(t);
            }

        }

        public static bool TwoOfAKind(int a, int b)
        {
            var check = (a == b) ? true : false;
            return check;
        }

        public static bool IfPositive(int num1)
        {
            if (num1 > 0)
            {
                return true;
            }

            return false;

        }

        public static void YouVote()

        {
            Console.WriteLine("Age?");

            string input = Console.ReadLine();

            int VoterAge = int.Parse(input);

            var voter = 21;

            if (VoterAge < voter)
            {
                Console.WriteLine("No vote for you!");
            }
            else if (VoterAge >= voter)
            {
                Console.WriteLine("Ok, you're in!");
            }
        }

        public static void OddsNEvens(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"Even stevens!");
            }
            else
            {
                Console.WriteLine($"ODD!");
            }
        }

        public static bool TensOurRange(int num)
        {
            if (num <= 10 && num >= -10)
            {
                return true;
            }
            return false;
        }

        public static void Ultiply(int n)
        {

            {
              
                for (int i = 1; i <= 12; ++i)
                {
                    Console.WriteLine(n + "*" + i + "=" + n * i);
        
                }

               
               
            }
        }




    }

}
