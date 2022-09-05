using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PasswordValidation
{
    internal class Password
    {
        private string pass;
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        public Password(string pass) 
        {
            Pass = pass;
            
        }

        private static readonly Regex regex = new Regex("[^A-Za-z0-9]");

        private  Boolean IsLength()
        {
            if (Pass.Length >= 6)
            {
                return true; 
            }
            else
            {
                return false;
            }
        }

        private Boolean IsDigit()
        {
            bool isNumber = int.TryParse(Pass, out int digit);
            if (regex.IsMatch(Pass) || isNumber)
            {
                return true;
            }
            else
            {
                return false ;

            }
                        
        }

        private Boolean IsSpecialCharacter()
        {
            if (regex.IsMatch(Pass))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private Boolean IsUpperCase()
        {
            if (Char.IsUpper(Pass, 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean IsPasswordValidate()
        {
            if(IsLength() ==true && IsDigit()==true && IsSpecialCharacter()==true && IsUpperCase() == true)
            {
                return true;
            }
            else
            {
                throw new WeakPasswordException("Weak password. please enter a strong password");
            }
            


        }

        public override string ToString()
        {
            return String.Format($" Password:{Pass}");
        }


    }
}
