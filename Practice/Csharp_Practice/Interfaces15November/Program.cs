/*using System;

namespace Interfaces15November
{
    interface  IHuman
    {
        void PrintHumanDetails();
         
    }
    interface IPerson:IHuman
    {
        void PrintPersonDetails();
    }
   public  class Doctor:IPerson,IHuman//chain of inheritance
    {
        public int Sum=0;
      public void PrintHumanDetails()
        {
            Console.WriteLine("Human:Human Details");
        }
        public void PrintPersonDetails()
        {
            Console.WriteLine("Person:Person Details");
        }
        public void Calc()
        {
            Sum = 10 + 5;
           
            Console.WriteLine("sum is:" + Sum);
            Sum= Convert.ToInt32(Console.ReadLine());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IHuman human = new Doctor();//creating IHuman reference to refer the child Class object
            human.PrintHumanDetails();
            IPerson person = new Doctor();
            person.PrintPersonDetails();
          
            Doctor doctor = new Doctor();
            doctor.Calc();
            Console.ReadLine();


        }
    }
}
