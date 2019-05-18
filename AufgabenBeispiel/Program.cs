using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzTest
{
    class Program
    {
        private static int _Zahl;
        private static int _Fizz;
        private static int _Buzz;
        private static int _FizzBuzz;

        static void Main(string[] args)
        {
            Console.Title = "FizzBuzzTest";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Start();
        }

        static void Start()
        {
            ResetStats();
            Console.WriteLine("Enter a Number: ");
            _Zahl = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Number: {0}", _Zahl.ToString());
            for (int i = 1; i <= _Zahl; i++)
            {
                checkNumber(i);
            }
            Start();
        }
        static void checkNumber(int Number)
        {
            if (Number % 3 == 0)
            {
                if (Number % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    _FizzBuzz++;
                }
                else
                {
                    Console.WriteLine("Fizz");
                    _Fizz++;
                }
            }
            else if (Number % 5 == 0)
            {
                if (Number % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    _FizzBuzz++;
                }
                else
                {
                    Console.WriteLine("Buzz");
                    _Buzz++;
                }
            }
            else
            {
                //Console.WriteLine("Unknown ERROR");
            }
            UpdateTitle(Number);
        }

        static void UpdateTitle(int count)
        {
            Console.Title = "FizzBuzzTest | [" + count  +"/" + _Zahl + "] | Fizz: "+ _Fizz + " Buzz: " + _Buzz + " FizzBuzz: " + _FizzBuzz + " ";
        }

        static void ResetStats()
        {
            _Fizz = 0;
            _Buzz = 0;
            _FizzBuzz = 0;
        }
    }
}
