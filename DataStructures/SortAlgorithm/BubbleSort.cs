using System;

namespace SortAlgorithm
{
    public static class BubbleSort<T> where T : IComparable<T>
    {

        public static void Sort(T[] list)
        {

            bool isSorted = true;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < list.Length - i - 1; j++)
                {
                    if (list[j].CompareTo(list[j + 1]) > 0)
                    {
                        Swap(ref list[j], ref list[j + 1]);
                        isSorted = false;
                    }   
                        


                }
                if (isSorted == true)
                {
                    break;
                }

            }
                
                   
        }
        private  static void Swap(ref T value, ref T value2)
        {
            var temp = value;
            value = value2;
            value2 = temp;
        }

    }
}