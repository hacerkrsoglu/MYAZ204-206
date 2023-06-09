﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Singly
{
    public class SinglyLinkedList<T>: IEnumerable<T>
    {
        private int _count = 0;
        public SinglyLinkedListNode<T>? Head { get; set; } //auto imolemented propertty
        public int Count => _count;                                                   //bağlı listenin başına eleman ekler
        public SinglyLinkedList()
        {

        }
        public SinglyLinkedList(IEnumerable<T> collection)
        {
            foreach (var item in collection)
            {
                AddFirst(item); //o(1) başa ekleme daha hızlıdır.
            }

        }
        public void AddFirst(T item)
        {
            //düğüm oluşturman gerekir.
            var node = new SinglyLinkedListNode<T>()
            {
                Value = item
            };
            //Head boş mu? hiçç bu elemanda eleman var mı?
            if(Head is null)
            {
                Head = node;
                _count++;
                return;
            }
            node.Next = Head;
            Head = node;
            _count++;
            return;
        }  
        //bağlı listenin sonuna eleman ekler.
        public void AddLast(T item)
        {
            // T ifadesini düğüme çevir
            var node = new SinglyLinkedListNode<T>(item);

            // Head kontrol et
            if (Head is null)
            {
                Head = node;
                _count++;
                return;
            }

            // Son elemana kadar git //sonra eklemeyi yap
            var current = Head;
            var prev = current;//önceki eleman
            while (current != null)
            {
                prev = current;
                current = current.Next;
            }
            prev.Next = node;
            _count++;
            return;

        }
       // a - [b] - c   x -> c
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
                    _count++;
                    return;
                }
                prev = current;
                current = current.Next;
            }
            throw new Exception("The node could not be found int the linked list.");
        }
        //Verilen düğümden sonraya verilen T değerini ekler.
        public void AddAfter(SinglyLinkedListNode<T> node, T item)
        {
            // throw new NotImplementedException();

            SinglyLinkedListNode<T> new_node = new SinglyLinkedListNode<T>(item);

            if (Head is null)
            {
                AddFirst(item);
            }

            var current = Head;
            while (current is not null)
            {
                if (current.Equals(node))
                {
                    new_node.Next = current.Next;
                    current.Next = new_node;
                    _count++;
                    return;
                }

                current = current.Next;
            }

            throw new Exception("The node could not be found in the linked list.");
        }
        //Bağlı listenin başındaki düğümü çıkarır.
        /// Çıkarılan düğümün değerini geri döndürür.
        public T RemoveFirst()
        {
            // throw new NotImplementedException();

            if (Head is null)
            {
                throw new Exception("Linked list is empty!");
            }

            T item = Head.Value;

            Head = Head.Next;
            _count--;

            return item;
        }
        ///Bağlı listenin sonundaki düğümü çıkarır.
        /// Çıkarılan düğümün değerini geri döndürür.
        public T RemoveLast()
        {
            // throw new NotImplementedException();

            if (Head is null)
            {
                throw new Exception("Linked list is empty!");
            }

            var current = Head;

            if (current.Next is null)
            {
                T item = current.Value;
                Head = null;
                _count--;
                return item;
            }

            while (current is not null)
            {
                if (current.Next.Next is null)
                {
                    T item = current.Next.Value;
                    current.Next = null;
                    return item;
                }

                current = current.Next;
            }

            throw new Exception();
        }
        /// Eğer düğüm bağlı listede bulunmuyorsa hata fırlatır.
        /// Çıkarılan değeri geri döndürür.
        public T Remove(SinglyLinkedListNode<T> node)
        {
            if (Head is null)
                throw new Exception("The linked list is empty!");

            if (Head.Value.Equals(node.Value))
                return RemoveFirst();

            var current = Head;
            while (current.Next != null)
            {
                if (current.Next.Value.Equals(node.Value))
                {
                    T item = node.Value;
                    current.Next = current.Next.Next;
                    _count--;
                    return item;
                }
                current = current.Next;
            }
            throw new Exception("Node not found!");
        }

        public IEnumerator<T> GetEnumerator()// referans tutucu Ienumator
        {
            return new SinglyLinkedListEnumerator<T>(Head); //poliformizm
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
