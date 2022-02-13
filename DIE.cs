using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Allen Atkins
 * CST-150 
 * THIS IS MY WORK 
 */
namespace DICEGAME_ACTIVITY_11_
{
   public class DIE
    {
        private int NUMBER_OF_SIDES;
        private static Random FACE_SIDE = new Random();

        public DIE(int NUMBER_OF_SIDES)
        {
            if (NUMBER_OF_SIDES > 4 || NUMBER_OF_SIDES > 20)
            {
                Console.WriteLine("Number should be in the range between 4 and 20.");
                
            }
            this.NUMBER_OF_SIDES = NUMBER_OF_SIDES;
        }

        public int rollDie()
        {

            return FACE_SIDE.Next(1, NUMBER_OF_SIDES + 1);
        }
    }
}
