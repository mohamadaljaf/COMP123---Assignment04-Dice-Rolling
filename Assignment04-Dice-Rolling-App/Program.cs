///------------------------------------------------------------------------------------------
///   Project:              Assignment 04 - Dice Rolling
/// 
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   March 20, 2015
///   
///   Program description:  A program that rolls a set of dice for a user-input number of
///                         times and displays the tally of the sum of the two dice rolled.
///                         
///   Revision History:     2015-03-15: Initial build
///                         2015-03-15: Added a Dice class and implemented the rollDice method
///                         2015-03-15: Fixed an issue where the tally numbers were incorrect
///                         2015-03-15: Added documentation
///                         2015-03-20: Added more documentation
///------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_Dice_Rolling_App
{
    class Program
    {
        static void Main(string[] args)
        {
            RollingDice dice = new RollingDice();
            int numOfTimes = 0;

            // gets the number of times the dice is to be rolled
            do
            {
                Console.Write("Enter the amount of times to roll the dice: ");

                try
                {
                    numOfTimes = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("-----------------");
                    Console.WriteLine("Why are you trying to break this here program, sir?");
                    Console.WriteLine("-----------------");
                    continue;
                }
            } while (numOfTimes == 0);
            
            dice.rollDice(numOfTimes);

            Console.WriteLine("-----------------");
            Console.WriteLine(" Value \t Tally");
            Console.WriteLine("-----------------");

            // displays the sum from 2 to 12 and the tally of each sum
            for (int i = 2; i < 13; i++)
            {
                Console.WriteLine(" {0} \t {1}", i, dice.SumTally[i - 2]);
            }

            waitForAnyKey();
        }

        // pauses the program and waits for the user to confirm exit
        private static void waitForAnyKey()
        {
            Console.Write("\n");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Please hit any key to exit...");

            Console.ReadKey();
        }
    }
}
