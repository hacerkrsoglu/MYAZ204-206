var array = new Array.Array();

array.Add("Ahmet");
array.Add("Mehmet");
array.Add("Can");
array.Add("Filiz");
array.Add("Furkan");


Console.WriteLine(array.GetItem(array.Find("Can")));//array.Find("Can") burası int array.GetItem(array.Find("Can")) burası object
													//_InnerArray[0]

foreach (var item in array)
{
	Console.WriteLine(item);

}
Console.WriteLine(array.GetItem(3));
Console.WriteLine(array.Count);
Console.Read();
