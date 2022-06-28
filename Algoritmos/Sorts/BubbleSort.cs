namespace Algoritmos.Sorts
{
    internal class BubbleSort : ISortAlgorithm
    {
        /// <summary>
        ///     Sorting method that compares the current
        ///     element of the iteration with its next
        ///     and BUBBLES it up to the end of the
        ///     collection.
        ///     Efficient for smalll collections.
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public int[] Sort(int[] collection)
        {
            // Iteration must stop before value is equal to the length
            // of the collection, because we want to analise
            // an element at each index
            for (int i = 0; i < collection.Length; i++)
            {
                // The second iteration must stop before the last
                // element, because there would be no next to compare
                for (int j = 0; j < collection.Length - 1; j++)
                {
                    if (collection[j] > collection[j + 1])
                    {
                        int tempSwapValue;

                        tempSwapValue = collection[j];
                        collection[j] = collection[j + 1];
                        collection[j + 1] = tempSwapValue;
                    }
                }
            }

            return collection;
        }
    }
}
