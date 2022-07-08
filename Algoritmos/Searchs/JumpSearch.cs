namespace Algoritmos.Searchs
{
    public class JumpSearch : ISearchAlgorithm
    {
        public int Search(int value, int[] collection)
        {
            int jumpFactor = (int) Math.Floor(Math.Sqrt(collection.Length));
            // Subtracting one to get the indexes starting in 0
            int searchIndex = jumpFactor - 1;

            int indexFound = -1;

            // Jumping to a search index in front of the searched value
            while (searchIndex < collection.Length && value > collection[searchIndex])
            {
                searchIndex += jumpFactor;
            }

            // Going back to search for the value from the closes index before
            searchIndex -= jumpFactor;

            for (int i = searchIndex; i < collection.Length; i++)
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
