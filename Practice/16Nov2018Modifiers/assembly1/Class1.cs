using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assembly1
{

    public class Person //by default class will be internal in  class libralies
    {
        internal int id;//By default this field will be private
        public string Name;//since it is public it is accessible within the class and outside the class also 
        protected int age;//since it is protected it is accessible within the class and derived class
    }
    public  class Doctor : Person
    {
      
        int Salary;
        public string Specialization;
        public void PrintDoctorDetails()
        {
            id = 2;
           
            age = 10;//we can access the age property because Doctor class inherit the Person class and 
            Salary = 10000;
            Specialization = "Cardiologist";
            Console.WriteLine("Doctor Info from Library 1:");
            Console.WriteLine("Name:" + Name+"\n"+"ID:" +id+"\n"+"salary:" +Salary+"\n"+"Specialization:" +Specialization);
            Console.ReadLine();
        }
    }
    public class Patient:Person
    {
        string Problem = "Fever";
        public void PrintPatientDetails()
        {
            Name = "Kalyan";
            age = 22;
            id = 3;




        }
    }
   

}
