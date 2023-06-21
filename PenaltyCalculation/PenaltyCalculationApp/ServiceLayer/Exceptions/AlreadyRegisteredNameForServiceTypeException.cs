using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Exceptions
{
    public class AlreadyRegisteredNameForServiceTypeException : Exception
    {
        public AlreadyRegisteredNameForServiceTypeException(string name, string serviceType, string alredyRegisteredImplementationType)
            : base($"The name {name} has alredy been registered for serviceType {serviceType} for the implementationType {alredyRegisteredImplementationType}")
        {
        }
    }
}
