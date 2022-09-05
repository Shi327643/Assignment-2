using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public abstract class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int empNo;
        public int EmpNo
        {
            get { return empNo; }
            set { empNo = value; }
        }

        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        
        public Employee()
        {
            name = "Sahil";
            Address = "Kalwa";
            Count++;
            EmpNo = Count;

        }
        public Employee(string name, string address):this()
        {
            Name = name;
            Address = address;

        }
        private static int count;
        public static int Count
        {
            get { return count; }
           private set { count = value; }
        }

        public abstract double CalculateSalary();
        public override string ToString()
        {
            return String.Format($"Name:{Name} EmpNo:{EmpNo} Address:{Address}");
        }
    }
}
