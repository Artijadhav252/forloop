using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    internal class StarPattern
    {
        public int num { get; set; }

        private void GetNumberFromUser()
        {
            Console.WriteLine("Please enter any number");
            num = Convert.ToInt32(Console.ReadLine());


        }
        public void StarPattern1()
        {
            GetNumberFromUser();

            for (int i = 1; i <= num; i++)
            {

                for (int j = 0; j <= num; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        public void StarPattern2()
        {
            GetNumberFromUser();

            for (int i = num; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void StarPattern3()
        {
            GetNumberFromUser();
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }




        public static void Staticfunction()
        {
            Staticfunction();

            StarPattern Pattern = new StarPattern();
            Pattern.NonStaticFunction1();



        }

        public void NonStaticFunction1()
        {
            Staticfunction();
            NonStaticFunction1();

        }
    }
}
