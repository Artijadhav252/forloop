

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
        // Patternobj1.StarPattern1();

        //StarPattern Patternobj2 = new StarPattern();
        // Patternobj2.StarPattern2();

        //StarPattern Pattern = new StarPattern();
        // Pattern.StarPattern3();

        // Patternobj1.StarPattern2();

        //Patternobj2.StarPattern2();










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