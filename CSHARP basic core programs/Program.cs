using System;

namespace CSHARP_basic_core_programs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO THE BASIC CORE PROGRAM");
            Console.WriteLine("enter the option");
            Console.WriteLine("1. FlipCoin Program\n" +
                "2.Leap year program\n" +
                "3.Power of Two\n" +
                "4.Harmonic Program\n" +
                "5.Factor\n" +
                "6.Qoutient and remainder\n" +
                "7.Swapping of two numbers \n" +
                "8.Vowel or consonant\n" +
                "9.Even or odd\n" +
                "10.Greatest of three\n");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Coinflip toss = new Coinflip();
                    toss.Headtail();
                    break;
                case 2:
                    LEAP leap = new LEAP();
                    leap.Leapyear();
                    break;
                case 3:
                    POWEROF2 powerof2 = new POWEROF2();
                    powerof2.Poweroftwo();
                    break;
                case 4:
                    HARMONIC harmonic = new HARMONIC();
                    harmonic.Harmonicofnth();
                    break;
                case 5:
                    FACTOR factor = new FACTOR();
                    factor.Primefacrors();
                    break;
                case 6:
                    RemainderandQoutient rq = new RemainderandQoutient();
                    rq.Qandr();
                    break;
                case 7:
                    SWAP swap = new SWAP();
                    swap.Swapoftwo();
                    break;
                case 8:
                    ALPHABETS alphabets = new ALPHABETS();
                    alphabets.Voworconst();
                    break;
                case 9:
                    EVENORODD evenodd = new EVENORODD();
                    evenodd.Eo();
                    break;
                case 10:
                    Greatestofthree great = new Greatestofthree();
                    great.Greatofthree();
                    break;
                default:
                    Console.WriteLine("enter correct option");
                    break;
            }

        }
    }
}
