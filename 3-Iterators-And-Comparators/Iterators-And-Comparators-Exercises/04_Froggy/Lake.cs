namespace _04_Froggy
{
    using System.Collections;
    using System.Collections.Generic;

    public class Lake<T> : IEnumerable<T>
    {
        private readonly IList<T> stones;

        public Lake(List<T> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Count; i += 2)
            {
                yield return this.stones[i];
            }

            if (this.stones.Count % 2 == 0)
            {
                for (int i = this.stones.Count - 1; i >= 0; i -= 2)
                {
                    yield return this.stones[i];
                }
            }
            else
            {
                for (int i = this.stones.Count - 2; i >= 0; i -= 2)
                {
                    yield return this.stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
