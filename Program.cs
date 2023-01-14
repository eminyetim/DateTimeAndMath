using System;

namespace DateTimeAndMath
{
    class Program
    {
        public static void Main(string[] args)
        {
           System.Console.WriteLine(DateTime.Now);
           System.Console.WriteLine(DateTime.Now.Date);
           System.Console.WriteLine(DateTime.Now.Day);
           System.Console.WriteLine(DateTime.Now.Month);
           System.Console.WriteLine(DateTime.Now.Year);
           System.Console.WriteLine(DateTime.Now.Hour);
           System.Console.WriteLine(DateTime.Now.Minute);
           System.Console.WriteLine(DateTime.Now.Second);


           System.Console.WriteLine(DateTime.Now.DayOfWeek);
           System.Console.WriteLine(DateTime.Now.DayOfYear);

           System.Console.WriteLine(DateTime.Now.ToLongDateString());
           System.Console.WriteLine(DateTime.Now.ToShortDateString());

           System.Console.WriteLine(DateTime.Now.ToLongTimeString());
           System.Console.WriteLine(DateTime.Now.ToShortTimeString());

           System.Console.WriteLine(DateTime.Now.AddDays(2));
           System.Console.WriteLine(DateTime.Now.AddHours(2));
           System.Console.WriteLine(DateTime.Now.AddSeconds(2));
           System.Console.WriteLine(DateTime.Now.AddMonths(2));
           System.Console.WriteLine(DateTime.Now.AddYears(2));
           System.Console.WriteLine(DateTime.Now.AddMilliseconds(8));


            System.Console.WriteLine(DateTime.Now.ToString("dd"));
            System.Console.WriteLine(DateTime.Now.ToString("ddd"));
            System.Console.WriteLine(DateTime.Now.ToString("dddd"));

            System.Console.WriteLine(DateTime.Now.ToString("MM"));
            System.Console.WriteLine(DateTime.Now.ToString("MMM"));
            System.Console.WriteLine(DateTime.Now.ToString("MMMM"));

            System.Console.WriteLine(DateTime.Now.ToString("yy"));
            System.Console.WriteLine(DateTime.Now.ToString("yyy"));
            System.Console.WriteLine(DateTime.Now.ToString("yyyy"));

            //math

            System.Console.WriteLine(Math.Abs(-25));
            System.Console.WriteLine(Math.Sin(0));
            System.Console.WriteLine(Math.Cos(0));
            System.Console.WriteLine(Math.Tan(45));

            System.Console.WriteLine(Math.Ceiling(22.3));
            System.Console.WriteLine(Math.Round(22.50));
            System.Console.WriteLine(Math.Floor(22.7));

            System.Console.WriteLine(Math.Max(2,5));
            System.Console.WriteLine(Math.Min(2,5));

            System.Console.WriteLine(Math.Pow(3,2));
            System.Console.WriteLine(Math.Sqrt(144));
            System.Console.WriteLine(Math.Log(1));
            System.Console.WriteLine(Math.Exp(3));
            System.Console.WriteLine(Math.Log10(100));



        }
    }
}