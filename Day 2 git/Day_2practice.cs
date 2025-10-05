
using System;
namespace Day_2Practice
{

    public class Practice_Constructor
    {
        public int prop1;
        public int prop2;


        public Practice_Constructor() // created default constructor
        {
            prop1 = 1;
            prop2 = 2;
            Console.WriteLine("Default constructor Called");
        }

        public Practice_Constructor(int p1, int p2)
        {
            this.prop1 = p1;
            this.prop2 = p2;

            Console.WriteLine("Parameterised constructor called");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor practice!");
            Practice_Constructor obj = new Practice_Constructor();   // created object for default constructor
            Console.WriteLine(obj.prop1);
            Console.WriteLine(obj.prop2);

            Practice_Constructor obj1 = new Practice_Constructor(10, 20); // created object for parameterised constructor
            Console.WriteLine(obj1.prop1);
            Console.WriteLine(obj1.prop2);
        }
    }
}


