namespace Algoritmos.Sorts
{
    internal class SelectionSort : ISortAlgorithm
    {
        /// <summary>
        ///     Sorting method that searchs
        ///     for the closest smallest value
        ///     and SELECTS it to replace in
        ///     the current position;
        ///     
        ///     "O(n²)" (quadratic) time complexity
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        public int[] Sort(int[] collection)
        {
            // Allocating temp variables outside iterations
            // to follow best practices
            int minValue;
            int minValueIndex;

            // Iterates the collection to sort
            for (int i = 0; i < collection.Length; i++)
            {
                minValueIndex = i;

                // Iterates the collection to find the closest
                // smallest value and select it
                for (int j = i + 1; j < collection.Length; j++)
                {
                    if (collection[j] < collection[minValueIndex])
                    {
                        minValueIndex = j;
                    }
                }

                minValue = collection[minValueIndex];
                collection[minValueIndex] = collection[i];
                collection[i] = minValue;
            }

            return collection;
        }
    }
}
