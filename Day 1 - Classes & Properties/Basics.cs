namespace Practice_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 obj = new class1();
            obj.I = 102;
            Console.WriteLine(obj.I);

        }

       public class class1
        {
            private int i;
            public int I
            {
                set
                {
                    if (value <= 100)
                        i = value;
                    else
                        Console.WriteLine("Invalid value");
                }
                get { 
                    return i; 
                }
            }
        }
    }
}


