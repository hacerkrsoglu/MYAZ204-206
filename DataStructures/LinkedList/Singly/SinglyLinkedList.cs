using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Singly
{
    public class SinglyLinkedList<T>
    {
        public SinglyLinkedListNode<T>? Head { get; set; }
        //bağlı listenin başına eleman ekler
        public SinglyLinkedList()
        {

        }
        public void AddFirst(T item)
        {
            //düğüm oluşturman gerekir.
            var node = new SinglyLinkedListNode<T>()
            {
                Value = item
            };
            //Head boş mu? hiçç bu elemanda eleman var mı?
            if(Head != null)
            {
                Head = node;
                return;
            }
            node.Next = Head;
            Head = node;
            return;
        }
        // bağlı listenin sonuna eleman ekler.
        public void AddLast(T item)
        {
            // T ifadesini düğüme çevir
            var node = new SinglyLinkedListNode<T>(item);

            // Head kontrol et
            if (Head is null)
            {
                Head = node;
                return;
            }

            // Son elemana kadar git
            var current = Head;
            var prev = current;
            while (current != null)
            {
                prev = current;
                current = current.Next;
            }
            prev.Next = node;
            return;

        }
        public void AddBefore(SinglyLinkedListNode<T> node, T item)
        {
            if (Head is null)
            {
                AddFirst(item);
                return;
            }

            var newNode = new SinglyLinkedListNode<T>(item);

            var current = Head;
            var prev = current;

            while (current is not null)
            {
                if (current.Equals(node))
                {
                    newNode.Next = prev.Next;
                    prev.Next = newNode;
                    return;
                }
                prev = current;
                current = current.Next;
            }
            throw new Exception("The node could not be found int the linked list.");
        }


    }
}
