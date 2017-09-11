namespace _04_Book_Comparator
{
    using System.Collections.Generic;

    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            if (firstBook.Title != secondBook.Title)
            {
                return firstBook.Title.CompareTo(secondBook.Title);
            }

            return secondBook.Year.CompareTo(firstBook.Year);
        }
    }
}
