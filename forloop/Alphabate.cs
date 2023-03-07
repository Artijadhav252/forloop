using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    internal class Alphabate
    {
        public int num { get; set; }
        public static void pattern1()
        {
            Console.WriteLine("please enter the value for row");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the value for column");
            int column = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    Console.Write(" " + Convert.ToChar(64 + j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");

        }

        public static void pattern2()
        {
            Console.WriteLine("Please enter the value for row");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for column");
            int column = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    Console.Write(" " + Convert.ToChar(64 + i));
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");



        }

    }
}
