using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // DATE TIME
            //var dateTime = new DateTime(2021, 7, 20);
            //var now = DateTime.Now;
            //var today = DateTime.Today;

            //Console.WriteLine(now.Hour);
            //Console.WriteLine(now.Minute);

            //var tomorrow = now.AddDays(1);
            //var yesterday = now.AddDays(-1);

            //Console.WriteLine("Tomorrow: " + tomorrow);
            //Console.WriteLine("Yesterday: " + yesterday);

            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortTimeString());
            //Console.WriteLine(now.ToString());
            //Console.WriteLine(now);
            //Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            // TIME SPAN
            //var timeSpan = new TimeSpan(1, 2, 3);

            //var timeSpan1 = new TimeSpan(1, 0, 0);
            //var timeSpan2 = TimeSpan.FromHours(1);

            //var start = DateTime.Now;
            //var end = DateTime.Now.AddMinutes(2);
            //var duration = end - start;
            //Console.WriteLine("Duration: " + duration);

            //Console.WriteLine("Minutes: " + timeSpan.Minutes);
            //Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            //Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //Console.WriteLine("ToString: " + timeSpan.ToString());
            //Console.WriteLine("ToString: " + timeSpan);

            //Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

            // EXERCISE: Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
            // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display
            // "Invalid Time". If the user doesn't provide any values, consider it as invalid time.
            Console.Write("What time is it? ");
            var timeTyped = Console.ReadLine();
            TimeSpan timeParsed;

            if (TimeSpan.TryParse(timeTyped, out timeParsed))
            {
                Console.WriteLine(timeParsed);
                Console.WriteLine("Ok");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
