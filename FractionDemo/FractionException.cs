using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionDemo
{
    class FractionException : Exception
    {
        public String Message { get; set; }

        public FractionException()
        {
            Message = "division par 0 impossible";
        }

        public FractionException(string message)
        {
            Message = "division par 0 impossible";
        }








    }
}
