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


            List<ConfirmEmployee> confirmEmployeeList1 = new List<ConfirmEmployee>();// Creating List of ConfirmEmployee 

            confirmEmployeeList1.Add(new ConfirmEmployee { Address = "Kalyan", Designation = "Software Developer", Name = "Shivam" });

            confirmEmployeeList1.Add(new ConfirmEmployee { Address = "Bhandup", Designation = "Consultant", Name = "Rutuja" });

            List<TraineeEmployee> traineeEmployeeList1 = new List<TraineeEmployee>();// Creating list of Trainee Employee

            traineeEmployeeList1.Add(new TraineeEmployee { Address = "Kalwa", Name = "Sahil", RatePerDay = 900 });

            traineeEmployeeList1.Add(new TraineeEmployee { Address = "Thane", Name = "Abujar", RatePerDay = 1000 });

            string option;
            int choice;
            int num1;
            do
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1)Display All Employees\n 2)Display ConfirmEmployee by Number\n 3)Display TraineeEmployee by number\n");
                choice = int.Parse(Console.ReadLine());


                switch (choice)
                {
                    case 1:

                        foreach (ConfirmEmployee confirmEmp in confirmEmployeeList1)
                        {
                            Console.WriteLine(confirmEmp.ToString());
                        }

                        foreach (TraineeEmployee TraineeEmp in traineeEmployeeList1)
                        {
                            Console.WriteLine(TraineeEmp.ToString());
                        }


                        //Console.WriteLine(confirmEmployeeList1[0].Name);
                        //Console.WriteLine(confirmEmployeeList1[1].Name);

                        //Console.WriteLine(traineeEmployeeList1[0].Name);
                        //Console.WriteLine(traineeEmployeeList1[1].Name);

                        break;
                    case 2:
                        Console.WriteLine("Enter the ConfirmEmployee number:");
                        num1 = int.Parse(Console.ReadLine());

                        if (num1 == confirmemployee.EmpNo)
                        {
                            Console.WriteLine(confirmemployee);

                           
                        }
                        else
                        {
                            Console.WriteLine("Employee Not Found");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the TraineeEmployee number:");
                        num1 = int.Parse(Console.ReadLine());

                        if (num1 == traineeemployee.EmpNo)
                        {
                            Console.WriteLine(traineeemployee);


                        }
                        else
                        {
                            Console.WriteLine("Empoyee Not Found");
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
