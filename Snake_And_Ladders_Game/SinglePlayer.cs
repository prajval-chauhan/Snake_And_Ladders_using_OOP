using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladders_Game
{
    public class SinglePlayer
    {
        Random randomNum = new Random();
        //Constants
        int START = 0;
        int FINAL = 100;

        // Variables

        int option = 0;
        int dice = 0;
        int turns = 0;
        public void loop()
        {
            //For Single Player
            int player_pos = START;

            for (int i = 0; ; i++)
            {
                if (player_pos == FINAL)
                    break;

                turns = i;
                Console.WriteLine("No. of turns played by the player : " + turns);
                Console.WriteLine("\nPlayer's Position : " + player_pos);
                dice = randomNum.Next(1, 7);
                Console.WriteLine("Dice rolled number : " + dice);
                option = randomNum.Next(0, 3);
                switch (option)
                {
                    case 0:
                        {
                            Console.WriteLine("No Play");
                            player_pos = player_pos + 0;
                            Console.WriteLine("Player position after this turn: " + player_pos);
                            break;
                        }
                    case 1:
                        {
                            player_pos = player_pos + dice;
                            if (player_pos > 100)
                            {
                                Console.WriteLine("No Play");
                                player_pos = player_pos - dice;
                                Console.WriteLine("Player position after this turn: " + player_pos);
                            }
                            if (player_pos == FINAL)
                            {
                                Console.WriteLine("Ladder");
                                Console.WriteLine("Player position after this turn: " + player_pos + "\nYOU WON");
                            }
                            else
                            {
                                Console.WriteLine("Ladder");
                                Console.WriteLine("Player position after this turn: " + player_pos);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Snake");
                            player_pos = player_pos - dice;
                            if (player_pos >= 0)
                            {
                                Console.WriteLine("Player position after this turn: " + player_pos);
                            }
                            else
                            {
                                player_pos = 0;
                                Console.WriteLine("Player position after this turn: " + player_pos);
                            }
                            break;
                        }
                }
            }
        }
    }
}
