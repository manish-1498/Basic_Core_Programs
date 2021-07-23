using System;
using System.Collections.Generic;
using System.Text;

namespace CSHARP_basic_core_programs
{
    class ALPHABETS
    {
        public void Voworconst()
        {
            Console.WriteLine("enter the alphabet");
            char ch = Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                Console.WriteLine("Alphabet is a Vowel");
            else
                Console.WriteLine("Alphabet is a consonant");
        }
    }
}
