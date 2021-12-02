using System;

namespace Lab63
{
    public class Program
    {
       public static int CountOfOdd(int[] arr)
        {
            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    result++;
                }
            }

            return result;
        }
       public static void Main(string[] args)
        {
            int[] array = new int[20];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-20, 34);
                Console.WriteLine(array[i] + "\t");
            }

            Console.WriteLine("Result = " + CountOfOdd(array));
        }
    }
}
