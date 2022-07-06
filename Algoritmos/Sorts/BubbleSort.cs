namespace Algoritmos.Sorts
{
    public class BubbleSort : ISortAlgorithm
    {
        /// <summary>
        ///     Sorting method that compares the current
        ///     element of the iteration with its next
        ///     and BUBBLES it up to the end of the
        ///     collection.
        ///     
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public int[] Sort(int[] collection)
        {
            var sortedCollection = new int[collection.Length];

            collection.CopyTo(sortedCollection, 0);

            // Iteration must stop before value is equal to the length
            // of the collection, because we want to analise
            // an element at each index
            for (int i = 0; i < sortedCollection.Length; i++)
            {
                // The second iteration must stop before the last
                // element, because there would be no next to compare
                for (int j = 0; j < sortedCollection.Length - 1; j++)
                {
                    if (sortedCollection[j] > sortedCollection[j + 1])
                    {
                        int tempSwapValue;

                        tempSwapValue = sortedCollection[j];
                        sortedCollection[j] = sortedCollection[j + 1];
                        sortedCollection[j + 1] = tempSwapValue;
                    }
                }
            }

            return sortedCollection;
        }
    }
}
