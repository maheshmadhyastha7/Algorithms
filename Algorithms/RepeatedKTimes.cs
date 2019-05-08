using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class RepeatedKTimes
    {
        int[] array;
        int count;
        int[] inner;
        int? number;
        public void Execute()
        {
            Console.WriteLine("Enter the size of array");
            //5
            var size = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter array elements");
            //2,2,4,1,1
            array = new int[size];
            inner = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                inner[i] = array[i];
            }
            Console.WriteLine("Enter the frequency of occurance");
            //2
            var freq = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                count = 0;
                for (int j = 0; j < size; j++)
                {
                    if (array[i] == inner[j])
                        count++;
                }
                if (count == freq)
                {
                    if (number == null)
                        number = array[i];
                    if (number >= array[i])
                        number = array[i];
                  //  break;
                }
            }
            if (number == null)
                Console.WriteLine($"No match found with {freq} occurances");
            else
                Console.WriteLine(number);
            Console.ReadLine();
        }

    }
}
