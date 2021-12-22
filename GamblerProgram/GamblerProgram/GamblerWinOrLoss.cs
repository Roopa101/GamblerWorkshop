using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblerProgram
{
    class GamblerWinOrLoss
    {
        public void WinOrLoss()
        {
            int Start = 100;

            Random random = new Random();

            int num = random.Next(2);

            if (num == 1)
            {
                Start++;

                Console.WriteLine("Gambler Win the $1 bet");
            }
            else
            {
                Start--;
                Console.WriteLine("Gambler Loss the $1 bet");
            }

        }
    }
}
    