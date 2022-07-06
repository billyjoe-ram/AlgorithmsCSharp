namespace Algoritmos.Sorts
{
    public class SelectionSort : ISortAlgorithm
    {
        /// <summary>
        ///     Sorting method that searchs
        ///     for the closest smallest value
        ///     and SELECTS it to replace in
        ///     the current position;
        ///     
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public int[] Sort(int[] collection)
        {
            // Allocating temp variables outside iterations
            // to follow best practices
            int minValue;
            int minValueIndex;

            var sortedCollection = new int[collection.Length];

            collection.CopyTo(sortedCollection, 0);

            // Iterates the collection to sort
            for (int i = 0; i < sortedCollection.Length; i++)
            {
                minValueIndex = i;

                // Iterates the collection to find the closest
                // smallest value and select it
                for (int j = i + 1; j < sortedCollection.Length; j++)
                {
                    if (sortedCollection[j] < sortedCollection[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }

                minValue = sortedCollection[minValueIndex];
                sortedCollection[minValueIndex] = sortedCollection[i];
                sortedCollection[i] = minValue;
            }

            return sortedCollection;
        }
    }
}
