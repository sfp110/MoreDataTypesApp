using System;

namespace MoreDataTypesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int typeOfSpecification = 1;
            var myString = " C# list fundamentals ";
            Console.WriteLine(StringExercise(myString, typeOfSpecification));
        }

        public static string StringExercise(String myString, int typeOfSpecification)
        {
            //string result = string.Empty;
            //switch (typeOfSpecification)
            //{
            //    case 1:
            //        result = myString.Trim();
            //        break;
            //    case 2:
            //        result = myString.ToUpper();
            //        break;
            //    case 3:
            //        result = myString.Replace('L', '*').Replace('N', '*');
            //        break;
            //    case 4:
            //        int index = myString.IndexOf("N");
            //        if (index >= 0)
            //            result = result.Substring(0, index);
            //        break;

            //    default:
            //        break;
            //}

            //var trimmedString = myString.Trim();
            //var ucString = trimmedString.ToUpper();
            //var replacedString = ucString.Replace('L', '*');
            //var replacedString2 = replacedString.Replace('T', '*');
            //var nPos = replacedString2.IndexOf('N');
            //var finalString = replacedString2.Remove(nPos + 1);
            //return finalString;

            var result = myString.Trim().ToUpper().Replace('L', '*').Replace('T', '*');
            var index = result.IndexOf('N');
            result = result.Remove(index + 1);

            //I'm only adding a line of code here to test if I can have the repo in both computers
            //and that it won't result in any issues.


            return result;
        }
    }
}
