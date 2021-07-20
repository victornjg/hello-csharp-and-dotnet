using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercise 1
            //var count = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //        count++;
            //    }
            //}
            //Console.WriteLine("count: " + count);

            // exercise 2
            //var sum = 0;
            //var keepAsking = true;
            //while (keepAsking)
            //{
            //    Console.Write("enter a number: ");
            //    var typedVal = Console.ReadLine();
            //    if (typedVal == "ok")
            //    {
            //        keepAsking = false;
            //    } 
            //    else
            //    {
            //        sum += int.Parse(typedVal);
            //        Console.WriteLine("sum: " + sum);
            //    }
            //}

            // exercise 3
            //Console.Write("enter a number: ");
            //var typedVal = Console.ReadLine();
            //var val = int.Parse(typedVal);
            //var res = val;
            //for (int i = val - 1; i > 1; i--)
            //{
            //    res = res * i;
            //}
            //Console.Write("{0}! = {1}", val, res);

            // exercise 4
            var random = new Random();
            var secretNumber = random.Next(1, 10);
            //Console.WriteLine("Secret number: " + secretNumber);
            Console.WriteLine("You have 4 chances to guess the number.");
            Console.Write("First try: ");
            var wasNumberGuessed = false;
            var i = 0;
            while (i < 4 && !wasNumberGuessed)
            {
                var typedVal = Console.ReadLine();
                var val = int.Parse(typedVal);
                if (val == secretNumber)
                {
                    Console.WriteLine("You won.");
                    wasNumberGuessed = true;
                } 
                else
                {
                    if (i < 3)
                    {
                        Console.Write("Try again: ");
                    }
                    else
                    {
                        Console.WriteLine("You lost.");
                    }
                }
                i++;
            }
        }
    }
}
