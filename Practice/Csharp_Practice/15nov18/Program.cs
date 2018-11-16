/*using System;

namespace _15nov18
{
    class Student
    {
        int[] _ID=new int [2];
        string[] _Name=new string[2];
        int[] _Marks=new int[2];
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
                for (int i = 0; i < 2; i++)
                {
                    return _Name[i];
                }
            {

            set{
                 for (int i = 0; i < 2; i++)
                {
                    this._Name[i] = value;
                }
            }
        }
        public int Number
        {
            get
            {
                for (int i = 0; i < 2; i++)
                {
                    return _ID[i];
                }

            }

            set
            {

                for (int i = 0; i < 2; i++)
                {
                    this._ID[i] = value;
                }
            }
        }
        public int Number1
        {
            get
            {
                return _Marks[];


            }

            set
            {
                this._Marks[] = value;
            }
        }

    }
    class Institution
    {
        string _Course;
        int _Cost;
        Student[] student = new Student[2];
        public void InstitutionDetails(string[] s, int[] val)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Institute Name: " + s[i] + "Fees: " + val[i]);
                Console.ReadLine();
            }
            student[0].StudentDetails("Shiv", 1, 20);
            student[1].StudentDetails("ram", 2, 25);
         


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
            for (int i = 0; i < 2; i++)
            {
                I[i].InstitutionDetails(string[] s,int[] val);
                
            }

          
        }
    }
}