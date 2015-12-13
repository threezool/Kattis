using System;
using System.Collections.Generic;

namespace Phonelist
{
    /// <summary>
    /// Phonelist - Not Working 
    /// 
    /// Given a list of phone numbers, determine if it is consistent in the sense that no number is the prefix of another. 
    /// Let’s say the phone catalogue listed these numbers:
    ///
    /// - Emergency 911
    /// - Alice 97 625 999
    /// - Bob 91 12 54 26
    ///
    /// In this case, it’s not possible to call Bob, because the central would direct your call to the emergency line as soon 
    /// as you had dialled the first three digits of Bob’s phone number.So this list would not be consistent.
    /// </summary>

    internal class Phonelist
    {
        private static void Main(string[] args)
        {
            int numberOfLists;
            int.TryParse(Console.ReadLine(), out numberOfLists);
            for (var i = 0; i < numberOfLists; i++)
            {
                var isConsistent = true;
                int numberOfEntries;
                int.TryParse(Console.ReadLine(), out numberOfEntries);
                List<string> entryList = new List<string>();
                while (entryList.Count < numberOfEntries)
                {
                    entryList.Add(Console.ReadLine());
                }
                entryList.Sort();
                for (var j = 1; j < numberOfEntries; j++)
                {
                    if (!entryList[j].StartsWith(entryList[j - 1], StringComparison.Ordinal)) continue;
                    isConsistent = false;
                    break;
                }
                Console.WriteLine(isConsistent ? "YES" : "NO");
            }
        }
    }
}