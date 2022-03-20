using System;
using System.Reflection;

namespace CustomerApiTests
{
    public static class TestBase
    {
        public static TReturn CallMethod<TReturn>(
          this object instance,
          string methodName,
          params object[] parameters)
        {
            Type type = instance.GetType();
            var bindingAttr = BindingFlags.NonPublic | BindingFlags.Instance;
            var method = type.GetMethod(methodName, bindingAttr);

            return (TReturn)method.Invoke(instance, parameters);
        }
    }
}
