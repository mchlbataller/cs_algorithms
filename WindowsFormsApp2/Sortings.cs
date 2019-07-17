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


        // method for swapping
        private static void swapNumbers(int[] data, int m, int n)
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

            x = data[(l + r) / 2];      // Find the pivot number
            while (true)
            {
                while (data[i] < x)
                    i++;
                while (x < data[j])
                    j--;
                if (i <= j)
                {
                    swapNumbers(data, i, j);

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
    }
}