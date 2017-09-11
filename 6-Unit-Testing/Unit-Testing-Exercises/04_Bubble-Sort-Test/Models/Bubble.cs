namespace _04_Bubble_Sort_Test.Models
{
    using Contracts;
    using System;
    using System.Collections.Generic;

    public class Bubble : IBubble
    {
        public IList<int> Sort(IList<int> collection)
        {
            if (collection == null)
            {
                throw new ArgumentNullException("Collection");
            }

            IList<int> temp = collection;
            bool hasSwap = true;

            while (hasSwap == true)
            {
                hasSwap = false;

                for (int i = 0; i < temp.Count - 1; i++)
                {
                    int firstElement = temp[i];
                    int secondElement = temp[i + 1];

                    if (firstElement > secondElement)
                    {
                        int tempElement = firstElement;
                        temp[i] = secondElement;
                        temp[i + 1] = tempElement;
                        hasSwap = true;
                    }
                }
            }

            return temp;
        }
    }
}
