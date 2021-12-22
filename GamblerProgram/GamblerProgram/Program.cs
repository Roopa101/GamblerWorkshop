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
            double cash;
            double betAmount;
            Console.WriteLine("Welcome to Gambler Game");
            Console.WriteLine("Please Enter Cash Amount");
            cash = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Bet Amount");
            betAmount = double.Parse(Console.ReadLine());
        }
    }
}
        