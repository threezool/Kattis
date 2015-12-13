using System;
using System.Collections.Generic;
using System.Text;

namespace Kattis
{
    public class engineeringenglish
    {
        public static void Main(string[] args)
        {
            //Initialize variables 
            var uniqueWords = new HashSet<string>();

            // String builder is more optimized for constructing a string
            var resultBuilder = new StringBuilder();
            string input;

            //Input
            while ((input = Console.ReadLine()) != null)
            {
                //Check
                foreach (var word in input.Split(' '))
                {
                    var lowerWord = word.ToLower();
                    if (!uniqueWords.Contains(lowerWord))
                    {
                        uniqueWords.Add(lowerWord);
                        // Add string to stringbuilder.
                        resultBuilder.Append(word);
                    }
                    else
                    {
                        // Add string to stringbuilder.
                        resultBuilder.Append(".");
                    }
                    // Add string to stringbuilder.
                    resultBuilder.Append(" ");
                }
            }

            //Output from stringbuilder
            Console.Write(resultBuilder.ToString());
        }
    }
}
