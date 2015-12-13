using System;
using System.Collections.Generic;

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