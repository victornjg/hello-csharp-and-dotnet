using System;
using HelloWorld.Math;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // A VARIABLE SHOULD BE INITIALIZED BEFORE USAGE
            //byte number;
            byte number = 255;

            // REALS NUMBERS ARE TREATED AS DOUBLE BY DEFAULT
            var d = 20.95;
            float f = 20.95f;

            // LET THE C# COMPILER DETECT THE DATA TYPE FOR EACH VARIABLE
            var x = 255;
            var y = 20.95f;

            // DIFFERENT QUOTATION MARKS FOR EACH TYPE
            char letter = 'a';
            string name = "Victor";

            // ARRAY
            //int[] someNumbers = new int[];  WRONG
            int[] someNumbers1 = new int[] { 1, 2, 3 };
            int[] someNumbers2 = new int[3];

            Console.WriteLine(number);
            Console.WriteLine(f);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(letter);
            Console.WriteLine(name);

            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);

            // CLASSES
            //Calculator calc = new Calculator();
            //int result = calc.Add(1, 2);
            double addRes = Calculator.Add(1, 2);
            Console.WriteLine("add result -> {0}", addRes);

            double multiplyRes = Calculator.Multiply(3, 4);
            Console.WriteLine("multiply result -> {0}", multiplyRes);

            // ENUM
            var questionLevel = QuestionLevelEnum.INTERMEDIATE;
            Console.WriteLine("enum value -> {0}", (int) questionLevel);

            var questionLevelId = 3;
            Console.WriteLine("enum entry -> {0}", (QuestionLevelEnum) questionLevelId);

            var questionLevelName = "BEGINNER";
            var level = (QuestionLevelEnum) Enum.Parse(typeof(QuestionLevelEnum), questionLevelName);
            Console.WriteLine("enum entry got from parse -> {0}", level);
        }
    }
}
