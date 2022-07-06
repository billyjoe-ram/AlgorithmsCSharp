namespace Algoritmos.Searchs
{
    public class BinarySearch : ISearchAlgorithm
    {
        public int Search(int value, int[] collection)
        {
            int startIndex = 0;
            int endIndex = collection.Length - 1;

            return RecursiveSearch(value, collection, startIndex, endIndex);
        }

        private int RecursiveSearch(int value, int[] collection, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
            {
                return -1;
            }

            int middleIndex = (startIndex + endIndex) / 2;

            if (collection[middleIndex] == value)
            {
                return middleIndex;
            }

            if (value < collection[middleIndex])
            {
                return RecursiveSearch(value, collection, startIndex, middleIndex - 1);
            }

            return RecursiveSearch(value, collection, middleIndex + 1, endIndex);
        }
    }
}
