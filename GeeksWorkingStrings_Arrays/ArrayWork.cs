using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksWorkingStrings_Arrays
{
    class ArrayWork
    {
        public void StringReverse(string s)
        {
            int j = 0;
            int len = 1;
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != '.')
                {
                    len++;
                }
                else
                {
                    stack.Push(s.Substring(j, len));
                    if (i != s.Length - 1)
                    {
                        j = i + 1;
                    }
                }
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item + ".");
            }
        }


        public void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i = 0;
            int j = 0;
            for (i = 0; i < n1; ++i)
            {
                L[i] = arr[l + i];
            }
            for (j = 0; j < n2; ++j)
            {
                R[j] = arr[m + 1 + j];
            }
            i = 0;
            j = 0;
            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void Sort(int l, int r, int[] arr)
        {
            if (l < r)
            {
                int m = (l + r) / 2;

                Sort(l, m, arr);
                Sort(m + 1, r, arr);

                Merge(arr, l, m, r);
            }
        }


        public int FindTriplets(int [] arr, int sum)
        {
            BubbleSort(ref arr);
            int i = 0;
            int k = arr.Length - 1;
            int j = 1;
            int answer = 0;
            while(j < k)
            {
                if(arr[i] + arr[j] + arr[k] > sum)
                {
                    k--;
                }
                else
                {
                    answer += k - j;
                    j++;
                }
            }
            return answer;
        }
        public int LongestSequence(int [] arr)
        {
            int i = 0;
            int count = 1;
            int seq = int.MinValue;
            BubbleSort(ref arr);
            while(i < arr.Length - 1)
            {
                if (count > seq)
                {
                    seq = count;
                }
                if (arr[i] +1 != arr[i + 1])
                {
                    count = 1;
                }
                if (arr[i] + 1 == arr[i + 1])
                    count++;
                i++;
            }
            return seq;
        }
        public int [] BubbleSort(ref int [] arr)
        {
            bool flag = true;
            for (int i = 0; i < arr.Length -1 && flag; i++)
            {
                flag = false;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                        flag = true;
                    }

                }
            }
            return arr;
        }

    }
    
}
