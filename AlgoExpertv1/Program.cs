using System;

namespace AlgoExpertv1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> array = new List<int> { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new List<int> { 1, 6, -1, 10 };

            Console.WriteLine(ValidateSubsequence(array, sequence));
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
