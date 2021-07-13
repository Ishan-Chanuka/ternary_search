using System;

namespace ternary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int key = 5;
            int first = 1;
            int last = 10;

            int result = Convert.ToInt32(TernarySearch(first, last, key, arr));

            Console.WriteLine("Search key : " + key + " found at index of " + result);
        }

        static int TernarySearch(int first, int last, int key, int[] arr)
        {
           if(last > 1)
            {
                int mid1 = first + (last - first) / 3;
                int mid2 = last - (last - 1) / 3;

                if (arr[mid1] == key)
                    return mid1;

                if (arr[mid2] == key)
                    return mid2;


                if (key > arr[mid1])
                    return TernarySearch(first, last, key, arr);

                else if (key > arr[mid2])
                    return TernarySearch(first, last, key, arr);

                else
                    return TernarySearch(first, last, key, arr);
            }

            return -1;

        }

    }
}
