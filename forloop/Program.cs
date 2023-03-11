

using forloop;
using System.Net.Http.Headers;

public class Program
{
    public static void Main()
    {
        //FirstNestedLoop1();
        //SecondNestedLoop2();
        //ThirdNestedLoop3();
        //FourthNestedLoop4();
        //FifthNestedLoop5();
        //SixthNestedLoop();

        //PatternNumbers.PatternNumbers1();
        //PatternNumbers.PatternNumbers2();
        //PatternNumbers.PatternNumbers4();


        //Alphabate.pattern1();
        //Alphabate.pattern2();

        //pattern.Staticfunction();

        //pattern Pattern = new pattern();
        // Pattern.NonStaticFunction1();



        //StarPattern Patternobj1 = new StarPattern();
        //Patternobj1.StarPattern1();

        StarPattern Patternobj2 = new StarPattern();
        Patternobj2.StarPattern2();

        StarPattern patternobj3 = new StarPattern();
        patternobj3.StarPattern3();

        StarPattern Patternobj4 = new StarPattern();
        Patternobj4.StarPattern4();

        StarPattern Patternobj5 = new StarPattern();
        Patternobj5.StarPttern5();

        StarPattern Patternobj6 = new StarPattern();
        Patternobj6.StarPattern6();










        static void FirstNestedLoop1()
        {
            Console.WriteLine("-------------------------------------------");

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine();

            }

        }

        static void SecondNestedLoop2()
        {
            Console.WriteLine("-------------------------------------------");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= 1; j--)
                {
                    Console.Write(j);
                }

                Console.WriteLine();
            }

        }

        static void ThirdNestedLoop3()
        {
            Console.WriteLine("-------------------------------------------");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }

        }

        static void FourthNestedLoop4()
        {
            Console.WriteLine("-------------------------------------------");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 5; j >= 1; j--)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }

        }

        static void FifthNestedLoop5()
        {
            Console.WriteLine("-------------------------------------------");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }


        static void SixthNestedLoop()
        {
            Console.WriteLine("-------------------------------------------");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


        }



    }

}