namespace LinkedList.Singly
{
    public class SinglyLinkedListNode<T>
        //where T:class //referans tiplileri saklar sadece değer tipleri saklayamam
    {
        public T? Value { get; set; } //= default(T) veya ? koyarız;
        public SinglyLinkedListNode<T> Next { get; set; }//referans tipli ve başlatmamız lazım
        public SinglyLinkedListNode()
        {

        }

        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return $"{Value}";
        }


    }
}