using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

    class LongestNonDecreasingSubsequence
    {
        static void Main()
        {
            Console.WriteLine("Enter the integers separated by an interval: ");
            string n = Console.ReadLine();

            string[] input=n.Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                numbers[i] = int.Parse(input[i]);
            }

            List<int> longestSequence = new List<int> { };

            int start = 0;
            int length = 1;
            int count = 1;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1]) 
                {
                    count++;

                    if (count > length) 
                    {
                        length = count;
                        start = (i + 1) - (length - 1);
                    }
                }
                else
                {
                    count = 1;
                }
            }

            for (int i = 0; i < length; i++)
            {
                longestSequence.Add(numbers[start + 1]);
            }

            long combinations = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                combinations *= 2;
            }

            for (long combination = 1; combination <= combinations; combination++)
            {
                string bin = Convert.ToString(combination, 2).PadLeft(numbers.Length, '0');
                char[] symb = bin.ToCharArray();
                Array.Reverse(symb);
                string revBin = new string(symb);

                List<int> symbList = new List<int> { };
                int bitCount = 0;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (revBin[i] == 1) 
                    {
                        symbList.Add(numbers[i]);
                        bitCount++;
                    }
                }

                if (bitCount < longestSequence.Count) 
                {
                    continue;
                }

                int currentLength = 0;
                List<int> currentLengthList = new List<int> { };

                if (symbList.Count > 1)
                {
                    int higher = symbList[0];
                    currentLengthList.Add(higher);

                    for (int i = 0; i < symbList.Count; i++)
                    {
                        if (symbList[i + 1] > higher) 
                        {
                            higher = symbList[i + 1];
                            currentLengthList.Add(higher);
                        }
                    }

                    currentLength = currentLengthList.Count;
                }

                if (currentLength > longestSequence.Count) 
                {
                    longestSequence = currentLengthList;
                }
            }

            for (int i = 0; i < longestSequence.Count; i++)
            {
                Console.Write(longestSequence[i] + " ");
            }
            Console.WriteLine(  );
        }
    }

