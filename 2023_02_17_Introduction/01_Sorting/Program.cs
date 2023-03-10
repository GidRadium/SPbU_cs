using System;

class BubbleSort
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers separated by spaces:");
        string input = Console.ReadLine() ?? throw new Exception();
        int[] arr = input.Split(' ').Select(int.Parse).ToArray();

        bubbleSort(arr);
        for (int i = 0; i < arr.Length; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }

    static void bubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}
