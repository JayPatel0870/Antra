using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02UnderstandingTypes
{
    public class CenturyConversion
    {
        static public void calculate()
        {
            // Input: Number of centuries
            Console.Write("Enter the number of centuries: ");
            long centuries = long.Parse(Console.ReadLine());

            // Constants
            long yearsInCentury = 100;
            long daysInYear = 36524; // Considering leap years in the calculation
            long hoursInDay = 24;
            long minutesInHour = 60;
            long secondsInMinute = 60;
            long millisecondsInSecond = 1000;
            long microsecondsInMillisecond = 1000;
            long nanosecondsInMicrosecond = 1000;

            // Perform conversions
            long years = centuries * yearsInCentury;
            long days = years * daysInYear;
            long hours = days * hoursInDay;
            long minutes = hours * minutesInHour;
            long seconds = minutes * secondsInMinute;
            long milliseconds = seconds * millisecondsInSecond;
            long microseconds = milliseconds * microsecondsInMillisecond;
            long nanoseconds = microseconds * nanosecondsInMicrosecond;

            // Output the results
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
