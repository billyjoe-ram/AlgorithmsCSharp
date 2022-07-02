namespace Algoritmos.Searchs
{
    internal class LinearSearch : ISearchAlgorithm
    {
        public int Search(int value, int[] collection)
        {
            int indexFound = -1;

            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] != value)
                {
                    continue;
                }

                indexFound = i;
            }

            return indexFound;
        }
    }
}
