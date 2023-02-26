using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    internal class pattern
    {
        public static void pattern1()
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

        public static void pattern2()
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

        public static void pattern3()
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
        public static void pattern4()
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

        public static void pattern5()
        {
            Console.WriteLine("please enter the value for row");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("please enter the value for column");
            int column = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=row; i++)
            {
                for(int j=1; j<=column; j++)
                {
                    Console.Write(" "+ Convert.ToChar(64+j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");

        }

        public static void pattern6()
        {
            Console.WriteLine("Please enter the value for row");
            int row = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the value for column");
            int column = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=row; i++)
            {
                for(int j=1; j<=column; j++)
                {
                    Console.Write(" "+Convert.ToChar(64+i));
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");



        }

       

    }
}
