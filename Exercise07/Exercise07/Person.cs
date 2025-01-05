using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{

    
    abstract class Person
    {
        abstract public void Behavior();
    }

    class Student:Person
    {
        public override void Behavior()
        {
            Console.WriteLine("Student Studies...");
        }
    }

    class Instuctor:Person
    {
        public override void Behavior()
        {
            Console.WriteLine("Instructor Teaches...");
        }
    }
}
