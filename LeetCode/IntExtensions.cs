using System.Text;

namespace LeetCode
{
    public static class IntExtensions
    {
        public static int Reverse(this int x)
        {
            var number = (x < 0) ? -1 * x : x;
            var numberAsString = number.ToString();

            var builder = new StringBuilder();
            for (int i = 0; i < numberAsString.Length; i++)
            {
                builder.Append(numberAsString[numberAsString.Length - 1 - i]);
            }

            var reversedString = builder.ToString();

            if (x < 0)
                reversedString = "-" + reversedString;

            if (Int32.TryParse(reversedString, out int result))
            {
                return result;
            }

            return 0;
        }
    }
}
