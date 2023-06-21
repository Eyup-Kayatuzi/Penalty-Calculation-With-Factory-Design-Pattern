using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Exceptions;
using ServiceLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class NamedServiceProvider
    {
        public static TService GetService<TService>(this IServiceProvider serviceProvider, string name)
        {
            var namedServiceSelector = serviceProvider.GetService<INamedServiceContainer>();

            if (namedServiceSelector != null)
            {
                if (namedServiceSelector.Dictionary.TryGetValue(typeof(TService), out var item))
                {
                    if (item.TryGetValue(name, out var implementationType))
                    {
                        var deneme = serviceProvider.GetServices<TService>().ToList();
                        var dd = deneme[0];

                        return serviceProvider.GetServices<TService>().FirstOrDefault(t => t.GetType() == implementationType);
                    }
                }
            }

            throw new NotExistingNamedServiceException(typeof(TService).FullName, name);
        }
    }
}
