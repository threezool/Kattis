using System;

namespace Kattis
{
    /// <summary>
    /// Dogs vs Cats - Not Working 
    /// 
    /// The latest reality show has hit the TV: “Cat vs. Dog”. In this show, a bunch of cats and dogs compete for the very prestigious Best 
    /// Pet Ever title. In each episode, the cats and dogs get to show themselves off, after which the viewers vote on which pets should stay 
    /// and which should be forced to leave the show.
    /// 
    /// Each viewer gets to cast a vote on two things: one pet which should be kept on the show, and one pet which should be thrown out. 
    /// Also, based on the universal fact that everyone is either a cat lover(i.e.a dog hater) or a dog lover(i.e.a cat hater), 
    /// it has been decided that each vote must name exactly one cat and exactly one dog.
    /// 
    /// Ingenious as they are, the producers have decided to use an advancement procedure which guarantees that as many viewers as possible 
    /// will continue watching the show: the pets that get to stay will be chosen so as to maximize the number of viewers who get both their 
    /// opinions satisfied. Write a program to calculate this maximum number of viewers.
    /// </summary>

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
