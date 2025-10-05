namespace Static_constructor
{

    public class Static_constructor
    {
        public static int staticValue;

        static Static_constructor() 
        { 
        staticValue = 1000;
         Console.WriteLine("static constructor called");
        }

        public Static_constructor()
        {
            Console.WriteLine("Instance constructor called ");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Static_constructor.staticValue);
            Static_constructor obj = new Static_constructor();

        }
    }
}
