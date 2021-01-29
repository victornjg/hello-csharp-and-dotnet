using System;

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
            //float f = 20.95;
            float f = 20.95f;

            // LET THE C# COMPILER DETECT THE DATA TYPE FOR EACH VARIABLE
            var x = 255;
            var y = 20.95f;

            // DIFFERENT QUOTATION MARKS FOR EACH TYPE
            char letter = 'a';
            string name = "Victor";

            Console.WriteLine(number);
            Console.WriteLine(f);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(letter);
            Console.WriteLine(name);

            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
        }
    }
}
