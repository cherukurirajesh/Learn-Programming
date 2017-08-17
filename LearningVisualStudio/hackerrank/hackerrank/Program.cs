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
            String inputstring = Console.ReadLine();
            Console.WriteLine("Hello World");
            Console.WriteLine(inputstring);
            Console.ReadKey();
            Day01DataTypes DT = new Day01DataTypes();
            DT.DataTypesMethod();
            Console.ReadKey();
        }
    }

    class Day01DataTypes 
    {
        int i01 = 4;
        string S01 = "HackerRank", inputstringD01, CompleteString;
        Double d01 = 4.0;
        int i, SumofIntegers;
        Double d, SumofDouble;

        public void DataTypesMethod()
        {
            Console.WriteLine("Please enter the Integer");
            i = int.Parse(Console.ReadLine());
            SumofIntegers = (i01 + i);
            Console.WriteLine(SumofIntegers);
            Console.WriteLine("Please enter the double number");
            d = double.Parse(Console.ReadLine());
            SumofDouble = ((d + d01));
            //Console.WriteLine(SumofDouble);
            Console.WriteLine((d + d01).ToString("F1"));
            Console.WriteLine("Please enter the String");
            inputstringD01 = Console.ReadLine();
            CompleteString = string.Concat(S01 + " " + inputstringD01);
            Console.WriteLine(CompleteString);
        }
    }
}
