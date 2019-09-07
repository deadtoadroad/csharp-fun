namespace DeadToadRoad.Fun
{
    public static partial class Functions
    {
        #region Predicates

        public static bool IsEmpty(string a)
        {
            return a == string.Empty;
        }

        public static bool IsNotEmpty(string a)
        {
            return Not<string>(IsEmpty)(a);
        }

        public static bool IsNullOrEmpty(string a)
        {
            return string.IsNullOrEmpty(a);
        }

        public static bool IsNotNullOrEmpty(string a)
        {
            return Not<string>(IsNullOrEmpty)(a);
        }

        public static bool IsNullOrWhiteSpace(string a)
        {
            return string.IsNullOrWhiteSpace(a);
        }

        public static bool IsNotNullOrWhiteSpace(string a)
        {
            return Not<string>(IsNullOrWhiteSpace)(a);
        }

        public static bool IsWhiteSpace(string a)
        {
            return OptionFunctions.ToOption(a)
                .Map(EnumerableMembers.Cast<char>)
                .Map(EnumerableMembers.All<char>(char.IsWhiteSpace))
                .GetOrElse(false);
        }

        public static bool IsNotWhiteSpace(string a)
        {
            return Not<string>(IsWhiteSpace)(a);
        }

        #endregion
    }
}
