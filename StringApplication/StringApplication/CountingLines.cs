using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApplication
{
    internal class StringFuctions 
    {
        string? enterString;

        public void CountLines() 
        {

            Console.WriteLine("Counting lines \nPlease enter input : ");
            enterString = Console.ReadLine();
            enterString!.ToLower();

            int count = 0;

            for (int i = 0; i < enterString!.Length; i++)
            {
                if (i == enterString.Length - 1)
                {
                    if (enterString[i] == '.' || enterString[i] == '?' || enterString[i] == '!')
                    {
                        count++;
                    }
                }

                else if (enterString[i] == '.' && enterString[i + 1] == ' ')
                {
                    count++;
                }

                else if (enterString[i] == '?' && enterString[i + 1] == ' ')
                {
                    count++;
                }

                else if (enterString[i] == '!' && enterString[i + 1] == ' ')
                {
                    count++;
                }
            }
            Console.WriteLine("\nNumber of new lines:" + count);
        }

        public void ReverseWords()
        {

            Console.WriteLine("Reverse of words in Line \n Please enter : ");
            enterString = Console.ReadLine();
            enterString.ToLower();

            string[] wordsArr = enterString.Split(" ");
            for (int i = 0; i < wordsArr.Length; i++)
            {
                string reversedWords = "";
                for (int j = wordsArr[i].Length - 1; j >= 0; j--)
                {
                    reversedWords = reversedWords + wordsArr[i][j];
                }

                Console.WriteLine(reversedWords + " ");

            }
        }

        public void RemoveDuplicates() 
        {
            Console.WriteLine("Remove duplicates \nPlease enter : ");
            
            enterString = Console.ReadLine();
            enterString.ToLower();

            string answer = "";
            for (int i = 0; i < enterString.Length; i++)
            {
                if (!answer.Contains(enterString[i]) || (enterString[i] == ' '))
                {
                    answer += enterString[i];
                }
            }
            answer = answer.Replace("  ", " ");
            Console.WriteLine("String After Removing Duplicate Characters: " + answer);
        }

        public void LongestCommonPrefix()
        {
            Console.WriteLine("Longest Common Prefix \nPlease enter input : ");
            
            enterString = Console.ReadLine();
            string[] wordsArr = enterString.Split(" ");

            List<string> repeatedPrefixes = new List<string>();
            for (int i = 0; i < wordsArr.Count(); i++)
            {
                for (int j = i + 1; j < wordsArr.Count(); j++)
                {
                    int sizeOfSmallerWord = wordsArr[i].Length < wordsArr[j].Length ? wordsArr[i].Length : wordsArr[j].Length;
                    string prefix = "";
                    for (int k = 0; k < sizeOfSmallerWord; k++)
                    {
                        if (wordsArr[i][k] == wordsArr[j][k])
                        {
                            prefix += wordsArr[i][k];
                        }
                        else
                        {
                            break;
                        }
                    }
                    repeatedPrefixes.Add(prefix);
                }
            }
          
            string longestCommonPrefix = "";
            foreach (var s in repeatedPrefixes)
            {
                if (longestCommonPrefix.Length < s.Length)
                {
                    longestCommonPrefix = s;
                }
            }
            Console.WriteLine("\n\nLongest Common Prefix is: " + longestCommonPrefix);


        }
    }
}
