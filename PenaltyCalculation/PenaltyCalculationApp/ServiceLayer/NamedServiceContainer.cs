using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public class NamedServiceContainer: INamedServiceContainer
    {
        public NamedServiceContainer(Dictionary<Type, Dictionary<string, Type>> dictionary)
        {
            Dictionary = dictionary;
        }

        public Dictionary<Type, Dictionary<string, Type>> Dictionary { get;}
    }
}
