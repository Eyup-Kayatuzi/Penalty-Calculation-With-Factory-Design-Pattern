using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Exceptions
{
    public class NotExistingNamedServiceException : Exception
    {
        public NotExistingNamedServiceException(string serviceType, string name) : base($"There's no service of type {serviceType} named as {name}")
        {
        }
    }
}
