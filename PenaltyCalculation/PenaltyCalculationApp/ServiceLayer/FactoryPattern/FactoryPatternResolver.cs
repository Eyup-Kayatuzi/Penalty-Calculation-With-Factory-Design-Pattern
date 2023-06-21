using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.FactoryPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.FactoryPattern
{
    public abstract class FactoryPatternResolver<TService, TEnum> : IFactoryPatternResolver<TService, TEnum> where TEnum : Enum
    {
        private readonly IServiceProvider _serviceProvider;
        public FactoryPatternResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public TService Resolve(TEnum @enum)
        {
            return _serviceProvider.GetService<TService>(@enum.GetName());
        }
    }
}
