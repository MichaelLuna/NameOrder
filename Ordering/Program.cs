using System;
using System.Text;

namespace Ordering
{
    public class Program
    {
        const string crlf = "\r\n";

        static void Main(string[] args)
        {
            string nameList = "Sonia Maria Wood Dempster";
            char[] sortOrderChar = { '4', '1', '2', '3' };

            string result = Reorder(nameList, sortOrderChar);

            Console.WriteLine(result);

        }

        public static string Reorder(string nameList, char[] sortOrderChar)
        {
            string[] names = nameList.Split(' ');
            int sortOrderCount = sortOrderChar.Length;
            int[] sortOrder = new int[sortOrderCount];
            bool isInt;
            int number;
            int i = 0;

            foreach (char item in sortOrderChar)
            {
                isInt = int.TryParse(item.ToString(), out number);

                if (isInt) { sortOrder[i] = number - 1; }
                else { sortOrder[i] = -1; }  // Would add some sort way to handle non integer values
                i++;
            }

            var sb = new StringBuilder();

            foreach (var item in sortOrder)
            {
                sb.Append(names[item]);
                sb.Append(' ');
            }

            string result = sb.ToString();
            return result.TrimEnd();
        }
    }
}
