using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Interface
{
    public interface INamedServiceContainer
    {
        Dictionary<Type, Dictionary<string, Type>> Dictionary { get;}
    }
}
