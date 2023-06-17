using Microsoft.CSharp.RuntimeBinder;
using System.Dynamic;

namespace CaseInsensitive
{
    public class CaseInsensitiveDynamic : DynamicObject
    {
        private readonly IDictionary<string, object> properties;

        //added variable   

        public CaseInsensitiveDynamic(object properties)
        {
            if (properties == null)
                throw new ArgumentNullException(nameof(properties), "Properties object cannot be null.");

            this.properties = properties.GetType()
                .GetProperties()
                .ToDictionary(p => p.Name, p => p.GetValue(properties));
        }

        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            var propertyName = properties.Keys.
                FirstOrDefault(k => string.Equals(k, binder.Name, StringComparison.OrdinalIgnoreCase));

            if (propertyName != null)
            {
                result = properties[propertyName];
                return true;
            }

            result = null;
            return false;
        }
    }
}

namespace CheckProperty
{
    public class CheckIsDynamicPropertyExist
    {
        public static bool IsPropertyExist(dynamic obj, string name)
        {
            try
            {
                var value = obj[name].Value;
                return true;
            }
            catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException)
            {
                return false;
            }
        }
    }
}