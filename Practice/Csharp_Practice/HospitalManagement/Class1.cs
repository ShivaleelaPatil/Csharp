using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement
{
    
        public class Person
        {
            int id;//By default this field will be private
            public string Name;//since it is public it is accessible within the class and outside the class also 
            protected int age;//since it is protected it is accessible within the class and derived class
        }
        class Doctor : Person
        {
            int Salary;
            public string Specialization;
            public void PrintDoctorDetails()
            {
                age = 10;//we can access the age property because Doctor class inherit the Person class

            }
        }
    }

