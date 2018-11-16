using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assembly1;



namespace _16Nov2018Modifiers
{
    
    class Program
    {
        static void Main(string[] args)
        {
          Doctor doctor = new Doctor();
            doctor.Name = "ABC";
            doctor.PrintDoctorDetails();
            Console.ReadLine();


            
        }
    }
}
