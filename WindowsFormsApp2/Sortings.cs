using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
namespace WindowsFormsApp2
{
    class Sortings
    {
        public int counter { get; set; }
        //  Method for the bubble sort
        public void BubbleSort(int[] number)
        {
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        int temp = number[j + 1];
                        number[j + 1] = number[j]; // swapping process
                        number[j] = temp;
                    }
                }
            }
        }

        public bool notUnique(int[] testArray)
        {
            var hashSet = new HashSet<double>();
            foreach (var x in testArray)
            {
                if (!hashSet.Add(x))
                {
                    Debug.WriteLine("putang ina");
                    return true;
                }
            }
            return false;
        }


        //  Method for the Insertion sort
        public void Insertion_Sort(int[] numbers)
        {

            int n = 25, i, j, val, flag;
            Debug.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Debug.Write(numbers[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = numbers[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < numbers[j])
                    {
                        numbers[j + 1] = numbers[j];
                        j--;
                        numbers[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            Debug.Write("\nSorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Debug.Write(numbers[i] + " ");
            }
        }



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

        public static void exchange(int[] data, int m, int n)
        {
            int temporary;

            temporary = data[m];
            data[m] = data[n];
            data[n] = temporary;
        }

        public void QuickSort(int[] data, int l, int r)
        {
            int i, j;
            int x;

            i = l;
            j = r;

            x = data[(l + r) / 2]; /* find pivot item */
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    exchange(data, i, j);

                    i++;
                    j--;
                }
                if (i > j)
                    break;
            }
            if (l < j)
                QuickSort(data, l, j);
            if (i < r)
                QuickSort(data, i, r);
        }

        //static public void quickSort(int[] arr, int left, int right)
        //{
        //    int pivot;
        //    if (left < right)
        //    {
        //        pivot = Partition(arr, left, right);
        //        if (pivot > 1)
        //        {
        //            quickSort(arr, left, pivot - 1);
        //        }
        //        if (pivot + 1 < right)
        //        {
        //            quickSort(arr, pivot + 1, right);
        //        }
        //    }
        //}
        //public void Start()
        //{
        //    int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
        //    int[] numbers4 = new int[25] { 5, 2, 3, 1, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        //    int n = 10, i;
        //    Debug.WriteLine("Quick Sort");
        //    Debug.Write("Initial array is: ");
        //    for (i = 0; i < n; i++)
        //    {
        //        Debug.Write(arr[i] + " ");
        //    }
        //    quickSort(arr, 0, 9);
        //    Debug.Write("\nSorted Array is: ");
        //    for (i = 0; i < n; i++)
        //    {
        //        Debug.Write(arr[i] + " ");
        //    }

        //}


        //    public void SortArray(int[] numbers)
        //    {
        //        Quicksort(numbers, 0, numbers.Length - 1);
        //    }

        //    private static void Quicksort(int[] numbers, int left, int right)
        //    {
        //        int i = left;
        //        int j = right;

        //        var pivot = numbers[(left + right) / 2];

        //        while (i <= j)
        //        {
        //            while (numbers[i] < pivot)
        //                i++;

        //            while (numbers[j] > pivot)
        //                j--;

        //            if (i <= j)
        //            {
        //                var tmp = numbers[1];
        //                numbers[i] = numbers[j];
        //                numbers[j] = tmp;

        //                i++;
        //                j--;
        //            }
        //        }

        //        if (left < j)
        //            Quicksort(numbers, left, i);

        //        if (i < right)
        //            Quicksort(numbers, i, right);
        //    }
        //}
    }
}