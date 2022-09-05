using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation
{
    internal class PasswordTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Password:");
            string value = Console.ReadLine();
            Password password = new Password(value);
            Console.WriteLine(password);
            try
            {
                bool res = password.IsPasswordValidate();
                Console.WriteLine(res);
            }
            catch (WeakPasswordException ex)
            {

                Console.WriteLine(ex.Message);
                Console.WriteLine("Weak password. Please make a strong password");
            }
            

            Console.ReadLine();
            
            




        }
        

    }
}
