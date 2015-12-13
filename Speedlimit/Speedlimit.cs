using System;

namespace Speedlimit
{
    /// <summary>
    /// Speed Limit - Not Working
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
                var totalDistance = 0;
                var output = 0;

                for (var i = 0; i < caseInput; i++)
                {
                    var speed = int.Parse(Console.ReadLine());
                    var newDistance = int.Parse(Console.ReadLine());

                    output = speed * (newDistance - totalDistance) + output;

                    totalDistance = newDistance;
                }

                Console.WriteLine(output + " miles");

                caseInput = int.Parse(Console.ReadLine());
            }
        }
    }
}
