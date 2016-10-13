using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySorter
{
    class IllegalEnumValueException : Exception
    {
        public IllegalEnumValueException()
        {

        }

        public IllegalEnumValueException(string message) : base(message)
        {

        }

        public IllegalEnumValueException(string message, Exception inner) : base(message, inner)
        {

        }
    }
}
