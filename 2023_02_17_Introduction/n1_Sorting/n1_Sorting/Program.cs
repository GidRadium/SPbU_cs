namespace Program
{
    /// <summary>
    /// First homework.
    /// </summary>
    public class Sorting
    {
        /// <summary>
        /// Program start point.
        /// </summary>
        static void Main()
        {
            Console.WriteLine("Enter numbers separated by spaces:");
            string input = Console.ReadLine() ?? throw new Exception();
            int[] array = input.Split(' ').Select(int.Parse).ToArray();

            BubbleSort(array);

            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }

        /// <summary>
        /// Sorts int[]. O(n^2)
        /// </summary>
        /// <param name="array">Array to sort.</param>
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }
    }
}
