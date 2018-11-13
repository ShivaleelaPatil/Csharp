using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3NOVInstitute
{
    class Doctor
    {
        public string[] Dname = new string[] { "arnav", "Jeevan", "Pratima" };
        public string[] Specialization = new string[] { "Neurologist", "ENT", "General" };
        public Patient p = new Patient;
    }
    class Patient
    {
        Doctor d = new Doctor();
        string Pname;
        string Page;
        string Problem;

    }
    class Diagnosis : Patient
    {
        string Treatment;
        int cost;
    }
    
    

        class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
