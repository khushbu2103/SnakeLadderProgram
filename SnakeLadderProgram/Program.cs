using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Welcome to Snake & Ladder Program");

            Console.WriteLine("Press anything to start");
            Console.ReadLine();

            int Pl1_position = 0; // player 1's starting position
            int Pl1_numberOfRolls = 0; // number of times the dice was rolled
            int Pl2_position = 0; // player 1's starting position
            int Pl2_numberOfRolls = 0; // number of times the dice was rolled
            int turn = 1; // 0 means Stop, 1 means player 1, 2 means player 2

            Random random = new Random();

            //Pl1_position < 100
            while (turn == 1 || turn == 2)
            {
                Console.WriteLine("==================");
                int Pl1_diceRoll = random.Next(1, 7);
                int Pl2_diceRoll = random.Next(1, 7);

                if (turn == 1)
                {
                    Pl1_numberOfRolls++;
                    Console.WriteLine("Dice for Player 1 Rolled: " + Pl1_diceRoll);

                    int Pl1_option = random.Next(0, 3);
                    switch (Pl1_option)
                    {
                        case 0: // No Play
                            Console.WriteLine("No Play");
                            break;
                        case 1: // Ladder
                            Pl1_position += Pl1_diceRoll;
                            Console.WriteLine("Ladder!");
                            break;
                        case 2: // Snake
                            Pl1_position -= Pl1_diceRoll;
                            Console.WriteLine("Snake!!");
                            break;
                    }

                    if (Pl1_position < 0)
                    { Pl1_position = 0; }

                    if (Pl1_position > 100)
                    {
                        //Pl1_position = 100;
                        int diff = Pl1_position - 100;
                        Pl1_position = -diff;
                    }


                    Console.WriteLine("The position for Player 1 is : " + Pl1_position);
                    if (Pl1_position == 100)
                    {
                        Console.WriteLine("The Player 1 Has Won, after total " + Pl1_numberOfRolls + " rolls");
                        turn = 0;
                    }
                    else
                    {
                        if (Pl1_option != 1)
                        {
                            turn = 2;
                        }
                    }

                }
                else if (turn == 2)
                {
                    Pl2_numberOfRolls++;
                    Console.WriteLine("Dice for Player 2 Rolled: " + Pl2_diceRoll);

                    int Pl2_option = random.Next(0, 3);
                    switch (Pl2_option)
                    {
                        case 0: // No Play
                            Console.WriteLine("No Play");
                            break;
                        case 1: // Ladder
                            Pl2_position += Pl2_diceRoll;
                            Console.WriteLine("Ladder!");
                            break;
                        case 2: // Snake
                            Pl2_position -= Pl2_diceRoll;
                            Console.WriteLine("Snake!!");
                            break;
                    }

                    if (Pl2_position < 0)
                    { Pl2_position = 0; }

                    if (Pl2_position > 100)
                    {
                        //Pl2_position = 100; 
                        int diff = Pl2_position - 100;
                        Pl2_position = -diff;

                    }


                    Console.WriteLine("The position for Player 2 is : " + Pl2_position);
                    if (Pl2_position == 100)
                    {
                        Console.WriteLine("The Player 2 Has Won, after total " + Pl2_numberOfRolls + " rolls");
                        turn = 0;
                    }
                    else
                    {
                        if (Pl2_option != 1)
                        {
                            turn = 1;
                        }
                    }
                }
                Console.WriteLine("XXXXXXXXXXXXXXXXXX");
            }

            Console.ReadLine();
        }


    }
}



