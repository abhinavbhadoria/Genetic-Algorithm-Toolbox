using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    class Utility
    {
        public static string DecToBin(int number)
        {
                       int i = 0, k = 0, d, temp = number;
            int[] a;
            char[] ch;
            int l = CountMaxBits(DataStorage.UpperBound);
            a = new int[l];
            ch = new char[l];
            if (number < 0)
                number *= -1;
            while (number > 0)
            {
                a[i++] = number % 2;
                number /= 2;
            }
            if (i < l)
                for (k = 0; k < (l - i); k++)
                    ch[k] = '0';
            for (d = i - 1; d >= 0; d--)
                ch[k++] = (char)(a[d] + '0');
            if (temp < 0)
            {
                for (int p = 0; p < l; p++)
                {
                    if (ch[p] == '0')
                        ch[p] = '1';
                    else
                        ch[p] = '0';
                }
            }
            string ans = new string(ch);
            return ans;
        }

        public static int BinToDec(string str)
        {
            int a = 0, l, p;
            l = str.Length;
            for (int i = (l - 1); i >= 0; i--)
            {
                p = (int)(str[i] - '0');
                a += (p * (int)Math.Pow(2, ((l - 1) - i)));
            }
            return a;
        }

        public static int CountMaxBits(int upperlimit)
        {
            int l;
            l = (int)(Math.Ceiling(Math.Log(upperlimit, 2)));
            if ((upperlimit & (upperlimit - 1)) == 0)
                l++;
            return l;
        }

        public static int GetSum(int[,] arr, int rowIndex)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
                sum += arr[rowIndex,i];
            return sum;
        }

        public static double GetSum(double[,] arr, int rowIndex)
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
                sum += arr[rowIndex, i];
            return Math.Round(sum, 2);
        }

        public static int GetAvg(int[,] arr, int rowIndex)
        {
            int sum = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
                sum += arr[rowIndex, i];
            return (int)sum / arr.GetLength(1);
        }

        public static double GetAvg(double[,] arr, int rowIndex)
        {
            double sum = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
                sum += arr[rowIndex, i];
            return Math.Round((double)sum / arr.GetLength(1), 2);
        }

        public static int GetMax(int[,] arr, int rowIndex)
        {
            int max = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
                max = Math.Max(max, arr[rowIndex, i]);
            return max;
        }

        public static double GetMax(double[,] arr, int rowIndex)
        {
            double max = 0;
            for (int i = 0; i < arr.GetLength(1); i++)
                max = Math.Max(max, arr[rowIndex, i]);
            return Math.Round( max, 2);
        }
    }
}
