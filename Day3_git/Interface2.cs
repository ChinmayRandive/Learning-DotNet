namespace Day3_Interface

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface");


            class1 obj = new class1();
            obj.open();
            obj.close();




            Ifilefunction oifile;
                {
                oifile = obj;
                oifile.open();
                oifile.delete();
                }

            Ifunction oi;
            oi = obj;
            oi.delete();


            ((Ifilefunction)obj).close();
            (obj as Ifilefunction).delete();


        }
    }

    public interface Ifunction 
    {
        void insert ();
        void update ();
        void delete ();
        }


    public interface Ifilefunction
    {
        void open ();
        void close ();
        void delete();
    }
    public class class1 : Ifunction , Ifilefunction  // to generate code just chick on i function it will automatically generate all code.
    {
        public void close()
        {

            Console.WriteLine("Ifilefunction close");
        }

        public void delete()
        {
            Console.WriteLine("Ifunction delete");
        }

        public void insert()
        {
            Console.WriteLine("Ifunction insert");
        }

        public void open()
        {
            Console.WriteLine("Ifilefunction open");
        }

        public void update()
        {
            Console.WriteLine("Ifunction update");
        }
    }

    


}

