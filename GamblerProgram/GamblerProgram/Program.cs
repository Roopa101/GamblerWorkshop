using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamblerProgram
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Gambler Progarm ");

            GamblerWinOrLoss gamblerWinOrLoss = new GamblerWinOrLoss();

            gamblerWinOrLoss.WinOrLoss();
            Console.ReadLine();
        }
    }
}

