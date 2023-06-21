using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.FactoryPattern
{
    public static class FactoryPatternHelpers
    {
        public static string GetName<TEnum>(this TEnum @enum)
            where TEnum : Enum
        {
            return $"{@enum.GetType().FullName}-@{Convert.ToInt32(@enum).ToString()}";
        }
    }
}
