using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue.Contracts
{
    public interface IQueue<T>
    {
        void EnQueue(T item);
        int Count { get; }
        T DeQueue();
        T Peek();
    }
}
