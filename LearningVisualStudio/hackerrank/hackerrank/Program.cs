using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank
{
    class Day00helloworld
    {
        static void Main(string[] args)
        {
            int i01 = 4;
            string s01 = "HackerRank", inputstring;
            Double d01 = 0.4;
            inputstring = Console.ReadLine();
            Console.WriteLine("Hello World");
            Console.WriteLine(inputstring);
            Console.ReadKey();

            Day01DataTypes DT = new Day01DataTypes();
            DT.Day01DataTypes();
        }
    }

    class Day01DataTypes 
    {
        int i, SumofIntegers;
        Double d, SumofDouble;
        String s, inputstring, CompleteString;
        Console.WriteLine("Please enter the Integer");
        i = Console.ReadLine();
        SumofIntegers = (i01+i);
        Console.WriteLine(SumofIntegers);
        Console.WriteLine("Please enter the double number");
        d = Console.ReadLine();
        SumofDouble = (d+d01);
        Console.WriteLine("Please enter the String");
        inputstring = Console.ReadLine();
        CompleteString = string.Concat(S01, inputstring);
    }
}
