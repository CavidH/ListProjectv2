using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ListLib
{
    public class MyList<T>
    {
         
        private T[] _data;
        private int _index = 0;
        private int _capacityIncLvl = 2;//her defe yeni list yaradilinda capacity  3 defe artacaq
        #region Indexer
           public T this[int index]
        {
            get { return _data[index]; }
            set { _data[index] = value; }
        }
        #endregion
        #region Constructor
        public MyList()
        {
            _data = new T[1];
        }
        public MyList(int capacity)
        {
            _data = new T[capacity];
        }
        #endregion
        #region Add
        /// <summary>
        /// elementi liste leave edir
        /// </summary>
        /// <param name="item"></param>
        public void Add(T item)
        {
            if (_index == _data.Length)
            {
                ListCreator();
            }
            _data[_index] = item;
            _index++;
        }
        #endregion
        #region AddRange
        /// <summary>
        /// massivi liste elave edir
        /// </summary>
        /// <param name="arr"></param>
        public void AddRange(T[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Add(arr[i]);
            }
        }
        #endregion
        #region Clear
        /// <summary>
        /// listi temizleyir
        /// </summary>
        public void Clear()
        {
            _data = _data = new T[0];
        }
        #endregion
        #region ListCreator
        /// <summary>
        /// daxili list yaradan
        /// </summary>
        private void ListCreator()
        {
            T[] NewList = new T[_data.Length * _capacityIncLvl];
            _data = ListCopyist(NewList, _data);// yeni gelen list dataya menimsedildi
        }
        #endregion
        #region ListCopyist 
        /// <summary>
        /// daxili list copy eden
        /// </summary>
        /// <param name="NewList"></param>
        /// <param name="_data"></param>
        /// <returns>T[]</returns>
        private T[] ListCopyist(T[] NewList, T[] _data)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                NewList[i] = _data[i];
            }
            return NewList;
        }
        #endregion
        #region IndexOf
        /// <summary>
        /// elementin hansi indexde oldugun gosterir
        /// </summary>
        /// <param name="item"></param>
        /// <returns>
        /// eyer element varsa indexin yoxsa -1
        /// </returns>
        public int IndexOf(int item)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (item.Equals(_data[i]))
                {
                    return i;
                }

            }
            return -1;
        }
        /// <summary>
        /// elementin gosterilen indexde olub olmadigin yoxlayir
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns>elementin indexin eger element listde yoxdusa -1</returns>
        public int IndexOf(int item,int index)
        {
            if (item.Equals(_data[index]))
            {
                return index;
            }
            return -1;
        }
        #endregion
        #region LastIndexOf
        /// <summary>
        /// elementin hansi indexde oldugun gosterir
        /// sondan baslayir
        /// </summary>
        /// <param name="item"></param>
        /// <returns>
        /// eyer element varsa indexin yoxsa -1
        /// </returns>
        public int LastIndexOf(T item)
        {
            for (int i = _data.Length - 1; i >= 0; i--)
            {
                if (item.Equals(_data[i]))
                {
                    return i;
                }

            }
            return -1;
        }
        /// <summary>
        /// elementin gosterilen indexde olub olmadigin yoxlayir sondan baslayaraq
        /// </summary>
        /// <param name="item"></param>
        /// <param name="index"></param>
        /// <returns>elementin indexin eger element listde yoxdusa -1</returns>
        public int LastIndexOf(int item, int index)
        {
            if (item.Equals(_data[index]))
            {
                return index;
            }
            return -1;
        }
        #endregion
        #region Remove
        /// <summary>
        /// elementi listden silir
        /// </summary>
        /// <param name="item"></param>
        public void Remove(T item)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (item.Equals(_data[i]))
                {
                    _data[i] = default;
                }
            }
        }
        /// <summary>
        /// gosterilen indexde olan elementi silir
        /// </summary>
        /// <param name="index"></param>
        public void RemoveAt(int index)
        {
            _data[index] = default;
        }
        #endregion
        #region Reverse
        /// <summary>
        /// listi revers edir
        /// </summary>
        public void Reverse()
        {
           T[] RData = new T[_index];
            for (int i = _index - 1; i >= 0; i--)
            {
                RData[(_index-1)-i] = _data[i];
            }
            _data = RData;

        }
        #endregion
        #region Length
        /// <summary>
        /// listin uzunlugun verir
        /// </summary>
        /// <returns>lentgh of list</returns>
        public int GetLength()
        {
            return _index;
        }
        #endregion




    }
}
