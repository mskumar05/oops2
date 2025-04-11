
    namespace oops2
    {
        internal class Employee
        {
            ulong eno;
            string ename;
            double esal;
            internal void SetEmp()
            {
                eno = 123;
                ename = "Saikumar";
                esal = 5000;
            }
            internal void DisplayEmp()
            {
                Console.WriteLine("Emp no is:" + eno);
                Console.WriteLine("Emp Name is:" + ename);
                Console.WriteLine("Emp Salary is:" + esal);
                Console.ReadLine();
            }
            class Program
            {
                static void Main(string[] args)
                {
                    Employee emp1 = new Employee();
                    emp1.SetEmp();
                    emp1.DisplayEmp();
                    Console.ReadLine();
                }


            }
        }
    }
