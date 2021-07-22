using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        // backing stores for properties
        private string _name;
        private int _sin;

        // auto-implemented properties
        public int Age { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string Name
        {
            // unchangeable by client code
            get { return _name; }
        }
        public int Sin // using lambdas
        {
            get => _sin;
            set => _sin = value;
        }

        // constructor
        public Person(string name, int sin)
        {
            _name = name;
            _sin = sin;
        }

        // print method
        public void identify()
        {
            Console.WriteLine("{0} is a {1}-year old person who is " +
                              "{2} cm tall and weighs {3} kg. Sin is {4}"
                             , Name, Age, Height, Weight, Sin);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("James", 123456789);
            p.Age = 46;
            p.Height = 175.37;
            p.Weight = 90.72;
            p.identify();
            Console.ReadKey();
        }
    }
}
