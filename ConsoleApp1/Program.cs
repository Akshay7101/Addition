using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int Number = 10;
            int Number1 = 20;

            Console.WriteLine("Addtion Is --- "+ Addtion(Number,Number1));
            Console.ReadLine();
        }

        public static int Addtion(int A,int B)
        {
            return A+ B;
        }
    }
}
