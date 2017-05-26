using System;
using System.Collections;

namespace DZ_6
{
    public class IntListEnum : IEnumerator
    {
        public int[] contents;
        int pos = -1;
        public IntListEnum(int[] contents)
        {
            this.contents = contents;
        }
        object IEnumerator.Current
        { get { return Current; } }
        public int Current
        {
            get
            {
                try
                {
                    return contents[pos];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
        public bool MoveNext()
        {
            ++pos;
            return (pos < contents.Length);
        }

        public void Reset()
        {
            pos = -1;
        }
    }
}
