using System;
using System.Collections;

namespace DZ_6_2
{
    class MyStack : ICollection, IEnumerable
    {
        object[] contents;
        int count = 0;
        public int Count
        {
            get { return count; }
        }

        public MyStack(int count= 10)
        {
            if (count <= 0) count = 10;
            contents = new object[count];
        }
        public void Push(object value)
        {
            if (count < contents.Length)
                contents[count++] = value;
            else
                throw new StackOverflowException();
        }
        public object Peek()
        {
            if (count > 0)
                return contents[count - 1];
            else
                throw new InvalidOperationException();
        }
        public void Pop()
        {
            if (count > 0)
                --count;
            else
                throw new InvalidOperationException();
        }
        public int Length
        {
            get { return contents.Length; }
        }

        public bool IsSynchronized
        {
            get { return false; }
        }

        public object SyncRoot
        {
            get { return this; }
        }

        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
                array.SetValue(contents[i], j++);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new MyStackEnumerator(contents, count);
        }
    }
}
