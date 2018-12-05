using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeeksWorkingStrings_Arrays
{
    class Program 
    {
        static void Main(string[] args)
        {
            string arr = "Hello.my.name.is.joe";
            ArrayWork array = new ArrayWork();
            array.StringReverse(arr);
            


        }

    }
    class StringWork
    {
        public static string SwapString(string str)
        {
            char[] a = str.ToCharArray();
            int i = 0;
            int l = a.Length - 1;

            while (i < l)
            {
                if (!char.IsLetter(a[i]))
                    i++;
                if (!char.IsLetter(a[l]))
                    l--;
                else
                {
                    char temp = a[i];
                    a[i] = a[l];
                    a[l] = temp;
                    i++;
                    l--;
                }
            }
            string reply = new string(a);
            return reply;
        }
        public static bool IsPalindrome(string arr)
        {
            int lag = 0;
            int lead = arr.Length - 1;
            while (lag < lead)
            {
                if (arr[lag] != arr[lead])
                {
                    return false;
                }
                lag++;
                lead--;
            }
            return true;
        }
        public static void SubPalindromes(string str)
        {
            List<string> list = new List<string>();
            int pos = 0;
            int length = str.Length;
            while (pos < str.Length)
            {
                if (IsPalindrome(str.Substring(pos, length)))
                {
                    list.Add(str.Substring(pos, length));
                }
                if (length==1)
                {
                    pos++;
                    length = str.Length - pos;
                }
                else
                    length--;
            }
            PrintListInLengthOrder(list);
        }
        public static void PrintListInLengthOrder(List<string> list)
        {
            bool swapped = true;
            for (int i = 0; i < list.Count - 1 && swapped; i++)
            {
                swapped = false;
                for (int j = 0; j < list.Count; j++)
                {
                    if(list[i].Length > list[j].Length)
                    {
                        string temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                        swapped = true;
                    }
                }
            }
            foreach(var item in list)
            {
                if (item.Length == 1)
                {
                    Console.Write(item + " ");
                }
                else
                {
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
        }
    }
}
