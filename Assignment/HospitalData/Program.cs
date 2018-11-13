/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalData
{
    class Doctor:Patient
    {
    
       public string[] Dname = new  string[] { "arnav", "Jeevan", "Pratima" };
    public string[] Specialization = new string[] { "Neurologist", "ENT", "General" };

        public void DocDetails()
        {
            Console.WriteLine(" Welcome to Our Hosptal");
            Console.WriteLine("Please enter the doctor Details");
            Console.WriteLine("Doctor".PadRight(20) + "Specialization");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Dname[i].PadRight(20) + Specialization[i]);
            }
            Console.ReadLine();

        }

    }
    class Patient
    {
        Doctor[] d = new Doctor[3];
        int Pid;
        string Pname;
        int Page;
        string Problem;
        public int PatientCount=4;
        Diagnosis[] dg = new Diagnosis[3];
        public void PatientDetails()
        {
            Doctor[] d = new Doctor[3];
            d[3].DocDetails();

            Console.WriteLine("Please Enter The patient Details");
            Console.WriteLine("Patient_Name");
            for (int i = 0; i < 3; i++)

            {

                Pname[i] = Console.ReadLine();
            }
            Console.WriteLine("     ");
            Console.WriteLine("PAge");
            for (int i = 0; i < 3; i++)
            {
                PAge[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("     ");
            Console.WriteLine("Problem");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Problem[i]);
            }
            Console.WriteLine("Enter Your Problem");
            Console.ReadLine();



            if (Problem.Equals("Headache"))
            {
                dg[0].Treatment = "MRI";
                cost[0] = cost1[0];
                d[3].Dname[0] = "Arnav";
                d[3].Specialization[0] = "Neurologist";

            }

            else if (Problem.Equals("EarProblem"))
            {
                Treatment[1] = "EyeCheckup";
                cost[1] = cost1[1];
                d[3].Dname[1] = "Jeevan";
                d[3].Specialization[1] = "ENT";
            }
            else if (Problem.Equals("Fever"))
            {
                Treatment[2] = "BloodTest";
                cost[3] = cost1[2];
                d[3].Dname[2] = "Pratima";
                d[3].Specialization[2] = "General";
            }
            Console.WriteLine("PatientName".PadRight(20) + "Age".PadRight(20) + "Problem".PadRight(20) + "Treatment".PadRight(20) + "Cost");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Pname[i].PadRight(20) + PAge[i] + "\t\t\t" + Problem[i].PadRight(20) + Treatment[i].PadRight(20) + cost1[i]);
            }
            Console.ReadLine();
        }
    }


}
   public  class Diagnosis
    {
        string Treatment;
        int cost;
    Patient Patient = new Patient();
    }
    class Program
    {
        
        static void Main(string[] args)
        {

        Patient p = new Patient();
        
            
                for (int i = 0; i < 4; i++)
                {
                    p[i] = new Patient();
                    p[i].PatientDetails();
                }
            }
            
        }
    }
}
*/