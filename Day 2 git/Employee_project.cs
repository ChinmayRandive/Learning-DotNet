namespace Employee_project
{


    public class Employee
    {
        private string name;
        public static int NextEmpNo;
        private decimal basic;
        private short deptNo;
        private int empNo;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int EmpNo
        {
            get
            {
                return empNo;
            }
        }

        public decimal Basic
        {
            set
            {
             
                if (value >= 5000.00M && value <= 10000.00M)
                    basic = value;
                else
                    Console.WriteLine("Basic must be between 5000 and 10000");
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
                    Console.WriteLine("DeptNo must be greater than 0");
            }

            get
            {
                return deptNo;
            }
        }

        public decimal GetNetSalary()
        {
            decimal one = basic * 0.20M;
            return one;
        }

        public Employee(string name = "Chinmay", decimal basic = 15000, short deptNo = 101)
        {
            NextEmpNo++;
            this.name = name;
            this.basic = basic;
            this.deptNo = deptNo;
            empNo = NextEmpNo;
        }

        public void display()
        {
            Console.WriteLine("EmpNo:" + EmpNo + " ," + "name:"+ name + " ," + "basic:"+ basic + " ," + "deptNo:"+ deptNo + " ,"+ "salary:"+ GetNetSalary());
          
        }
    }


internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Employee obj1 = new Employee("Amol", 9000, 10);
            Employee obj2 = new Employee("Ravi", 8000);
            Employee obj3 = new Employee("Sneha");
            Employee obj4 = new Employee();

            obj1.display();
            obj2.display();
            obj3.display();
            obj4.display();
        }
    }
}
