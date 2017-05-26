using System;
using System.Collections;

namespace DZ_6_2
{
    class MyStackEnumerator : IEnumerator
    {
        object[] contents;
        int pos = -1;
        int last;
        public MyStackEnumerator(object[] contents, int last)
        {
            this.contents = contents;
            if (last > 0)
                this.last = last;
            else
                this.last = contents.Length;
        }
        object IEnumerator.Current
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
        bool IEnumerator.MoveNext()
        {
            ++pos;
            return (pos < last);
        }
        void IEnumerator.Reset()
        {
            pos = -1;
        }
    }
}
