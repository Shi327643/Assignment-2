using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptionProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    int[] arr = { 1, 2, 3, 4, 5 };
                    Console.WriteLine(arr[5]);
                    throw new IndexOutOfRangeException();
                }
                catch (IndexOutOfRangeException ex)
                {


                    throw new DivideByZeroException("This exception is only used for demo purpose",ex);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(String.Concat(ex.StackTrace,ex.Message));
                //if(ex.InnerException != null)
                //{
                //    Console.WriteLine(ex.InnerException.StackTrace);
                //    Console.WriteLine(ex.InnerException.Message);
                //}

                Console.WriteLine(ex.InnerException.GetType().Name);
                Console.ReadLine();

            }
            
        }
    }
}
