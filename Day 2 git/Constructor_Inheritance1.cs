using System;
namespace Constructor_Inheritance1
{

    public class Baseclass
    {
        public int i;

        public Baseclass()
        {
            i = 100;
            Console.WriteLine("Base class non paramaterised constructor called"+i);
            
        }

        public Baseclass(int i)
        {
            this.i = i;
            Console.WriteLine("Base class paramaterised constructor called"+i);
        }


    }


    public class Derivedclass : Baseclass
    {
        public int j;

        public Derivedclass()
        {
            Console.WriteLine("Derivedclass non paramaterised constructor called" + j);
            j = 200;
        }

        public Derivedclass(int i, int j) : base(i)
        {
            this.j = j;
            Console.WriteLine("Derivedclass paramaterised constructor called" + j);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Derivedclass o2 = new Derivedclass(30, 40);
        }
    }
}
