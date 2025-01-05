using System.Data;

namespace Exercise07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Inheritance 
            //DerivedClass dc = new DerivedClass();
            //dc.DerivedFunction();
            //dc.BaseFunction();

            ////Abstraction
            //ADerivedClass adc = new ADerivedClass();
            //adc.Greeting();

            //// Encapsulate
            //EncapsulateClass ec = new EncapsulateClass();
            //ec.Display("Jay", 24);

            ////Polymorphysm
            //PDerivedClass pdc = new PDerivedClass();
            //Console.WriteLine(pdc.Addition(1, 2));


            //Student student = new Student();
            //student.Behavior();

            //Instuctor instuctor = new Instuctor();
            //instuctor.Behavior();   

            //Details d = new Details();
            //d.Display("Jay", 20);

            // Virtual 
            VClass vc = new VClass();
            vc.Display();

            VDerived vd = new VDerived();
            vd.Display();



        }
    }

    // Encapsulation
    class EncapsulateClass
    {
        private string name { get; set; }
        private int age { get; set; }

        public void Display(string name, int age)
        {
            Console.WriteLine($"Hello my name is {name} and I am {age} years old");
        }
            
    }

    // Inheritance 
    abstract class BaseClass
    {
        public void BaseFunction()
        {
            Console.WriteLine("In the Base Class");
        }
       
    }

    class DerivedClass:BaseClass 
    { 
        public void DerivedFunction()
        {
            Console.WriteLine("In the Derived Class");
        } 
    }

    // Abstraction
    abstract class ABaseClass
    {
        abstract public void Greeting(); 
    }

    class ADerivedClass : ABaseClass
    {
        public override void Greeting()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class PBaseClass
    {
        //method overloading
        public int Addition(int a, int b)
        {
            Console.WriteLine("Inside Base Class");
            return a + b;
        }

        public double Addition(double a, double b)
        {
            Console.WriteLine("Inside Base Class");
            return a + b;
        }
    }

    class PDerivedClass
    {
        //method Overriding
        public int Addition(int a, int b)
        {
            Console.WriteLine("Inside Derived Class");
            return a - b;
        }
    }


}
