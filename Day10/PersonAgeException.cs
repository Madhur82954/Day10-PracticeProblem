using System;
using System.Collections.Generic;
using System.Text;

namespace Day10
{
    internal class PersonAgeException:Exception
    {
        public PersonAgeException(string message) : base(message)
        {

        }
    }
}
