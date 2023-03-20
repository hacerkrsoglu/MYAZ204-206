namespace ArrayTests
{
    public class ArrayTests
    {
        [Fact]
        public void Array_Count_Test()
        {
            //AAA
            //Arrange = düzenleme



            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("can");


            //Act=eylem
            int count = array.Count;


            //Assertion= iddia
            Assert.Equal(3, count);

            Assert.Equal(4, array.Capacity);





        }
        [Fact]
        public void Array_Add_Test()
        {
            //AAA
            //Arrange = düzenleme



            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("can");
            array.Add("canan");
            array.Add("elif");

            //Act=eylem
            int count = array.Count;


            //Assertion= iddia
            Assert.Equal(5, count);
            Assert.Equal(8, array.Capacity);




        }
        [Fact]
        public void Array_GetItem_Test()
        {
            // Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");

            // Act
            var item = array.GetItem(1);

            // Assert
            Assert.Equal(item, "Mehmet");
        }

        [Fact]
        public void Array_Find_Test()
        {
            //Arrange
            var array = new Array.Array();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);

            //Act
            int result = array.Find(2);

            //Assert
            Assert.Equal(1, result);

        }
        [Fact]
        public void Array_GetEnumerator()
        {
            //Arrange
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Mehmet");
            array.Add("Can");

            string result = "";
            foreach (var item in array)
            {
                result = string.Concat(result, item);


            }
            Assert.Equal(result, "AhmetMehmetCan");
               






        }
        [Fact]
        public void Array_Copy_Test()
        {
            // Arrange
            var array = new Array.Array();

            array.Add("Ahmet");     // 0
            array.Add("Mehmet");    // 1
            array.Add("Can");       // 2
            array.Add("Deniz");     // 3

            // Act
            var newArray = array.Copy(2, 3);
            var item = newArray[0];

            // Assert
            Assert.Equal("Can", item);
        }



    }
}