using System;
using System.Collections;

namespace DZ_6
{
    public class IntList : ICollection
    {
        private int[] contents = new int[10];
        private int count;
        public IntList()
        { count = 0; }
        public int Count
        { get { return count; } }
        public int Length
        { get { return contents.Length; } }
        private void UpSize()
        {
            int[] tmp = new int[contents.Length * 2];
            Array.Copy(contents, tmp, contents.Length);
            contents = tmp;
        }
        #region IList members
        public int Add(int value)
        {
            if (count == contents.Length)
                UpSize();
            contents[count] = value;
            count++;
            return (count - 1);
        }
        public void Clear()
        { count = 0; }
        public bool Contains(int value)
        {
            bool inList = false;
            for (int i = 0; i < Count; i++)
            {
                if (contents[i] == value)
                {
                    inList = true;
                    break;
                }
            }
            return inList;
        }
        public int IndexOf(int value)
        {
            int itemIndex = -1;
            for (int i = 0; i < Count; i++)
            {
                if (contents[i] == value)
                {
                    itemIndex = i;
                    break;
                }
            }
            return itemIndex;
        }
        public void Insert(int index, int value)
        {
            if ((index < Count) && (index >= 0))
            {
                if (count == contents.Length)
                    UpSize();
                count++;
                for (int i = Count - 1; i > index; i--)
                    contents[i] = contents[i - 1];
                contents[index] = value;
            }
        }
        public void Remove(int value)
        { RemoveAt(IndexOf(value)); }
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                    contents[i] = contents[i + 1];
                count--;
            }
        }
        public int this[int index]
        {
            get { return contents[index]; }
            set { contents[index] = value; }
        }
        public void CopyTo(Array array, int index)
        {
            int j = index;
            for (int i = 0; i < Count; i++)
                array.SetValue(contents[i], j++);
        }
        public object SyncRoot { get { return this; } }
        #endregion
        IEnumerator IEnumerable.GetEnumerator()
        { return GetEnumerator(); }
        public IntListEnum GetEnumerator()
        {
            int[] tmp = new int[Count];
            Array.Copy(contents, tmp, Count);
            return new IntListEnum(tmp);
        }
        public bool IsSynchronized
        { get { return false; } }
    }
}
