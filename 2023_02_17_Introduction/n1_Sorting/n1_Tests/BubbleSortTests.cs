namespace BubbleSortTests
{
    public class Tests
    {
        [Test]
        public void BubbleSort_SortsArrayInAscendingOrder()
        {
            int[] array = { 5, 2, 8, 4, 1 };
            int[] expected = { 1, 2, 4, 5, 8 };

            Program.Sorting.BubbleSort(array);

            Assert.That(array, Is.EqualTo(expected));
        }

        [Test]
        public void BubbleSort_DoesNotChangeAlreadySortedArray()
        {
            int[] array = { 1, 2, 4, 5, 8 };
            int[] expected = { 1, 2, 4, 5, 8 };

            Program.Sorting.BubbleSort(array);

            Assert.That(array, Is.EqualTo(expected));
        }

        [Test]
        public void BubbleSort_SortsArrayWithNegativeNumbers()
        {
            int[] array = { -5, 2, -8, 4, -1 };
            int[] expected = { -8, -5, -1, 2, 4 };

            Program.Sorting.BubbleSort(array);

            Assert.That(array, Is.EqualTo(expected));
        }

        [Test]
        public void BubbleSort_SortsArrayWithDuplicateNumbers()
        {
            int[] array = { 5, 2, 8, 4, 1, 2 };
            int[] expected = { 1, 2, 2, 4, 5, 8 };

            Program.Sorting.BubbleSort(array);

            Assert.That(array, Is.EqualTo(expected));
        }

        [Test]
        public void BubbleSort_SortsEmptyArray()
        {
            int[] array = new int[0];
            int[] expected = new int[0];

            Program.Sorting.BubbleSort(array);

            Assert.That(array, Is.EqualTo(expected));
        }
    }
}
