using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_core_programs
{
    class EVENORODD
    {
        public void Eo()
        {
            Console.WriteLine("Enter number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("its an even number");
            else
                Console.WriteLine("its an odd");
        }
    }
}
