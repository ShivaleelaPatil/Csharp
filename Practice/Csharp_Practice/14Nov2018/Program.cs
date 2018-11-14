using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        int _ID;
        string _Name;
        int _Marks;
        public void StudentDetails(string name, int id, int marks)
        {

            Console.WriteLine(" Student Details");
            Console.WriteLine("Name\n" + name + "\n" + "ID\n" + id + "Marks\n" + marks);
            Console.ReadLine();

        }
        public string Names
        {
            get
            {
                return _Name;
            }
            set
            {
                this._Name = value;
            }
        }
        public int Number
        {
            get
            {
                return _ID;


            }

            set
            {
                this._ID = value;
            }
        }
        public int Number1
        {
            get
            {
                return _Marks;


            }

            set
            {
                this._Marks = value;
            }
        }

    }
    class Institution
    {
        string _Course;
        int _Cost;
        Student student = new Student();
        public void InstitutionDetails(string s, int val)
        {

            Console.WriteLine("Institute Name: " + s + "Fees: " + val);
            Console.ReadLine();
            student.StudentDetails("Shiv", 1, 20);


        }
        public string Number4
        {
            get
            {
                return _Course;
            }
            set
            {
                this._Course = value;
            }
        }
        public int Number3
        {
            get
            {
                return _Cost;
            }
            set
            {
                this._Cost = value;
            }
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            Institution I = new Institution();
            I.InstitutionDetails("ABC", 12000);




        }
    }
}


//---------------------------------------------------------Next-------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{ 
public class Person
{
    string Name;
    int ID;
    public virtual void GetDetails()
    {
        Console.WriteLine("Person Details:");

    }
    public virtual void PrintDetails()
    {
        Console.WriteLine("Person Info:");
    }
}
class Doctor:Person
{
    string Qualification;
    string Specilizartion;
    public override void GetDetails()
    {
        Console.WriteLine("Doctor Details:");
    }
    public new  void PrintDetails()
    {
        Console.WriteLine("Doctor Info:");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.GetDetails();
        p.PrintDetails();
        Doctor d = new Doctor();
        d.GetDetails();
        d.PrintDetails();
        Person p2 = new Doctor();
        p2.GetDetails();
        p2.PrintDetails();

        Console.ReadLine();
    }
}
}

    //------------------------------------------Next-----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{ 
    public class Person
    {
        string Name;
        int ID;
        public virtual void GetDetails()
        {
            Console.WriteLine("Person Details:");

        }
        public virtual void PrintDetails()
        {
            Console.WriteLine("Person Info:");
        }
    }
    class Doctor:Person
    {
        string Qualification;
        string Specilizartion;
        public override void GetDetails()
        {
            Console.WriteLine("Doctor Details:");
        }
        public new  void PrintDetails()
        {
            Console.WriteLine("Doctor Info:");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.GetDetails();
            p.PrintDetails();
            Doctor d = new Doctor();
            d.GetDetails();
            d.PrintDetails();
            Person p2 = new Doctor();
            p2.GetDetails();
            p2.PrintDetails();
            
            Console.ReadLine();
        }
    }
}

