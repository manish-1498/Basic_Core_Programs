using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_core_programs
{
    class HARMONIC
    {
        public void Harmonicofnth()
        {
            Console.WriteLine("Enter the nth term");
            double nthterm = Convert.ToInt32(Console.ReadLine());
            double sum = 0;
            for (double i = 1; i <= nthterm; i++)
            {
                sum += (1 / i);
                Console.Write("+ " + "1/" + i);
            }
            Console.WriteLine("  = " + sum);


        }
    }
}
