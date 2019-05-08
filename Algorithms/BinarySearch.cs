using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearch
    {
        public int Search(int low, int high, int key, int[] array)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (array[mid] < key)
                    low = mid + 1;
                else if (array[mid] > key)
                    high = mid - 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
