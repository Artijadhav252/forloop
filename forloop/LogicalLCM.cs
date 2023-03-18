using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    internal class LogicalLCM
    {
        public void Calulatelcm()
        {
            int i, num1, num2, LCM = 0;
            Console.WriteLine("Please enter any two number");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
            for(i=num2; i<=num1*num2;i++)
            {
                if (i % num1 == 0 && i%num2==0)
                {
                    LCM = i;
                    break;
                }
            }
            int GCD = num1 * num2 / LCM;
            Console.WriteLine("LCM="+LCM);
            Console.WriteLine("GCD="+GCD);
        }
       

    }
}
