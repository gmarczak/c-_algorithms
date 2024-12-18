using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 3, 4, 10, 40 };
        int x = 2;
        int result = BinarySearch(arr, x);

        if (result == -1)
            Console.WriteLine("Element not present in array");
        else
            Console.WriteLine("Element found at index " + result);
    }

    static int BinarySearch(int[] arr, int x)
    {
        int left = 0, right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == x)
                return mid;

            if (arr[mid] < x)
                left = mid + 1;

            else
                right = mid - 1;
        }

        return -1;
    }
}
