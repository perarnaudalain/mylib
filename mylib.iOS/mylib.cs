using System;
using System.Threading;

namespace mylib
{
    public static class mylib
    {
        static readonly Lazy<ITest> _test =
        new Lazy<ITest>(CreateTest, LazyThreadSafetyMode.PublicationOnly);

        public static ITest Test => Instance(_test);

        static ITest CreateTest()
        {
#if __MOBILE__
            return new Test();
#else
                return null;
#endif
        }

        static T Instance<T>(Lazy<T> lazy) where T : class
        {
            var ret = lazy.Value;
            if (ret == null) throw NotImplementedInReferenceAssembly();
            return ret;
        }

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException(
                "This functionality is not implemented in the portable version of this assembly.");
        }
    }
}
