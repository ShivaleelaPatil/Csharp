/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeyword
{
   class Institution
    {
       
         string Adress = "Hyderabad";

        public void PrintStudentDetails()
        {
            Student s1 = new Student();
            Console.WriteLine("Welcome to Vidyagiri Institution:" + Adress);


            Console.WriteLine("student name:" + s1.Name + "\n" + "student Id is:" + s1.id); 
            Console.ReadLine();
        }
        public static int CalcTotalAmount()
        {
            Student s = new Student();
            Student.Scholarship = 10000;


            s.PrizeAmount = 1000;
            s.TotalAmount = s.PrizeAmount + Student.Scholarship;//since Scholarship is static no need to use reference of class
            return s.TotalAmount;
        }





    }
   public  class Student
    {
        static public int Scholarship;
        public int id;
        public string Name;
        public int TotalAmount;
        public int PrizeAmount;
       

    }
    class Program
    {
        static void Main(string[] args)
        {
           
            Institution I1 = new Institution();
            Student student = new Student();
            student.Name = "Aradhya";

            I1.PrintStudentDetails();
            Institution.CalcTotalAmount();
            Console.WriteLine("Total amount is:" + student.TotalAmount);
           
            
            
            
            Console.ReadLine();

        }
    }
}*/


















