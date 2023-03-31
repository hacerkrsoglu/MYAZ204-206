using CollectionConsoleApp;

var g1 = new List<int>() { 10,25,20,4, 30, 3 };
var g2 = new List<int>() { 15, 25, 35, 4 };
var g3 = new List<int>() { 10, 15, 20, 25,4, 40, 50 };


//Tekrar etmeyecek şekilde birleştircez tüm elemanları yazdırcaz
//1.yaptığımız
//var result = new List<int>();


//foreach (var g in g1)

//{
//    if (!result.Contains(g))//true ya çevirir içeriyorsa doğrudur içermiyısa yanlıştır
//    {
//        result.Add(g);

//    }


//}
//foreach (var g in g2)
//{
//    if (!result.contains(g))//true ya çevirir
//    {
//        result.Add(g);

//    }


//}
//foreach (var g in g3)
//{
//    if (!result.contains(g))//true ya çevirir
//    {
//        result.Add(g);


//    }

//}
//result.ForEach(number => Console.WriteLine(number));
// dot per line her satırda 1 nokta
//küme teorisi
g1 //union birleştirir.
    .Union(g2)
    .Union(g3)
    .ToList();
//.ForEach(n => Console.WriteLine(n));
//foreach (var item in g1)
//{
//    Console.WriteLine(item);

//}





//Ortak Elemanlar kesişim

g1
    .Intersect(g2)
    .Intersect(g3)
    .ToList();
    //.ForEach(n => Console.WriteLine(n));

//farkı elemanlar
g1
    .Except(g2)
    .ToList()
    .ForEach(n => Console.WriteLine(n));

//var arr = new char[] { 'a', 'h', 'm', 'e', 't' };
var list = "ahmet".ToList();

foreach (var item in "parlak")
{
    list.Add(item);
    Console.WriteLine($"{item,-4} {list.Count,-4} " +
        $"{list.Capacity,-4}");
}

var result = new List<char>();

foreach (var item in list)
{
    // item : a, h, m, e, t  
    if (!result.Contains(item))
    {
        result.Add(item);
    }
}

result.ForEach(c => Console.Write(c));


// 
//  "meltem"
//  char[] = {'m','e','l','t','e','m'}

var list2 = "meltem".ToList();

var hashset = new HashSet<char>(list2);
//parantez içine list2 yazmasaydık aşağıdaki gibi yapabilirdik.
//foreach (var item in list2)
//{
//    hashset.Add(item);
//}

// dot per line
hashset
    .ToList()
    .ForEach(c => Console.Write(c));

//liste 3 arabaalan müşteriler
var list3 = new List<Customer>()
{
    new Customer(){Id = 1, FullName = "Ahmet Can"},
    new Customer(){Id = 2, FullName = "Furkan Ali"},
    new Customer(){Id = 3, FullName = "Mehmet Parlak"},
    new Customer(){Id = 4, FullName = "Canan Bulut"},
    new Customer(){Id = 5, FullName = "Ahmet Ak"}
};
//ev alanlar
var list4 = new List<Customer>()
{
    new Customer(){Id = 1, FullName = "Ahmet Can"},
    new Customer(){Id = 4, FullName = "Canan Bulut"},
    new Customer(){Id = 6, FullName = "Melike Güneş"}
};

//hem ev hem araba alan müşterileri bulun
var result1 = new List<Customer>();
foreach (Customer customer in list3)
{
    if (list4.Select(y => y.Id).Contains(customer.Id))
    {
        result1.Add(customer);
    }
}
result1.ForEach(y => Console.WriteLine(y));
Console.ReadKey();






