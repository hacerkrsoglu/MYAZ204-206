using Queue.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    public class Queue<T> : IQueue<T>
    {
        private IQueue<T> _queue;
        public Queue()
        {
            _queue= new LinkedListQueue<T>();
        }
        public Queue(IEnumerable<T> collection) : this()
        {
            foreach (var item in collection)
            {
                EnQueue(item);

            }
            
        }
        public int Count => _queue.Count;

        public T DeQueue()
        {
            return _queue.DeQueue();
        }

        public void EnQueue(T item)
        {
            _queue.EnQueue(item);
        }

        public T Peek()
        {
            return _queue.Peek();
        }
    }
}
