using System;

namespace FileRenamer
{
    public class Guard
    {
        public static string FilterString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value");
            }

            return value.Trim();
        }

    }
}
