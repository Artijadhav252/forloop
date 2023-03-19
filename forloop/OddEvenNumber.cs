using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace forloop
{
    internal class OddEvenNumber
    {
        public void evenNumber()
        {
            Console.WriteLine("Please enter any number");
            int limit=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=limit;i++)
            {
                if(i%2==0)
                {
                    Console.Write(i+" ");
                }
            }
            Console.WriteLine();
            
        }

        public void oddNumber()
        {
            Console.WriteLine("Please enter any number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=num;i++)
            {
                if( i%2==1)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
