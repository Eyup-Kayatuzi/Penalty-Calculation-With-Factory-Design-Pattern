using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.FactoryPattern.Interface
{
    public interface IFactoryPatternResolver<out TService, in TEnum>
        where TEnum : Enum
    {
        TService Resolve(TEnum @enum);
    }
}
