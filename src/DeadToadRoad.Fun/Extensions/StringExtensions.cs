namespace DeadToadRoad.Fun.Extensions
{
    public static class StringExtensions
    {
        #region Predicates

        public static bool IsEmpty(this string a)
        {
            return Functions.IsEmpty(a);
        }

        public static bool IsNotEmpty(this string a)
        {
            return Functions.IsNotEmpty(a);
        }

        public static bool IsNullOrEmpty(this string a)
        {
            return Functions.IsNullOrEmpty(a);
        }

        public static bool IsNotNullOrEmpty(this string a)
        {
            return Functions.IsNotNullOrEmpty(a);
        }

        public static bool IsNullOrWhiteSpace(this string a)
        {
            return Functions.IsNullOrWhiteSpace(a);
        }

        public static bool IsNotNullOrWhiteSpace(this string a)
        {
            return Functions.IsNotNullOrWhiteSpace(a);
        }

        public static bool IsWhiteSpace(this string a)
        {
            return Functions.IsWhiteSpace(a);
        }

        public static bool IsNotWhiteSpace(this string a)
        {
            return Functions.IsNotWhiteSpace(a);
        }

        #endregion
    }
}
