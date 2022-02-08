using System;
using System.Linq;
using System.Text;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array Methods
            //int[] arr1 = { 1,23,35};
            //arr1[0] = 54;

            //int[] arr2 = new int[] { 46,3};
            //arr2[1] = 7;

            //int[] arr3 = new int[5];

            //arr3[1] = 5;
            //arr3[0] = 7;
            //arr3[2] = 7;
            //arr3[3] = 7;
            //arr3[4] = 7;

            //int max = arr1.Max();
            //int min = arr1.Min();

            //Console.WriteLine(max);
            //Console.WriteLine(min);
            //Console.WriteLine(arr1.Sum());

            //foreach (int item in arr1.Reverse())
            //{
            //    Console.WriteLine(item);
            //}

            //Array.Sort(arr1);

            //foreach (int item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            //string[] words = { "Hello", "Word" };
            #endregion

            #region String Builder
            //string text = ReverseStr("Salam").ToString();
            //Console.WriteLine(text);
            #endregion

            #region Task - 1
            //String Tipinde Data Qebul Edib Stringi Tersine Ceviren String Seklinde Qaytaran Method Yaz
            //misal: Salam Qrup Uzvler >> malaS-purQ-relvzU;

            Console.WriteLine(fun("Salam Qrup Uzvler").ToString());
            #endregion
        }

        #region String Builder
        //static StringBuilder ReverseStr(string str)
        //{
        //    StringBuilder result = new StringBuilder();

        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        result.Append(str[i]);
        //    }

        //    return result;
        //}

        //static string ReverseStr(string str)
        //{
        //    string result = "";

        //    for (int i = str.Length-1; i > 0; i--)
        //    {
        //        result += str[i];
        //    }

        //    return result;
        //}
        #endregion

        #region Task - 1
        //String Tipinde Data Qebul Edib Stringi Tersine Ceviren String Seklinde Qaytaran Method Yaz
        //misal: Salam Qrup Uzvler >> malaS-purQ-relvzU;
        #endregion


        static StringBuilder fun(string s)
        {
            StringBuilder ret = new StringBuilder();

            string[] arr = s.Split(" ");

            for (int i = 0; i < arr.Length; i++)
            {
                for (int a = arr[i].Length - 1; a >= 0; a--)
                {
                    ret.Append(arr[i][a]);
                }

                if (i != arr.Length - 1)
                {
                    ret.Append("-");
                }
            }

            return ret;
        }
    }
}
