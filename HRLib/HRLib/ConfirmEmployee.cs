using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public  class ConfirmEmployee:Employee
    {
        private double basic;
        public double Basic
        {
            get { return basic; }


            set {
                if (value <= 5000)
                {
                    throw new BasicException("Less Basic Amount");
                }
                else
                {
                    basic = value;
                }
                 }
        }

        private string designation;
        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public ConfirmEmployee()
        {
            Basic = 6000;
            Designation = "Software Developer";
        }

        public ConfirmEmployee(string name, string address, double basic, string designation) : base(name, address)
        {
            Basic = basic;
            Designation = designation;

        }

        public override string ToString()
        {
            return base.ToString()+$"Basic:{Basic} Designation:{Designation}"; 
        }

        public override double CalculateSalary()
        {
            if(Basic <= 5000)
            {
                throw new BasicException("Basic amount is very low");
            }
            else
            {
                if (Basic >= 30000)
                {
                    double HRA = Basic * 0.3;
                    double Conv = Basic * 0.3;
                    double PF = Basic * 0.1;

                    double NetSalary;
                    NetSalary = Basic + HRA + Conv - PF;
                    return NetSalary;
                }
                else if (Basic >= 20000)
                {
                    double HRA = Basic * 0.2;
                    double Conv = Basic * 0.2;
                    double PF = Basic * 0.1;

                    double NetSalary;
                    NetSalary = Basic + HRA + Conv - PF;
                    return NetSalary;


                }
                else
                {
                    double HRA = Basic * 0.1;
                    double Conv = Basic * 0.1;
                    double PF = Basic * 0.1;

                    double NetSalary;
                    NetSalary = Basic + HRA + Conv - PF;
                    return NetSalary;

                }
            }
            
        }
    }
}
