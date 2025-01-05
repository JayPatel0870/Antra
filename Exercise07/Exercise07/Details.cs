using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    internal class Details
    {
        private string name {  get; set; }
        private int age { get; set; }

        public void Display(string name, int age)
        {
            Console.WriteLine("Name: "+name);
            Console.WriteLine("age: "+age);
        }
    }
}
