//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _17nov2018
//{
//    public class Doctor
//    {
//        int id;

//        public void DoctorDetails()
//        {
//            Console.WriteLine("Enter Doctor id:");
            
//            try
//            {
               
//                 id = Convert.ToInt32(Console.ReadLine());
//                if (id < 0)
//                {
//                    throw new ArgumentOutOfRangeException("id cannot be null");
//                }

//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Exception: {0}" , e.Message);
               

//            }

//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Doctor doctor = new Doctor();
//            doctor.DoctorDetails();
//            Console.ReadLine();
//        }
//    }
//}
//--------------------------------------------------next------------------------------------------------------------------------------------------



//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _17nov2018
//{


//    class Division
//{
//    int result;

//    Division()
//    {
//        result = 0;
//    }
//    public void division(int num1, int num2)
//    {
//        try
//        {
//            result = num1 / num2;
//        }
//        catch (DivideByZeroException e)
//        {
//            Console.WriteLine("Exception caught: {0}", e);
//        }
//            finally
//            {
//                Console.WriteLine("Result: {0}", result);//If we remove finally block result which is initialized to Zero will not be printed
//            }
//        }
//        static void Main(string[] args)
//    {
//            Division d = new Division();
//        d.division(25, 0);
//        Console.ReadLine();
//    }
//}
//}


    //----------------------Next-----------------------------------------------------------------------------------------------------------------



