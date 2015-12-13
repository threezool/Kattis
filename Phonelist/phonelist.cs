using System;
using System.Collections.Generic;

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

namespace Kattis
{
    class phonelist
    {
        static void Main(string[] args)
        {
            int numberOfLists, numberOfEntries;
            bool isConsistent;
            int.TryParse(Console.ReadLine(), out numberOfLists);
            for (int i = 0; i < numberOfLists; i++)
            {
                isConsistent = true;
                int.TryParse(Console.ReadLine(), out numberOfEntries);
                List<string> entryList = new List<string>();
                while (entryList.Count < numberOfEntries)
                {
                    entryList.Add(Console.ReadLine());
                }
                entryList.Sort();
                for (int j = 1; j < numberOfEntries; j++)
                {
                    if (entryList[j].StartsWith(entryList[j - 1], StringComparison.Ordinal))
                    {
                        isConsistent = false;
                        break;
                    }
                }
                Console.WriteLine(isConsistent ? "YES" : "NO");
            }
        }
    }
}