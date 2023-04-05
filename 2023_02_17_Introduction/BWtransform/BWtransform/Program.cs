namespace n2_BWtransform
{
    class BurrowsWheelerTransform
    {
        public static Tuple<string, int> Forward(string input)
        {

        }

        public static string Backward(string input, int index)
        {

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            string? input = Console.ReadLine();
            if (input == null)
            {
                Console.WriteLine("Error! Input string is empty.");
                return;
            }

            var forwardResult = BurrowsWheelerTransform.Forward(input);
            Console.WriteLine("Converted string: " + forwardResult.Item1);
            Console.WriteLine("End of string index: " + forwardResult.Item2);
            var backwardResult = BurrowsWheelerTransform.Backward(forwardResult.Item1, forwardResult.Item2);
            Console.WriteLine("Restored string: " + backwardResult);
            Console.WriteLine("The original string is restored: " + (input == backwardResult));
        }
    }




}