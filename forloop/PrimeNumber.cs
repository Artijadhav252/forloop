using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    internal class PrimeNumber
    {
        public void CheckPrimeNumber()
        {
            Console.WriteLine("Please enter any number");
            int num=Convert.ToInt32(Console.ReadLine());

            int counter=0;
            for(int i=1;i<=num;i++)
            {
                if(num % i == 0)
                {
                    counter++;
                }
            }
            if(counter == 2)
            {
                Console.WriteLine("Given number is prime");
            }
            
        }
    }
}
