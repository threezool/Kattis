using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Election
{
    class Election
    {
        /// <summary>
        /// Votation - Working 
        /// 
        /// In an election with more than two candidates, it is often the case that the winner (the candidate receiving the most votes) 
        /// receives less than the majority of the votes. Given the results of an election, can you determine the winner, 
        /// and whether the winner received more than half of the votes?
        /// </summary>

        static void Main(string[] args)
        {
            var cases = ReadIntInput();

            for (int i = 0; i < cases; i++)
            {
                // Get the candidates and their votes and sort them in a descending order by votes 
                List<Candidate> candidates = GetCandidates(ReadIntInput()).OrderByDescending(c => c.Votes).ToList();

                // Print the result based on the number of votes
                if (candidates[0].Votes == candidates[1].Votes)
                {
                    Console.WriteLine("no winner");
                }
                else if (candidates[0].Votes > (candidates.Sum(c => c.Votes) / 2))
                {
                    Console.WriteLine($"majority winner {candidates[0].CandidateNumber}");
                }
                else if (candidates[0].Votes <= (candidates.Sum(c => c.Votes) / 2))
                {
                    Console.WriteLine($"minority winner {candidates[0].CandidateNumber}");
                }
            }
        }

        /// <summary>
        /// Get each candidates votes and return a list of candidates
        /// </summary>
        /// <param name="count">The number of candidates</param>
        /// <returns>Return a list of candidates and their votes</returns>
        private static List<Candidate> GetCandidates(int count)
        {
            List<Candidate> candidates = new List<Candidate>();

            for (int j = 0; j < count; j++)
            {
                candidates.Add(new Candidate
                {
                    CandidateNumber = j + 1,
                    Votes = ReadIntInput()
                });
            }

            return candidates;
        }

        /// <summary>
        /// Get the next input by Kattis assuming it is a integer
        /// </summary>
        /// <returns>Return the integer provided by Kattis</returns>
        private static int ReadIntInput()
        {
            return int.Parse(Console.ReadLine());
        }
    }

    class Candidate
    {
        public int CandidateNumber { get; set; }
        public int Votes { get; set; }
    }
}
