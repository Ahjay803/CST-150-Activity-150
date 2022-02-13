using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Allen Atkins 
 * cst-150 
 * THIS IS MY WORK!!
 */
namespace DICEGAME_ACTIVITY_11_
{
    class Program
    {
        public static void Main()
        {
            DIE die1 = new DIE(6);
            DIE die2 = new DIE(6);

            int die1roll, die2roll;
            int rolls = 0;



            do
            {
                die1roll = die1.rollDie();
                die2roll = die2.rollDie();
                Console.WriteLine("Rolled [ " + "die1: " + die1roll + " die2: " + die2roll + " ]");
                rolls++;

            }
            while (die1roll != 1 || die2roll != 1);
            Console.WriteLine("\n It took user " + rolls + " rolls to get snake eyes.");
            Console.ReadLine();
        }
    }
}
