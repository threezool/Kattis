using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    class dogsvscats
    {
        static void Main(string[] args)
        {
            int numberOfLists;
            string contestInput;


            numberOfLists = int.Parse(Console.ReadLine().Trim());

            for (int i = 0; i < numberOfLists; i++)
            {
                contestInput = Console.ReadLine();

                var components = contestInput.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in components)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
