using System;
using System.Linq;

namespace AdvancedTopics
{
    class Program
    {
        static void main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers = { 5, 4, 3, 9, 1, 8, 6, 7, 2, 0 };
            var lownum = from num in numbers
                         where num < 5
                         select num;
            Console.WriteLine(" number < 5:");
            foreach (var x in lownum)
            {
                Console.WriteLine(x);
            }

        }
    }
    class Program2
    {
        public static void main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] numbers = { 5, 4, 3, 9, 1, 8, 6, 7, 2, 0 };
            string[] strings = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var lownum = from num in numbers
                         select strings[num];

            Console.WriteLine(" number of strings");
            foreach (var s in lownum)
            {
                Console.WriteLine(s);
            }

        }

    }
    class TakeElements
    {
        public static void main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 9, 7, 6, 2, 1 };
            var first3numbers = numbers.Take(3);
            Console.WriteLine("print first 3 numbers");
            foreach (var n in first3numbers)
            {
                Console.WriteLine(n);
            }
        }
    }
    class TakeFirstElements
    {
        public static void main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 6, 7, 8, 9, 2, 3 };
            var firstnumberslessthan6 = numbers.TakeWhile(n => n < 6);
            Console.WriteLine("numbers less than 6");
            foreach (var n in firstnumberslessthan6)
            {
                Console.WriteLine(n);
            }
        }
    }
    class CompareSequences
    {
        public static void Main(string[] args)
        {
            var wordsA = new string[] { "cherry", "apple", "blueberry" };
            var wordsB = new string[] { "cherry", "apple", "blueberry" };
            bool match = wordsA.SequenceEqual(wordsB);
            Console.WriteLine("the sequence match: {match}");
        }
    }
    class program3
    {
        static void main(string[] args)
        {
            int[] numbers = { 5, 4, 3, 1, 9, 8, 7, 6, 2 };
            int i = 0;
            var q = from n in numbers
                    select ++i;
            foreach(var v in q)
            {
                Console.WriteLine("v = {v},i = {i}");
            }

        }
    }
}
   
