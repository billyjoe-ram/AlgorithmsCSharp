namespace Algoritmos.Sorts
{
    public class QuickSort : ISortAlgorithm
    {
        /// <summary>
        ///     A sorting method that set a pivot
        ///     in the collection and QUICK SORTS
        ///     smaller values to the left of this
        ///     pivot and greater values to the right
        ///     of the pivot, recursively replacing
        ///     this pivot to sort every section.
        ///     
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public int[] Sort(int[] collection)
        {
            var sortedCollection = new int[collection.Length];

            collection.CopyTo(sortedCollection, 0);

            RecursiveSort(sortedCollection, 0, sortedCollection.Length - 1);

            return sortedCollection;
        }

        private void RecursiveSort(int[] collection, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                // Index which the sorting stopped after left and right partition
                int pivotIndex = Partition(collection, startIndex, endIndex);

                // Sort left partition
                RecursiveSort(collection, startIndex, pivotIndex - 1);
                // Sort right partitin
                RecursiveSort(collection, pivotIndex + 1, endIndex);
            }
        }

        private int Partition(int[] collection, int startIndex, int endIndex)
        {
            int tempSwapVar;
            int valuesBetween = startIndex;

            for (int i = startIndex + 1; i <= endIndex; i++)
            {

                if (collection[i] < collection[startIndex])
                {
                    valuesBetween++;

                    tempSwapVar = collection[i];
                    collection[i] = collection[valuesBetween];
                    collection[valuesBetween] = tempSwapVar;
                }
            }

            tempSwapVar = collection[startIndex];
            collection[startIndex] = collection[valuesBetween];
            collection[valuesBetween] = tempSwapVar;

            return valuesBetween;
        }

    }
}
