using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// Engineering English - Working 
/// 
/// Engineers have taken over the university’s English department! As part of their plan to dominate the university, 
/// they have employed you to write their nefarious software. Their goal is to eliminate all duplicated words from all 
/// texts in the English department, because, as they say, “duplicated words are duplicated work” and 
/// “duplicated work wastes money.” Actually, what they would really say is “duplicated words are . work” and 
/// “. . wastes money”. This is what your program should do – remove all duplicate words and replace them with a period.
/// </summary>

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
