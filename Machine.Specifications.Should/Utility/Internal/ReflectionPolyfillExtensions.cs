
#if NET35 || NET40

using System;
using System.Reflection;

namespace System.Reflection
{
    public static class ReflectionPolyfillExtensions
    {

        public static Type GetTypeInfo(this Type type)
        {
            return type;
        }

    }
}
#endif
