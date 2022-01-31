using System;
using System.Threading;

namespace dice_game
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPoints = 0;
            int enemyPoints = 0;
            int playerRandomNum;
            int enemyRandomNum;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press Space To Roll The Dice");

                Console.ReadKey();

                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled " + enemyRandomNum);

                if (playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player wins this round!");
                }
                else if (playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy wins this round");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score is Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You win!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a Draw!");
            }

            Console.ReadKey();
            
        }
    }
}
