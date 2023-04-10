using System.Collections;

namespace LinkedList.Singly
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T>? Head { get; set; }

        private SinglyLinkedListNode<T>? Curr { get; set; }

        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T>? head)
        {
            Head = head;
            Curr = null;

        }

        public T Current => Curr.Value; //cur singlylinkedlistnode tipi

        object IEnumerator.Current => Current;

        public void Dispose()//yok etmek
        {
            Head = null;
        }

        public bool MoveNext()
        {
            if(Head == null)
                return false;
            if(Curr == null)
            {
                Curr = Head;
                return true;
            }
            if(Curr.Next is not null)
            {
                Curr = Curr.Next;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            Curr = null;
            Head = null;
        }
    }
}