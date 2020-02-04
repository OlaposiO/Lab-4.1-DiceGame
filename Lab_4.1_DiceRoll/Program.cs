using System;

namespace Lab_4._1_DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {

                Console.WriteLine("How many sides do your die have?");
                int dieFirst = int.Parse(Console.ReadLine());
                int dieSecond = dieFirst;

                int num1 = RollDice(dieFirst);
                int num2 = RollDice(dieSecond);

                if (dieFirst == 6)
                {
                    DiceCombinations(num1, num2);
                }
                else
                {
                    DnDDice(num1, num2);
                }

            } while (Continue_Program());
        }

        static int RollDice(int side)
        {
            Random randomNumber = new Random();

          int dieSide = randomNumber.Next(1, (side + 1));

            return dieSide;
        }
        static void DiceCombinations(int die1, int die2)
        {
            int sum = die1 + die2;
            Console.WriteLine($"You rolled {die1} & {die2}");
          if (sum == 3 || sum == 12 || sum == 2)
          {
                Console.WriteLine($"Craps! Looks like you rolled a {sum}");
                TypeOfRoll(sum);
            }
            else if (sum == 7 || sum == 11)
            {
                Console.WriteLine($"We have a winner! You rolled a {sum}");
            }
            else
            {
                Console.WriteLine($"You rolled {sum}");
            }
            

        }

        static void TypeOfRoll(int sum)
        {
            if (sum == 2) { Console.WriteLine("SnakeEyes"); }
            if (sum == 3) { Console.WriteLine("Ace Deuce"); }
            if (sum == 12) { Console.WriteLine("Box Cars!"); }
            
        }

        static void DnDDice(int die1, int die2)
        {
            int sum = die1 + die2;
            Console.WriteLine($"You rolled {die1} & {die2}");

            Console.WriteLine($"This equals {sum}");
        }

        static bool Continue_Program()
        {
            char c;
            do
            {
                Console.Write("Would you like to roll again? (y/n)? << ");
                c = Console.ReadKey().KeyChar;
                if (c == 'n' || c == 'N')
                {
                    Console.WriteLine("\nGoodBye");
                    return false;
                }
                Console.WriteLine();
            } while (c != 'y' && c != 'Y');
            return true;
        }


    }
}
