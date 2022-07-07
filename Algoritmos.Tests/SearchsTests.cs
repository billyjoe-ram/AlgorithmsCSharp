using Xunit;
using System;

using Algoritmos.Sorts;
using Algoritmos.Searchs;

namespace Algoritmos.Tests
{
    public class SearchsTests
    {
        private readonly int _chosenNumber = 100;
        private readonly int[] _numbersArray = new int[10];

        public SearchsTests()
        {
            var random = new Random();

            for (int i = 0; i < 9; i++)
            {
                _numbersArray[i] = random.Next(0, 100);
            }

            _numbersArray[^1] = _chosenNumber;
        }

        [Trait("Searchs", "Linear")]
        [Fact(DisplayName = "Linear search finding")]
        public void TestLinearSearch()
        {
            var searchMethod = new BinarySearch();

            var sortedArray = new QuickSort().Sort(_numbersArray);

            int index = searchMethod.Search(_chosenNumber, sortedArray);

            Assert.NotEqual(9, index);
        }

        [Trait("Searchs", "Linear")]
        [Fact(DisplayName = "Linear search not finding")]
        public void TestLinearSearchElementNotFound()
        {
            var searchMethod = new BinarySearch();

            var sortedArray = new QuickSort().Sort(_numbersArray);

            int index = searchMethod.Search(101, _numbersArray);

            Assert.Equal(-1, index);
        }

        [Trait("Searchs", "Binary")]
        [Fact(DisplayName = "Binary search finding")]
        public void TestBinarySearch()
        {
            var searchMethod = new BinarySearch();

            var sortedArray = new QuickSort().Sort(_numbersArray);

            int index = searchMethod.Search(_chosenNumber, sortedArray);

            Assert.NotEqual(9, index);
        }

        [Trait("Searchs", "Binary")]
        [Fact(DisplayName = "Binary search not finding")]
        public void TestBinarySearchElementNotFound()
        {
            var searchMethod = new BinarySearch();

            var sortedArray = new QuickSort().Sort(_numbersArray);

            int index = searchMethod.Search(101, _numbersArray);

            Assert.Equal(-1, index);
        }
    }
}
