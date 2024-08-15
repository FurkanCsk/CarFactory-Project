using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory_Project
{
    // Custom exception class for input validation
    public class InputException : Exception
    {
        public InputException(string message) : base(message) 
        {

        }
    }
}
