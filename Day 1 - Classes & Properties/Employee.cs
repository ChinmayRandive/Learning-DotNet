namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Employee obj = new Employee();

            obj.Name = "Chinmay Randive";
            obj.EmpNo = 101;
            obj.Basic = 11000.00M;
            obj.DeptNo = 5;

            Console.WriteLine("Employee Details");
            Console.WriteLine("Name "+ obj.Name);
            Console.WriteLine("EmpNo"+ obj.EmpNo);
            Console.WriteLine("Basic"+ obj.Basic);
            Console.WriteLine("DeptNo" + obj.DeptNo);

            Console.WriteLine(obj.GetNetSalary());
        }

        public class Employee
        {
            private string name;
            private int empNo;
            
            private short deptNo;


            public string Name
            {
                set
                {
                    if (value != null)
                        name = value;
                    else
                        Console.WriteLine("No Blank Names Are Alloud ");
                }

                get
                {
                    return name;
                }
            }
                 public int EmpNo
            {
                set
                {
                    if (value > 0)
                        empNo = value;
                    else
                        Console.WriteLine("Must be Greater than 0 ");
                }

                get
                {
                    return empNo;
                }
            }
            private decimal basic;
            public decimal Basic
            {
                set
                {
                    if (value >= 10000.00M || value <= 5000.00M)
                        basic = value;
                    else
                        Console.WriteLine("Must be between some range ");
                }
                get
                {
                   return basic;
                }
            }
                 public short DeptNo
            {
                set
                {
                    if (value > 0)
                        deptNo = value;
                    else
                        Console.WriteLine("Must be between some range ");
                }

                get
                {
                    return deptNo;
                }
            }

                public decimal GetNetSalary()
            {
                decimal one = basic * 0.20M;
                //decimal two = basic * 0.10M;
                //decimal three = basic * 0.8M;
                //return  one + two  three;
                return one;
            }
            }


            
        }
    }
