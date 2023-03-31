using System.Collections;

namespace Array
{
    public class Array : IEnumerable
    {
        private Object[] _InnerArray;//? işsatei koyarak null değer alabiliceğini kabul ediyorum
        private int index = 0;
        public int Count => index; //dizide kaç eleman var 
        public int Capacity => _InnerArray.Length; //lambda readonly ifade anlaına gelir dışarda başka bir sınıfta değer değiştirmesi yapılmaz


        public Array()
        {
            _InnerArray = new Object[4];//Block Allocation blok olarak yer ayırır
        }
        public Array(params Object[] init)
        {
            var newArray = new Object[init.Length];
            System.Array.Copy(init, newArray, init.Length);
            _InnerArray = newArray;
        }
        public void Add(Object item)
        {
            if (index == _InnerArray.Length)
            {
                DoubleArray(_InnerArray);
            }
            _InnerArray[index] = item;
            index++;

        }

        private void DoubleArray(object[] array)
        {
            var newArray = new Object[array.Length * 2];
            System.Array.Copy(array, newArray, array.Length);
            _InnerArray = newArray;
        }
        public Object GetItem(int position)
        {
            // throw new NotImplementedException();
            if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            return _InnerArray[position];
        }
        public void SetItem(int position, Object item)
        {
            if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            _InnerArray[position] = item;

        }

        public Object Remove()
        {
            if (index == 0)
                throw new Exception("Out of index!");
            if (index == _InnerArray.Length / 2)
                throw new NotImplementedException();
            var temp = _InnerArray[index - 1];
            _InnerArray[index - 1] = null;
            index--;
            return temp;
        }
        public Object RemoveItem(int position)
        {
            // throw new NotImplementedException();
            if (position < 0 || position >= _InnerArray.Length)
                throw new IndexOutOfRangeException();
            var item = _InnerArray[position];
            _InnerArray[position] = null;
            for (int i = 0; i < _InnerArray.Length - 1; i++)
            {
                Swap(i, i + 1);
            }
            index--;
            if (index == _InnerArray.Length / 2)
            {
                var newArray = new Object[_InnerArray.Length / 2];
                System.Array.Copy(_InnerArray, newArray, newArray.Length);
                _InnerArray = newArray;

            }
            return item;
        }
        public void Swap(int p1, int p2)
        {
            var temp = _InnerArray[p1];
            _InnerArray[p1] = _InnerArray[p2];
            _InnerArray[p2] = temp;
        }

        public int Find(Object item)
        {
            for(int i = 0; i< _InnerArray.Length; i++)
            {
                if(item.Equals(_InnerArray[i]))
                {
                    return i;
                }
            }
            return -1;

        }

        public IEnumerator GetEnumerator()
        {
            return _InnerArray.GetEnumerator();
        }
        public object[] Copy(int v1, int v2)//v1 dahil v2 dahil değil
        {
            var newArray = new object[_InnerArray.Length];
            int j = 0;
            for (int i = v1; i < v2; i++)
            {
                newArray[j] = _InnerArray[i];
                j++;

            }
            return newArray;
        }
    }

}