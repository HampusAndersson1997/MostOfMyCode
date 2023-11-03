using System;
namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lightSpeedInKmPerS = 299792.458;
            double theSunsAverageDistanceInKm = 149598023;
            double secondsPerMinute = 60;

            double timeInSecondsForLightToTravelFromSunToEarth = theSunsAverageDistanceInKm / lightSpeedInKmPerS;
            double timeInMinutesForLightToTravelFromSunToEarth = timeInSecondsForLightToTravelFromSunToEarth / secondsPerMinute;

            Console.WriteLine(timeInMinutesForLightToTravelFromSunToEarth);
        }
    }
}