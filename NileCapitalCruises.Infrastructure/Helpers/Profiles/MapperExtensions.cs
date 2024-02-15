using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NileCapitalCruises.Infrastructure.Helpers.Profiles
{
    public static class MapperExtensions
    {
        public static void MapProperties<TSrc, TDest>(TSrc source, TDest destination)
        {
            var sourceProperties = typeof(TSrc).GetProperties();
            var destinationProperties = typeof(TDest).GetProperties();

            foreach (var sourceProperty in sourceProperties)
            {
                var destinationProperty = destinationProperties.FirstOrDefault(p => p.Name == sourceProperty.Name);

                if (destinationProperty != null && destinationProperty.CanWrite)
                {
                    var value = sourceProperty.GetValue(source);
                    destinationProperty.SetValue(destination, value);
                }
            }
        }
    }
}
