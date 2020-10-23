/*
*  C# CODING STANDARDS - LINE SPACE
* NOTE - A SINGLE BLANK LINE SEPARATES THE TWO BLOCKS i.e. USING STATEMENTS, CLASS DECLARATION, etc
*/

/******************************************************************************
 *  Compilation:  C:\Users\Santhu\source\repos\Snake_and_Ladder\bin\Debug\netcoreapp3.1\Snake_and_Ladder.exe
 *  Execution:    Snake_and_Ladder.exe
 *  
 *  Purpose: Snake and Ladder Game Simulator.
 *
 *  @author  Santhosh V
 *  @version 2019
 *  @since   2019
 *
 ******************************************************************************/

/// Including the requried assemblies in to the program
using System;

namespace Snake_and_Ladder
{
    class Program
    {
        /// <summary>
        /// The token position
        /// </summary>
        public static int tokenPosition = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator.");
            ///To miss one turn in case of No play option.
            int noPlay = 0;
            ///Condition to stop the game when reached 100.
            while (tokenPosition <= 100)
            {
                Console.WriteLine("Player Token position is : " + tokenPosition);
                ///Generating Random number from 1 to 6 for die function.
                Random random = new Random();
                int numberOnDice = random.Next(1, 7);
                Console.WriteLine("The number on the die is : " + numberOnDice);
                /// if no play in the previous turn skips one turn.
                if (noPlay == 1) {
                    noPlay = 0;
                    continue;
                }
                /// random number to check the options like noplay, ladder and snake.
                int optionsCheck = random.Next(1, 4);
                switch (optionsCheck)
                {
                    case 1:
                        Console.WriteLine("No Play!");
                        ///if no play then skips one turn.
                        noPlay = 1;
                        break;
                    case 2:
                        Console.WriteLine("Ladder!");
                        ///if ladder then the the player moves the number of times the die generates.
                        tokenPosition += numberOnDice;
                        break;
                    case 3:
                        Console.WriteLine("Snake!");
                        ///if snake then the player moves back the number of times the die generates.
                        tokenPosition -= numberOnDice;
                        ///if token position goes below zero then the game restarts from 0.
                        if (tokenPosition < 0)
                        {
                            tokenPosition = 0;
                        }
                        break;
                }
            }
        }
    }
}
