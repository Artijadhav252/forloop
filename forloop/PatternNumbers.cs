using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{


    internal class PatternNumbers
    {

        public int num { get; set; }


        public static void PatternNumbers1()
        {
            Console.WriteLine("please enter the limit");
            string str = Console.ReadLine();
            var limit = Convert.ToInt32(str);

            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= limit; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------------------------");


        }

        public static void PatternNumbers2()
        {
            Console.WriteLine("please enter the limit");
            string str = Console.ReadLine();
            var limit = Convert.ToInt32(str);

            for (int i = 1; i <= limit; i++)
            {
                for (int j = 1; j <= limit; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------------------------");

        }

       
        public static void PatternNumbers4()
        {
            Console.WriteLine("please enter any limit");
            string str = Console.ReadLine();
            var limit = Convert.ToInt32(str);

            for (int i = 1; i <= limit; i++)
            {

                for (int j = limit; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
        }

        



    }
}
