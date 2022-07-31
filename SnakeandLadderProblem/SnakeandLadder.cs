using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeandLadderProblem
{
    internal class SnakeandLadder
    {
        public static void SinglePlayerUC1()
        {
            Console.WriteLine("**Welcome to the Snake and Ladder Game**");

            //Snake and Ladder game played with single player at start position 0	

            int position = 0;
            Console.WriteLine("You are at Starting Position: " + position);

        }


        public static void SnakeandLadderUC2()
        {
            Console.WriteLine("**Welcome to the Snake and Ladder Game**");

            int position = 0;
            Console.WriteLine("You are at Starting Position: " + position);

            Random obj = new Random();
            int rollDice = obj.Next(1, 7);

            Console.WriteLine("Dice Value: " + rollDice);

        }

        public static int dicecount = 0;
        public static int num1;
        public static int position = 0;
        public static void SnakeandLadderUC3()
        {
            //int dicecount = 0;
            //int num1;
            //int position = 0;

            //Random number for rolldice
            Random obj = new Random();
            int rollDice = obj.Next(1, 7);
            Console.WriteLine("Dice Value: " + rollDice);

            //Random numbers for position
            Random num = new Random();
            int value = num.Next(1, 4);
            Console.WriteLine("case number is " + value);


            if (value == 1)
            {

                Console.WriteLine("You got NO PLAY Option");

            }
            else if (value == 2)
            {
                Console.WriteLine("You got Ladder Option");

                position = position + rollDice;
                Console.WriteLine(" your position: {0}", position);

            }
            else
            {
                Console.WriteLine("You got Snake Option");


                position = position - rollDice;
                Console.WriteLine("You got snake \n your position: {0} \n ", position);

            }

        }

        
        public static void SankeandLadderUC4()
        {
            Random obj = new Random();
            int rollDice = obj.Next(1, 7);
            Console.WriteLine("Dice Value: " + rollDice);

            Random num = new Random();
            int value = num.Next(1, 4);
            Console.WriteLine("case number is " + value);

            if (value == 1)
            {

                Console.WriteLine("You got NO PLAY Option");

            }
            else if (value == 2)
            {
                Console.WriteLine("You got Ladder Option");

                position = position + rollDice;

                if (position > 100)
                {

                    position = position - rollDice;
                    Console.WriteLine("You got Ladder");


                }

                Console.WriteLine(" your position: {0}", position);

            }
            else
            {
                position = position - rollDice;

                Console.WriteLine("You got Snake Option");

                if (position < 0)
                {

                    position = 0;

                    Console.WriteLine("Starting game  again");


                }
                Console.WriteLine("You got snake \n your position: {0} \n ", position);

            }

        }

        public static void SnakeandLadderUC5()
        {
            Random obj = new Random();
            int rollDice = obj.Next(1, 7);
            Console.WriteLine("Dice Value: " + rollDice);

            Random num = new Random();
            int value = num.Next(1, 4);
            Console.WriteLine("case number is " + value);

            if (value == 1)
            {

                Console.WriteLine("You got NO PLAY Option");

            }
            else if (value == 2)
            {
                Console.WriteLine("You got Ladder Option");

                position = position + rollDice;

                if (position > 100)
                {

                    position = position - rollDice;
                    Console.WriteLine("You got Ladder");


                }

                Console.WriteLine(" your position: {0}", position);

            }
            else
            {
                position = position - rollDice;

                Console.WriteLine("You got Snake Option");

                if (position < 0)
                {

                    position = 0;

                    Console.WriteLine("Starting game  again");


                }
                Console.WriteLine("You got snake \n your position: {0} \n ", position);

            }
        }

    }
}
