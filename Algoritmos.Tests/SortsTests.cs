using Xunit;

using Algoritmos.Sorts;

namespace Algoritmos.Tests
{
    public class SortsTests
    {
        private readonly int[] _toSortArray;
        private readonly int[] _arraySortedCorrectly;

        public SortsTests()
        {
            _toSortArray = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            _arraySortedCorrectly = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        }

        [Fact(DisplayName = "Bubble Sort algorithm")]
        [Trait("Sorts", "Bubble")]
        public void TestBubbleSort()
        {
            var sortMethod = new BubbleSort();

            var sortedArray = sortMethod.Sort(_toSortArray);

            Assert.Equal(_arraySortedCorrectly, sortedArray);
        }

        [Fact(DisplayName = "Selection Sort algorithm")]
        [Trait("Sorts", "Selection")]
        public void TestSelectionSort()
        {
            var sortMethod = new SelectionSort();

            var sortedArray = sortMethod.Sort(_toSortArray);

            Assert.Equal(_arraySortedCorrectly, sortedArray);
        }

        [Fact(DisplayName = "Quick Sort algorithm")]
        [Trait("Sorts", "Quick")]
        public void TestQuick()
        {
            var sortMethod = new QuickSort();

            var sortedArray = sortMethod.Sort(_toSortArray);

            Assert.Equal(_arraySortedCorrectly, sortedArray);
        }
    }
}