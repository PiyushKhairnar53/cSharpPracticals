using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctionApplication
{
    internal class StringFuctions
    {
        string? enterString;

        public void CountLines()
        {

            Console.WriteLine("Counting lines \nPlease enter input : ");
            enterString = Console.ReadLine();
            enterString!.ToLower();

            string[] wordsArr = enterString!.Split(" ");

            int count = 0;
            foreach (string str in wordsArr) 
            {
                char lastCharacter = str[str.Length - 1];
                if (lastCharacter == '.' || lastCharacter == '?' || lastCharacter == '!') 
                {
                    count++;
                }

            }

            Console.WriteLine("\nNumber of new lines:" + count);
        }

        public void ReverseWords()
        {

            Console.WriteLine("Reverse of words in Line \nPlease enter : ");
            enterString = Console.ReadLine();
            enterString.ToLower();

            string result = string.Join(" ", enterString
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine(result);

        }

        public void RemoveDuplicates()
        {
            Console.WriteLine("Remove duplicates \nPlease enter : ");

            enterString = Console.ReadLine();
            enterString.ToLower();

            var uniqueCharArray = enterString.ToCharArray().Distinct().ToArray();
            var resultString = new string(uniqueCharArray);
            Console.WriteLine("String After Removing Duplicate Characters: " + resultString);
        }

        public void LongestCommonPrefix()
        {
            Console.WriteLine("Longest Common Prefix \nPlease enter input : ");
            enterString = Console.ReadLine();
            string[] wordsArr = enterString!.Split(" ");

            var longestCommonPrefix = Enumerable.Range(1, wordsArr.Max(_ => _)!.Length)
            .Select(i =>
            {
                var grouped = wordsArr.Where(x => x.Length >= i)
                    .GroupBy(x => x[..i])
                    .Where(x => x.Count() > 1)
                    .OrderByDescending(x => x.Count())
                    .Select(x => new { LongestCommonPrefix = x.Key })
                    .FirstOrDefault();

                return grouped?.LongestCommonPrefix ?? string.Empty;
            }).Max();

            Console.WriteLine("Longest common prefix : " + longestCommonPrefix);
        }
    }

}
