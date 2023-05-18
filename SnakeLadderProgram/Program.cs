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

            int Pl1_position = 0; // player's starting position
            int Pl1_numberOfRolls = 0; // number of times the dice was rolled

            Random random = new Random();
            int Pl1_DiceRolls=random.Next(1, 7);
            Pl1_numberOfRolls++;
            Console.WriteLine("dice for player rolled:{0}", +Pl1_DiceRolls);
           // Console.ReadLine();

            int Pl1_Option = random.Next(0, 3);
            switch (Pl1_Option)
            {
                case 0:
                    Console.WriteLine("No play");

                    break;
                case 1:
                    Pl1_position += Pl1_DiceRolls;
                    Console.WriteLine("ladder");
                    break;
                case 2:
                    Pl1_position -= Pl1_DiceRolls;
                    Console.WriteLine("snake");
                    break;

            }
            Console.WriteLine("The position for Player 1 is : " + Pl1_position);
            Console.ReadLine();
        }
        }

    }


