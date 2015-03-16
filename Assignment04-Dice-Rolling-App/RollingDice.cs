///------------------------------------------------------------------------------------------
///   Author:               Mohamad Al-Jaf   
///   
///   Date last modified:   March 15, 2015
///   
///   Class description:    A set of rolling dice that tallies the sum of both dice and allows
///                         the user to roll the dice an x amount of times.
///------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment04_Dice_Rolling_App
{
    // RollingDice class - blueprint for rolling dice objects
    class RollingDice
    {
        // INSTANCE VARIABLES ******************************************
        private Random randNum;
        private int[] _dieValue;
        private int[] _sumTally;

        // PROPERTIES ******************************************
        public int[] SumTally { get { return _sumTally; } } // Read-Only

        // CONSTRUCTOR(S) ******************************************
        public RollingDice()
        {
            randNum = new Random();
            _dieValue = new int[2];
            _sumTally = new int[11];
        }

        // rolls the dice a number of times and tallies the sum
        public void rollDice(int numOfTimes)
        {
            for (int i = 0; i < numOfTimes; i++)
			{
                _dieValue[0] = randNum.Next(1, 7);
                _dieValue[1] = randNum.Next(1, 7);
                _sumTally[_dieValue[0] + _dieValue[1] - 2]++; //increases the tally of the sum by one
			}
        }
    }
}
