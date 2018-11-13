/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3rdNOV10
{
    class Program
    {
        static string[] CourseName = new string[] { "Java", "Testing", "DataScience" };
         static int[] CourseCost = new int[3]{15000,10000,23000};
        static string[] StudentName = new string[10];
        static int[] Id = new int[6];
        static string[] Name = new string[6];
        static int[] duration = new int[] { 6, 3, 7 };
        static string[] Cname=new string[10];
        static string[] CoName = new string[6];
        static int[] Cost = new int[6];
         static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Welcome to Vidyagiri Institute");
                int Choice;
                Console.WriteLine("Enter Your choice");
                Console.WriteLine("Press 1 to View List of courses in Institute");
                Console.WriteLine("Press 2 to View List of students who enqired for Course");

                Console.WriteLine("press 3 to View Students who joined Institute");
                Console.WriteLine("press 4 to Exit");
                Choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Courses in institute Are:");
                switch (Choice)
                {
                    case 1:
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(CourseName[i]);
                        }

                        Console.WriteLine("Cost of Courses In Institute are:");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(CourseCost[i]);

                        }
                        Console.WriteLine("Duration of the course is:");
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(duration[i]);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter the Names of the students who enquired for Courses");
                        for (int i = 0; i < 6; i++)
                        {
                            Name[i] = Console.ReadLine();
                        }
                        Console.WriteLine("Enter the CourseName Enqired by each student");
                        for (int i = 0; i < 6; i++)
                        {
                            Cname[i] = Console.ReadLine();
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the Names of the Students who joined Institute");
                        for (int i = 0; i < 6; i++)
                        {
                            StudentName[i] = Console.ReadLine();
                        }
                        Console.WriteLine("Enter the id  of the Students who joined Institute");
                        for (int i = 0; i < 6; i++)
                        {
                            Id[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        Console.WriteLine("Enter the Name of the course joined by student");
                        for (int i = 0; i < 6; i++)
                        {
                            Cname[i] = Console.ReadLine();
                        }

                        for (int i = 0; i < 6; i++)
                        {
                            switch (Cname[i])
                            {
                                case "Java":

                                    Cost[i] = CourseCost[0];
                                    CoName[i] = CourseName[0];

                                    break;

                                case "Testing":

                                    Cost[i] = CourseCost[1];
                                    CoName[i] = CourseName[1];


                                    break;

                                case "DataScience":
                                    Cost[i] = CourseCost[2];
                                    CoName[i] = CourseName[2];

                                    break;
                            }
                        }
                            Console.WriteLine("StuentName".PadRight(20)+"ID".PadRight(20)+"CourseName".PadRight(20)+"Cost");
                            for (int i = 0; i < 6; i++)
                            {
                                
                                Console.WriteLine(StudentName[i]+"\t\t"+ Id[i]+"\t\t" + CoName[i] +"\t\t"+ Cost[i]);
                            }
                            Console.ReadLine();

                        
                        break;
                    default:break;
                }
                
                }
            }
        }
    }
    */