namespace _09_Custom_List_Sorter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sorter<T>
        where T : IComparable<T>
    {
        public static CustomList<T> Sort(CustomList<T> customList)
        {
            List<T> sortedList = customList.GetList().OrderBy(i => i).ToList();
            return new CustomList<T>(sortedList);
        }
    }
}
