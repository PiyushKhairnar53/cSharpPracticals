
namespace StringApplication
{
    public class StringClass
    {
        public static void Main(string[] args)
        {
       
            StringFuctions stringFunctions = new StringFuctions();
            stringFunctions.RemoveDuplicates();
            stringFunctions.ReverseWords();
            stringFunctions.LongestCommonPrefix();
            stringFunctions.CountLines();

            StringMethodsClass stringMethodsClass = new StringMethodsClass();
            stringMethodsClass.StringMethods();

        }
    }
}