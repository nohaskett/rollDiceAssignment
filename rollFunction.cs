using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rollDiceAssignment
{
    internal class rollFunction
    {
        public string PrintRolls(int numRolls)
        {
            // Initialize the dice values and total for each roll
            int die1 = 0;
            int die2 = 0;
            int totalRolled = 0;

            int[] numberCounter = new int[11];

            Random random = new Random();

            for (int iCount = 0; iCount < numRolls; iCount++)
            {
                // Randomly roll the two die 1-6
                die1 = random.Next(1, 7);
                die2 = random.Next(1, 7);

                // Add the dies together
                totalRolled = die1 + die2;

                // Increment the position in the array that matches the total for that roll (2-12)

                numberCounter[totalRolled - 2] += 1;
            }
            
            string output = "DICE ROLLING SIMULATION RESULTS\nEach '*' represents 1% of the total number of rolls.\n" +
                                     "Total Number of Rolls = " + numRolls + "\n\n";

            for (int iCount2 = 0; iCount2 < numberCounter.Length; iCount2++)
            {
                int asterikCount = (int)Math.Round((double)numberCounter[iCount2] / numRolls * 100);

                output += (iCount2 + 2) + ": " + new string('*', asterikCount) + "\n";

                // System.Console.WriteLine((iCount2 + 2) + ": " + numberCounter[iCount2] + " which is " + ((totalCalc / numRolls) * 100) + "% of all rolls\n" );
            }

            return output;
        }
    }
}
