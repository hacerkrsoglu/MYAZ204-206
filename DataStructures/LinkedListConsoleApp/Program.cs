using LinkedList;
using LinkedList.Singly;


//var linkedList = new SinglyLinkedList<int>();
//linkedList.AddFirst(10);
//linkedList.AddFirst(20);
//linkedList.AddFirst(30);


//Console.WriteLine(linkedList.Head);
//Console.WriteLine(linkedList.Head.Next);
//Console.WriteLine(linkedList.Head.Next.Next);




//var node1 = new SinglyLinkedListNode<int>();
//node1.Value = 55;


//var node2 = new SinglyLinkedListNode<int>();
//node2.Value = 60;

//var node3 = new SinglyLinkedListNode<int>();
//node3.Value = 65;

//node1.Next = node2;
//node2.Next = node3;


//Console.WriteLine(node1);//çıktı namespace çıktı override ettik
//Console.WriteLine(node1.Next);
//Console.WriteLine(node2.Next);
//Console.WriteLine(node1.Next.Next);

//Console.WriteLine(new String('-', 20));

//var current = node1;
//while (current != null)
//{
//    Console.Write($"{current,-5}");
//    current = current.Next;
//}




//var linkedList = new SinglyLinkedList<int>();
//linkedList.AddFirst(10);
//linkedList.AddFirst(20);
//linkedList.AddFirst(30);
//linkedList.AddFirst(40);
//foreach (var item in linkedList)
//{
//    Console.WriteLine(item) ;
//}

//Console.WriteLine(new String('-',20));

//linkedList.Where(n => n > 20)
//    .ToList()
//    .ForEach(n => Console.WriteLine(n));

//Console.ReadKey();


var linkedList = new SinglyLinkedList<char>("Samsun".ToArray());
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}
//çıktı da başa ekleme olcağı için n u s m a s şeklinde olur.



var linkedList1 = new SinglyLinkedList<int>(new List<int>
{
    1,2,3,4,5
});
foreach (var item in linkedList1)
{
    Console.WriteLine(item);
}




var linkedList2 = new SinglyLinkedList<int>(new SortedSet<int>
{
    5,3,4,2,7 
    //sıralarken küçükten büyüğe sıralıcak sonnra addfirst ile büyükten küçüğe olarak olur.
});
foreach (var item in linkedList2)
{
    Console.WriteLine(item);
}
Console.ReadKey();