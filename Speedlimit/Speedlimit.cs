using System;

namespace Speedlimit
{
    /// <summary>
    /// Speed Limit - Working
    /// 
    /// Bill and Ted are taking a road trip. But the odometer in their car is broken, so they don’t know how many miles 
    /// they have driven. Fortunately, Bill has a working stopwatch, so they can record their speed and the total time 
    /// they have driven. Unfortunately, their record keeping strategy is a little odd, so they need help computing the 
    /// total distance driven. You are to write a program to do this computation.
    /// </summary>

    internal class Speedlimit
    {
        private static void Main(string[] args)
        {
            var caseInput = int.Parse(Console.ReadLine());

            while (caseInput > 0)
            {
                var totalTimeTraveled = 0;
                var result = 0;

                for (var i = 0; i < caseInput; i++)
                {
                    var newEntry = Console.ReadLine().Split(' ');
                    var speed = int.Parse(newEntry[0]);
                    var hours = int.Parse(newEntry[1]);

                    int timeTraveled = hours - totalTimeTraveled;

                    result += speed * timeTraveled;

                    totalTimeTraveled = hours;
                }

                Console.WriteLine(result + " miles");

                caseInput = int.Parse(Console.ReadLine());
            }
        }
    }
}
