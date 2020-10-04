using System;
using System.Security.Cryptography;

namespace Snake_And_Ladders_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------\n       SNAKES AND LADDERS       \n------------------------------------");
            Console.WriteLine("GAME MODE \n" + " 1. Single Player \n" + " 2. Multiplayer \n Enter the number...");
            int mode = Convert.ToInt16(Console.ReadLine());
            switch (mode)
            {
                case 1:
                    {
                        SinglePlayer singlePlayer = new SinglePlayer();
                        singlePlayer.loop();
                        break;
                    }
                case 2:
                    {
                        Multiplayer player_1 = new Multiplayer();
                        Multiplayer player_2 = new Multiplayer();
                        int player1_pos = 0;
                        int player2_pos = 0;
                        for(int i=0; ;i++)
                        {
                            int playerOne = player_1.multiplayer(1, player1_pos);
                            player1_pos = playerOne;
                            if (player1_pos == 100)
                                break;
                            int playerTwo = player_2.multiplayer(2,player2_pos);
                            player2_pos = playerTwo;
                            if(player2_pos == 100)
                                break;
                           
                           
                        }
                        break;
                    }
            }
        }
    }
}
