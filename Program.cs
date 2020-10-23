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
            Console.WriteLine("Player Token position is : "+tokenPosition);
        }
    }
}
