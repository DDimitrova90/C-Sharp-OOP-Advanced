namespace _02_Library_Iterator
{
    using System.Collections;
    using System.Collections.Generic;

    public class Library : IEnumerable<Book>
    {
        private IList<Book> books;

        public Library(params Book[] books)
        {
            this.books = books;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);

            // OR:
            //for (int i = 0; i < this.books.Count; i++)
            //{
            //    yield return this.books[i];
            //}
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private int currentIndex;
            private readonly IList<Book> books;

            public LibraryIterator(IList<Book> books) // or IEnumerable<Book> books
            {
                this.Reset();
                this.books = new List<Book>(books);
            }

            public Book Current
            {
                get
                {
                    return this.books[this.currentIndex];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    return this.Current;
                }
            }

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                this.currentIndex++;
                return this.currentIndex < this.books.Count;
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }
    }
}
