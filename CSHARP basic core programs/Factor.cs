using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_core_programs
{
    class FACTOR
    {
        public void Primefacrors()
        {
            Console.WriteLine("Enter the number to get factor");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    Console.Write(i + ",");
                    number /= i;
                }
            }
        }
    }
}
