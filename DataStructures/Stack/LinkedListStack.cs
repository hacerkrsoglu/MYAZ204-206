using LinkedList.Singly;
using Stack.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class LinkedListStack<T> : IStack<T>
    {

        private SinglyLinkedList<T> _innerList;// = new SinglyLinkedList<T>(); constructor oluşturmazsak böyle


        public LinkedListStack()
        {
            _innerList = new SinglyLinkedList<T>();
        }

        public int Count => _innerList.Count; //bağlı listede count özelliğine bakılarak implemente edeceğiz.
        //=> readonly ifade demek
        public T Peek()//e bştaki eleman neyse onu gösterir.
        {
            return _innerList.Head is null
                ? default(T)
                : _innerList.Head.Value;

        }

        public T Pop()
        {
            if (_innerList.Head is null)
                throw new Exception("Underflow! Stack is empty!");
            return _innerList.RemoveFirst();
        }

        public void Push(T item)
        {
            _innerList.AddFirst(item);
        }
    }
}
