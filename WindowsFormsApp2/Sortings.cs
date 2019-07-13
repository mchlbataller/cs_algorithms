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
        private int[] number = new int[25] { 5, 2, 1, 3, 4, 5, 2, 1, 3, 4, 5, 2, 1, 3, 4, 5, 2, 1, 3, 4, 5, 2, 1, 3, 4 };

        //Bubble Sort
        public void BubbleSort()
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

        public void Insertion_Sort()
        {
            int n = 10, i, j, temp, flag;
            for(i = 1; i < n; i++)
            {
                temp = number[i];
                flag = 0;
                for (j = i-1; j>=0 && flag != 1;)
                {
                    if (temp < number[j])
                    {
                        number[j + 1] = number[j];
                        j--;
                        number[j + 1] = temp;
                    }
                    else
                        flag = 1;
                }
            }

        }

    }
}
