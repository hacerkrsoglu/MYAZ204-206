using System.Collections;

namespace Array
{
    public class Array : IEnumerable
    {
        private Object[] _InnerArray;//? işsatei koyarak null değer alabiliceğini kabul ediyorum
        private int index = 0;
        public int Count => index; //dizide kaç eleman var 
        public int Capacity => _InnerArray.Length;


        public Array()
        {
            _InnerArray = new Object[4];//Block Allocation blok olarak yer ayırır
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
            var item = GetItem(position);
            if (item != null)
            {
                _InnerArray[position] = null;
                return item;
            }
            return -1;
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
    }

}