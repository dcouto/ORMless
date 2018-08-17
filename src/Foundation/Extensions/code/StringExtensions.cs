namespace Foundation.Extensions
{
    public static class StringExtensions
    {
        public static bool IsNotNullAndNotWhiteSpace(this string s)
        {
            return !string.IsNullOrWhiteSpace(s);
        }
    }
}
