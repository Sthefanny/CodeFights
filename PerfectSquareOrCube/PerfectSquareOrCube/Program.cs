using System;
using System.Collections.Generic;
using System.Linq;

namespace PerfectSquareOrCube
{
    public class Program
    {
        static void Main()
        {
            do
            {
                Console.WriteLine("\n---------------------------------------------------------------");
                Console.WriteLine("Choose a number to find how many perfect square or cube it has:");
                var digit = Console.ReadLine();
                var number = Convert.ToInt32(digit);
                var result = PerfectSquareOrCube(number);
                Console.WriteLine("The result is: " + result);
                Console.WriteLine("\nGo again? (Y/N) ");
            } while (Console.ReadKey().Key != ConsoleKey.N);
        }

        public static int PerfectSquareOrCube(int number)
        {
            var count = 0;
            var numberList = new List<int>();

            var arr = IntToArray(number);

            Permut(arr, 0, arr.Length - 1, ref count, ref numberList);

            return count;
        }

        static void Permut(int[] list, int k, int m, ref int count, ref List<int> numberList)
        {
            int i;
            if (k == m)
            {
                var arr = ArrayToInt(list);
                if (numberList.All(item => item != arr))
                {
                    numberList.Add(ArrayToInt(list));
                    GetCounts(ArrayToInt(list), ref count);
                }
            }
            for (i = k; i <= m; i++)
            {
                SwapTwoNumber(ref list[k], ref list[i]);
                Permut(list, k + 1, m, ref count, ref numberList);
                SwapTwoNumber(ref list[k], ref list[i]);
            }
        }

        static int[] IntToArray(int number)
        {
            var input = number.ToString();
            var arr = new int[input.Length];
            for (var i = 0; i < input.Length; i++)
            {
                arr[i] = Convert.ToInt32(input[i].ToString());
            }

            return arr;
        }

        static int ArrayToInt(int[] arr)
        {
            var numberString = string.Empty;

            for (var i = 0; i < arr.Length; i++)
            {
                numberString += arr[i];
            }

            return Convert.ToInt32(numberString);
        }

        static void SwapTwoNumber(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void GetCounts(int number, ref int count)
        {
            var temp = count;
            FindDouble(number, ref count);
            if (temp == count)
            {
                FindCube(number, ref count);
            }
        }

        static void FindDouble(int number, ref int count)
        {
            var result = 0;
            var i = 1;
            do
            {
                result = i * i;
                if (result == number)
                {
                    count++;
                    break;
                }

                i++;
            } while (result <= number);
        }

        static void FindCube(int number, ref int count)
        {
            var result = 0;
            var i = 1;
            do
            {
                result = i * i * i;
                if (result == number)
                {
                    count++;
                    break;
                }

                i++;
            } while (result <= number);
        }
    }
}
