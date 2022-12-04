using System;

namespace Algoritmos.Sorts
{
    public class InsertionSort : ISortAlgorithm
    {
        public int[] Sort(int[] collection)
        {
            var sortedCollection = new int[collection.Length];

            collection.CopyTo(sortedCollection, 0);
            
            int firstUnsortedElement, j;

            for (int i = 1; i <= sortedCollection.Length - 1; i++)
            {
                firstUnsortedElement = sortedCollection[i];
                j = i - 1;

                while (j >= 0 && sortedCollection[j] > firstUnsortedElement)
                {
                    sortedCollection[j + 1] = sortedCollection[j];

                    j--;
                }

                sortedCollection[j + 1] = firstUnsortedElement;
            }            

            return sortedCollection;
        }        

    }
}
