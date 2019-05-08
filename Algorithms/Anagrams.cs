using System;

namespace Algorithms
{
    public static class Anagrams
    {
        public static void IsAnagram()
        {
            Console.WriteLine("Enter first string");
            var first = Console.ReadLine();
            Console.WriteLine("Enter second string");
            var second = Console.ReadLine();
            var lengthOfFirst = first.Length;
            var lengthOfSecond = second.Length;
            var matchCount = 0;
            char[] firstArray = new char[lengthOfFirst];
            char[] secondArray = new char[lengthOfFirst];
            char temp = default(char);
            for (int i = 0; i < lengthOfFirst; i++)
            {
                firstArray[i] = first[i];
            }
            for (int i = 0; i < lengthOfSecond; i++)
            {
                secondArray[i] = second[i];
            }

            for (int i = 0; i < lengthOfFirst-1; i++)
            {
                for (int j = 0; j < lengthOfFirst-i-1; j++)
                {
                    if (firstArray[j + 1] > firstArray[j])
                    {
                        temp = firstArray[j];
                        firstArray[j] = firstArray[j + 1];
                        firstArray[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < lengthOfSecond - 1; i++)
            {
                for (int j = 0; j < lengthOfSecond - i - 1; j++)
                {
                    if (secondArray[j + 1] > secondArray[j])
                    {
                        temp = secondArray[j];
                        secondArray[j] = secondArray[j + 1];
                        secondArray[j + 1] = temp;
                    }
                }
            }
            first = new string(firstArray);
            second = new string(secondArray);
            
            if(first==second)

            //for (int i = 0; i < lengthOfFirst; i++)
            //{
            //    for (int j = 0; j < lengthOfSecond; j++)
            //    {

            //        if (first[i] == second[j])
            //        {
            //            matchCount++;
            //            break;
            //        }
            //    }
            //}
            //if(matchCount==lengthOfSecond)
                Console.WriteLine("Is Anagram");
            else
                Console.WriteLine("Not an Anagram");
        }
    }
}
