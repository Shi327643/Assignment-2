using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidation
{
    public class WeakPasswordException : Exception
    {
        public WeakPasswordException(string msg) : base(msg)
        {

        }
    }
    
}
