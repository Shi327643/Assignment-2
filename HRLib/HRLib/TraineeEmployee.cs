using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public  class TraineeEmployee:Employee
    {
        private int noOfDays;
        public int NoOfDays
        {
            get { return noOfDays; }
            set { noOfDays = value; }
        }

        private double ratePerDay;
        public double RatePerDay
        {
            get { return ratePerDay; }
            set { ratePerDay = value; }
        }

        public TraineeEmployee()
        {
            noOfDays = 10;
            RatePerDay = 1000;
        }

        public TraineeEmployee(string name, string address, int days, double rateperday):base(name, address)
        {
            NoOfDays = days;
            RatePerDay = rateperday;
        }

        public override double CalculateSalary()
        {
            double salary;
            salary = NoOfDays * RatePerDay;
            return salary;
        }


        public override string ToString()
        {
            return base.ToString() + $"Days:{NoOfDays} RatePerDay:{RatePerDay}";
        }
    }
}
