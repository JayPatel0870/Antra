using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    internal class VClass
    {
        public virtual void Display()
        {
            Console.WriteLine("Inside Base Class");
        }
    }
    class VDerived : VClass
    {
        public override void Display()
        {
            Console.WriteLine("Inside Derived Class");
        }
    }
}
