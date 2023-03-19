using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FoorLoopDemo
{
    internal class Prime_Number
    {
        public void CheckPrimeNumber()
        {
            Console.WriteLine("please Enter any number");
            int num= Convert.ToInt32(Console.ReadLine());   

            int counter = 0;
            for (int i =1; i < num; i++)
            {
                if( num % i == 0 ) 
                    
                    counter++;
            }

            if (counter == 2)
            {
                Console.WriteLine(" The number is prime number");
            }
            else
            {
                Console.WriteLine("The number is not a prime number");
            }
        }
              
        
    }
}
