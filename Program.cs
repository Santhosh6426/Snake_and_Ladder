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
        public static int[] player1 = { 0, 0 };
        public static int[] player2 = { 0, 0 };
        public static int[] returnValues = { 0, 0 };
        public static int repeatIfLadder = 0;
        /// <summary>
        /// The token position
        /// </summary>
        ///public static int tokenPosition = 0;
        ///public static int noOfTimesDiceRolled = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake and Ladder Simulator.");
            ///flag to toggle between the players.
            Boolean flag = true;
            ///Set the condition to stop the play after a player reaches 100.
            while (player1[0] < 100 && player2[0] < 100)
            {
                if (flag == true)
                {
                    ///Storing the player 1 values in an array
                    int[] returnedValue = NumberOfRoles(player1[0], player1[1]);
                    player1[0] = returnedValue[0];///storing players token position in 0th index
                    player1[1] = returnedValue[1];///storing no of times dice rolled by the player.
                    Console.WriteLine("Player : 1     Player's token position : " + player1[0] + "     Num of times Dice Rolled : " + player1[1]);
                    ///if ladder was the option then player gets one more chance.
                    if (repeatIfLadder == 1)
                    {
                        repeatIfLadder = 0;
                        continue;
                    }
                    flag = false;
                }
                if (flag == false)
                {
                    int[] returnedValue = NumberOfRoles(player2[0], player2[1]);
                    player2[0] = returnedValue[0];///storing players token position in 0th index
                    player2[1] = returnedValue[1];///storing no of times dice rolled by the player.
                    Console.WriteLine("Player : 2     Player's token position : " + player2[0] + "     Num of times Dice Rolled : " + player2[1]);
                    ///if ladder was the option then player gets one more chance.
                    if (repeatIfLadder == 1)
                    {
                        repeatIfLadder = 0;
                        continue;
                    }
                    flag = true;
                }
            }
        }
        /// <summary>
        /// to get Numbers of times dice rolled.
        /// </summary>
        /// <param name="tokenPosition">The token position.</param>
        /// <param name="noOfTimesDiceRolled">The no of times dice rolled.</param>
        /// <returns></returns>
        public static int[] NumberOfRoles(int tokenPosition, int noOfTimesDiceRolled)
        {
            ///Console.WriteLine("Players Token position is : " + tokenPosition);
            ///Condition to stop the game when reached 100.

            ///Generating Random number from 1 to 6 for die function.
            Random random = new Random();
            int numberOnDice = random.Next(1, 7);
            Console.WriteLine("\nThe number on the die is : " + numberOnDice);
            /// random number to check the options like noplay, ladder and snake.
            int optionsCheck = random.Next(1, 4);
            switch (optionsCheck)
            {
                case 1:
                    Console.WriteLine("No Play!");
                    break;
                case 2:
                    Console.WriteLine("Ladder!");
                    ///to set exact win position to 100.
                    if ((tokenPosition + numberOnDice) > 100)
                    {
                        repeatIfLadder = 1;
                        break;
                    }
                    ///if ladder then the the player moves the number of times the die generates.
                    tokenPosition += numberOnDice;
                    repeatIfLadder = 1;
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
            ///Console.WriteLine("Player Token position is : " + tokenPosition);
            noOfTimesDiceRolled++;
            returnValues[0] = tokenPosition;
            returnValues[1] = noOfTimesDiceRolled;
            return returnValues;

            ///Console.WriteLine("Number of Times Dice Rolled : " + noOfTimesDiceRolled);
        }
    }
}
