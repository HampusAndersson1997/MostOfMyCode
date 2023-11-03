using System;

namespace Exercise_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double LightSpeedKmPerSec = 299792.458; // Light speed in km/s
            const double SunDistanceKm = 149598023; // Average distance from the Sun in km
            const double SecondsPerMinute = 60;

            double timeInSeconds = SunDistanceKm / LightSpeedKmPerSec;
            double timeInMinutes = timeInSeconds / SecondsPerMinute;

            Console.WriteLine($"It would take approximately {timeInMinutes} minutes for us to realize if the sun went out.");
        }
    }
}