//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _17nov2018
//{

//    [Serializable]
//    public class MyException : Exception
//    {
//        public MyException() { }
//        public MyException(string message) : base(message) { }

//    }
//    public class DoctorIdNotFoundException : Exception
//    {
//        public DoctorIdNotFoundException()
//        {
//            Console.WriteLine("Id Not found exception");
//        }
//    }

//    public class Doctor
//    {
//        int id;

//        public void DoctorDetails()
//        {
//            Console.WriteLine("Enter Doctor id:");

//            try
//            {

//                id = Convert.ToInt32(Console.ReadLine());
//                if (id < 0)
//                {
//                    throw new ArgumentOutOfRangeException("id cannot be null");
//                }

//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("Exception: {0}", e.Message);


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
//            void EnterError(Exception ex)
//            {
//                string S = @"D:\c#\pacticee\practice\Error.txt";
//                if (!File.Exists(S))
//                {
//                    File.Create(S).Dispose();
//                }
//                using (StreamWriter sw = File.AppendText(S))
//                {
//                    sw.WriteLine("=============Error Logging ===========");
//                    sw.WriteLine("===========Start============= " + DateTime.Now);
//                    sw.WriteLine("Error Message: " + ex.Message);
//                    sw.WriteLine("Stack Trace: " + ex.StackTrace);
//                    sw.WriteLine("===========End============= " + DateTime.Now);
//                }

//                }
//            }
//        }
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


//    using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _17nov2018
//{


//    public class DoctorIdNotFoundException : Exception
//    {
//        public DoctorIdNotFoundException()
//        {
//            Console.WriteLine("id should  not be negative   exception");
//        }

//    }
//    public class Doctor
//    {
//        int id;

//        public void DoctorDetails()
//        {
//            Console.WriteLine("Enter Doctor id:");

//            try
//            {

//                id = Convert.ToInt32(Console.ReadLine());
//                if (id < 0)
//                {
//                    throw new DoctorIdNotFoundException();
//                }

//            }
//            catch (DoctorIdNotFoundException e)
//            {
//                Console.WriteLine("Exception: {0}", e.Message);


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
//            DoctorIdNotFoundException e = new DoctorIdNotFoundException();

//            }
//        }
//    }
//}


//-------------------------------------------------------next------------------------------------------------------------------------------------



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _17nov2018
{


    public class DoctorIdNotFoundException : Exception
    {
        public DoctorIdNotFoundException()
        {
            Console.WriteLine("Id Not found exception");
        }
    }

    public class Doctor
    {
        int id;

        public void DoctorDetails()
        {
            Console.WriteLine("Enter Doctor id:");
            string st = @"C:\Users\shivaleela.patil\Desktop\GitHub\Csharp\Practice\Csharp_Practice\Log File.txt";

            try
            {

                id = Convert.ToInt32(Console.ReadLine());
                if (id < 0)
                {
                    throw new DoctorIdNotFoundException();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: {0}", e.Message);
                using (StreamWriter sw = File.AppendText(st))
                {
                    sw.WriteLine("Log File");
                    sw.WriteLine("Date and time-> " + DateTime.Now);
                    sw.WriteLine("Error-> " + e.Message);
                    sw.WriteLine("Stack Trace->" + e.StackTrace);
                    sw.WriteLine("end time-> " + DateTime.Now);
                }



            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                Doctor doctor = new Doctor();
                doctor.DoctorDetails();
                Console.ReadLine();






            }
        }
    }
}


//--------------------------------------next-----------------------------------------------------------------------------------------------------------

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.IO;

//namespace _17nov2018
//{


//    class Division
//    {
//        int result;
//        string st = @"C:\Users\shivaleela.patil\Desktop\GitHub\Csharp\Practice\Csharp_Practice\Log File.txt";
//        Division()
//        {
//            result = 0;
//        }
//        public void division(int num1, int num2)
//        {
//            try
//            {
//                result = num1 / num2;
//            }
//            catch (DivideByZeroException e)
//            {
//                Console.WriteLine("Exception caught: {0}", e);
//                using (StreamWriter sw = File.AppendText(st))
//                {
//                    sw.WriteLine("Log File");
//                    sw.WriteLine("Date and time-> " + DateTime.Now);
//                    sw.WriteLine("Error-> " + e.Message);
//                    sw.WriteLine("Stack Trace->" + e.StackTrace);
//                    sw.WriteLine("end time-> " + DateTime.Now);
//                }
//            }
//            finally
//            {
//                Console.WriteLine("Result: {0}", result);//If we remove finally block result which is initialized to Zero will not be printed
//            }
//        }
//        static void Main(string[] args)
//        {
//            Division d = new Division();
//            d.division(25, 0);
//            Console.ReadLine();
//        }
//    }
//}
