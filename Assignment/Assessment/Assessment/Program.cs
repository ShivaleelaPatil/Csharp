using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
  public  class Employee
    {
        public int Salary;
        public int Bonus=1000;

    }
    public class SalesMan:Employee
    {
        public int TotalSalary;
        
        public  SalesMan()
        {
            
            TotalSalary = Salary + ((10 / 100) * Salary);
        }

    }
    public class Manager:Employee
    {
      public  int ManagerSalary;
        public Manager()
        {
            ManagerSalary = Salary + ((10 / 100) * Salary);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {

            SalesMan salesMan = new SalesMan();
            salesMan.Salary = 10000;
            Manager manager = new Manager();
            manager.Salary = 10000;
            Console.WriteLine("salesman Salary" + salesMan.TotalSalary);


        }
    }
}

