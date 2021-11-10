using System;

namespace ListLib
{
    public class MyList<T>
    {
        private T[] _data;
        private int _index;
        private int _capacityIncLvl = 2;//her defe yeni list yaradilinda capacity  3 defe artacaq
        public T this[int index] { get { return _data[index]; } set { _data[index] = value; } }
        public MyList()
        {

            _data = new T[1];
            _index = 0;
        }
        public void Add(T item)
        {
            if (_index==_data.Length)
            {
                ListCreator();
            }
            _data[_index] = item;
            _index++;
        }
        private void ListCreator()
        {

        }
        }
}
