using System;
using System.Linq;

namespace AlgoExpertv1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 1,2,3,5,6,8,9 };

            List<List<string>> competitions = new List<List<string>>
            {
                new List<string>{ "HTML", "C#" },
                new List<string>{ "C#", "Python" },
                new List<string>{ "Python", "HTML" }
            };

            List<int> results = new List<int> { 0, 0, 1 };

            foreach (KeyValuePair<string, int> item in TournamentWinner(competitions, results))
            {
                Console.WriteLine(item.Key + " " + item.Value + " ");
            }
        }

        /// <summary>
        /// Algo tournament taking place in which teams of programmers compete against each other to solve 
        /// algorithmic problems as fast as possible. Teams compete in a round robin, where each team
        /// faces off against all other teams. Only two teams compete against each other at a time, and for
        /// each competition, one team is designated the home team, while the other team is the away team. In
        /// each competition there's always one winner and one loser; there are no ties. A team receives 3 points
        /// if it wins and 0 points if it loses. The winner of the tournament is the team that receives the most amount
        /// of points.
        /// 
        /// Given an array of pairs representing the teams that have competed against each other and an array containing
        /// the results of each competition, write a function that returns the winner of the touranment. The input arrays
        /// are named competitions and results, respectively. The competitions array has alements inn the form of 
        /// [homeTeam, awayTeam]. where each team is a string of at most 30 characters representing the name of the team.
        /// The results array contains information about the winner of the competitions[i], where a 1 in the results array
        /// means that the home team in the corresponding competition won and a 0 means that the away team won.
        /// 
        /// It's guarenteed that exactly one team will win the tournament and that each team will compete against
        /// all other teams exactly one. It's also guarenteed that the tournament will always have at least two teams.
        /// </summary>
        /// <param name="competitions"></param>
        /// <param name="results"></param>
        /// <returns></returns>
        public static Dictionary<string, int> TournamentWinner(List<List<string>> competitions,
            List<int> results)
        {
            Dictionary<string, int> pointTracking = new Dictionary<string, int>();

            //for (int i = 0; i < competitions.Count; i++) // Results will match this level
            //{
            //    List<string> rounds = competitions[i];

            //    if (pointTracking.ContainsKey(rounds[results[i]]))
            //    {
            //        pointTracking[rounds[results[i]]] += 3;
            //    }
            //    else
            //    {
            //        pointTracking.Add(rounds[results[i]], 0);
            //    }
            //}

            for (int i = 0; i < competitions.Count; i++) // Results will match this level
            {
                List<string> rounds = competitions[i];

                if (pointTracking.ContainsKey(rounds[0]))
                {
                    pointTracking[rounds[0]] += 3;
                }
                else if (pointTracking.ContainsKey(rounds[1]))
                {
                    pointTracking[rounds[1]] += 3;
                }
                else
                {
                    if (results[i] == 0)
                    {
                        pointTracking.Add(rounds[1], 3);
                    }
                    else
                    {
                        pointTracking.Add(rounds[0], 3);
                    }
                }
            }

            // Write your code here.
            return pointTracking;
        }

        /// <summary>
        /// Write a function that takes in a non-empty array of integers that are sorted in ascending order
        /// and returns a new array of the same length with the squares of the original integers also sorted
        /// in ascending order.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public static int[] SortedSquaredArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= array[i];
            }

            Array.Sort(array);

            return array;
        }

        public static bool ValidateSubsequence(List<int> array,
            List<int> sequence)
        {
            //for (int i = 0; i < array.Count; i++)
            //{
            //    for (int j = 0; j < sequence.Count; j++)
            //    {
            //        if (sequence[j] == array[i])
            //        {
            //            sequence.RemoveAt(j);
            //            break;
            //        }
            //    }
            //}

            //return !sequence.Any();

            int seqIndex = 0;
            foreach (var val in array)
            {
                if (seqIndex == sequence.Count)
                {
                    break;
                }

                if (sequence[seqIndex] == val)
                {
                    seqIndex++;
                }
            }

            return seqIndex == sequence.Count;
        }
    }
}
