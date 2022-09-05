using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRLib;

namespace ABCCorp
{
    internal class HRAPP
    {


        static void Main(string[] args)
        {
            ConfirmEmployee confirmemployee = new ConfirmEmployee(); 
            TraineeEmployee traineeemployee = new TraineeEmployee();

            List<Employee> employeList = new List<Employee>();    

            List<ConfirmEmployee> confirmEmployeeList1 = new List<ConfirmEmployee>();// Creating List of ConfirmEmployee 

            try
            {
                employeList.Add(new ConfirmEmployee { Address = "Kalyan", Designation = "Software Developer", Name = "Shivam", Basic = 22000, EmpNo=1 });

                employeList.Add(new ConfirmEmployee { Address = "Bhandup", Designation = "Consultant", Name = "Rutuja", Basic = 25000, EmpNo=2 });

            }
            catch (BasicException ex)
            {

                //throw new BasicException(ex.Message);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Very Les Basic Amount");
            }
            

            List<TraineeEmployee> traineeEmployeeList1 = new List<TraineeEmployee>();// Creating list of Trainee Employee

            employeList.Add(new TraineeEmployee { Address = "Kalwa", Name = "Sahil", RatePerDay = 900, NoOfDays=15, EmpNo=3});

            employeList.Add(new TraineeEmployee { Address = "Thane", Name = "Abujar", RatePerDay = 1000 , NoOfDays=20, EmpNo=4});

            string option;
            int choice;
            int num1;
            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1)Display All Employees\n 2)Display ConfirmEmployee by Number\n");
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:


                        foreach (Employee employee in employeList)
                        {
                            Console.WriteLine(employee.ToString());
                        }

                        

                        break;
                    case 2:
                        Console.WriteLine("Enter the ConfirmEmployee number:");
                        num1 = int.Parse(Console.ReadLine());
                        foreach (Employee employee in employeList)
                        {
                            if(num1 == employee.EmpNo)
                            {
                                Console.WriteLine(employee.ToString());
                            }

                        }
                        
                        break;
                    

                    default:
                        Console.WriteLine("Invalid choice");
                        break;




                }
                Console.WriteLine("Do you want to continue? iF yes, please type Y or else type N");
                option = Console.ReadLine();

            } while (option == "Y");





        }



    }
}
