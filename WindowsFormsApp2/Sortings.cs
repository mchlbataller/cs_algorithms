using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace WindowsFormsApp2
{
    class Sortings
    {
        //  Method for the bubble sort
        public void BubbleSort(int[] number)
        {
            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    if (number[j] > number[j + 1])
                    {
                        int temp = number[j + 1];
                        number[j + 1] = number[j]; // swapping process
                        number[j] = temp;
                    }
                }

                foreach (int p in number)
                {
                    Debug.Write(p + ", ");
                }
                Debug.WriteLine("");
            }
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