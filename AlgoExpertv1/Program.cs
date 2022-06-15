using System;

namespace AlgoExpertv1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 1,2,3,5,6,8,9 };

            Console.WriteLine(SortedSquaredArray(array));
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


            return new int[] { };
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
