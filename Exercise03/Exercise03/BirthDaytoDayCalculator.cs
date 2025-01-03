using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class BirthDaytoDayCalculator
    {
        public void birthDaytoDayCalculator(int year, int month, int day)
        {
            DateTime birthDate = new DateTime(year, month, day);
            DateTime currentDate = DateTime.Now;
            TimeSpan ageInDays = currentDate - birthDate;
            int daysLived = ageInDays.Days;

            Console.WriteLine($"The person is {daysLived} days old.");

            int daysToNextAnniversary = 10000 - (daysLived % 10000);
            DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);

            Console.WriteLine($"The next 10,000-day anniversary will be on {nextAnniversary.ToShortDateString()}.");
        }
    }
}
