using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_And_Ladders_Game
{
    public class Multiplayer
    {

        //Constants
        int START = 0;
       

        Random randomNum = new Random();

        // Variables

        int option = 0;
        int dice = 0;
       

        public int multiplayer(int p, int position)
        {
            int player_pos = position;
            int player_no = p;
            
                
                do
                {
                    dice = randomNum.Next(1, 7);
                    option = randomNum.Next(0, 3);
                    Console.WriteLine("\nPlayer"+player_no +"Position: " + player_pos);
                    Console.WriteLine("The dice rolled : " + dice);
                    switch (option)
                    {
                        case 0:
                            {
                                Console.WriteLine("Player "+player_no+"got NO PLAY");
                                player_pos = player_pos + 0;
                                Console.WriteLine("Player"+player_no +"position after this turn: " + player_pos);
                                break;
                            }

                        case 1:
                            {
                                Console.WriteLine("Player"+player_no+" got SNAKE");
                                player_pos = player_pos - dice;
                                if (player_pos < 0)
                                {
                                    player_pos = START;
                                }
                                Console.WriteLine("Player"+player_no+" position after this turn: " + player_pos);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Player"+player_no+" got LADDER");
                                player_pos = player_pos + dice;
                                if (player_pos > 100)
                                {
                                    player_pos = player_pos - dice;
                                    Console.WriteLine("Can't play more than 100");
                                }
                                Console.WriteLine("Player" +player_no+" position after this turn = " + player_pos);
                                break;
                            }
                    }
                    if (player_pos == 100)
                    {
                        Console.WriteLine("Player "+player_no+" won");
                    Console.WriteLine("GAME OVER");
                        break;
                    }
                } while (dice == 6);


            return (player_pos);
            
        }
    }
}
