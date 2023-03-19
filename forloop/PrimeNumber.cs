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
                Console.WriteLine("Given number is prime"+num);
            }
            
        }

        public void primenumberlimit()
        {
            int num, i, count, num1, num2;
            Console.WriteLine("Enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the limit of the number");
            num2= Convert.ToInt32(Console.ReadLine());
            for(num=num1; num<=num2;num++)
            {
                count = 0;
                 for(i=2; i<=num/2;i++)
                {
                    if(num%i==0)
                    {
                        count++;
                        break;

                    }
                }
                 if(count==0 && num!=1)
                {
                    Console.Write("{0} ",num);
                }
            }
        }
       
    }
}
