using System;

namespace mylib
{
    public static class mylib
    {
        /// <summary>
        ///     Gets the Analytics service.
        /// </summary>

        public static ITest Test => throw NotImplementedInReferenceAssembly();

        #region Private methods

        internal static Exception NotImplementedInReferenceAssembly()
        {
            return new NotImplementedException(
                "This functionality is not implemented in the portable version of this assembly.");
        }

        #endregion
    }
}
