using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace Exercise03
{
    internal class Greetings
    {
        public void greets()
        {
            DateTime currentTime = DateTime.Now;

            if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                Console.WriteLine("Good Morning");
            }

            if (currentTime.Hour >= 12 && currentTime.Hour < 18)
            {
                Console.WriteLine("Good Afternoon");
            }

            if (currentTime.Hour >= 18 && currentTime.Hour < 22)
            {
                Console.WriteLine("Good Evening");
            }

            if (currentTime.Hour >= 22 || currentTime.Hour < 6)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
