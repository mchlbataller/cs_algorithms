using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    class test
    {
        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
        public void Start()
        {
            int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            int[] numbers4 = new int[25] { 5, 2, 3, 1, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int n = 10, i;
            Debug.WriteLine("Quick Sort");
            Debug.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Debug.Write(arr[i] + " ");
            }
            quickSort(numbers4, 0, 24);
            Debug.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Debug.Write(arr[i] + " ");
            }
        }
    }
}
