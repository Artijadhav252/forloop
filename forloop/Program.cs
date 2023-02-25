public class Program
{
    public static void Main()
    {
        FirstNestedLoop1();
        SecondNestedLoop2();
        ThirdNestedLoop3();
        FourthNestedLoop4();
        FifthNestedLoop5();
        SixthNestedLoop();

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