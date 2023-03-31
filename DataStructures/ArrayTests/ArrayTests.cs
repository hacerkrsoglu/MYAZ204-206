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
        public void Array_GetItem_Exception_Test()
        {
            try
            {
                var array = new Array.Array();
                array.Add("Ahmet");
                array.Add("Fatma");

                var item = array.GetItem(-1);

                Assert.False(true);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.True(true);
            }
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
        public void Array_Swap_Test()
        {
            var array = new Array.Array();
            array.Add("Ahmet");
            array.Add("Fatma");
            array.Add("Elif");

            array.Swap(0, 2);
            var item1 = array.GetItem(0);
            var item2 = array.GetItem(2);

            Assert.Equal(item1, "Elif");
            Assert.Equal(item2, "Ahmet");
        }

        [Fact]
        public void Array_RemoveItem_Exception_Test()
        {
            try
            {
                var array = new Array.Array();
                array.Add(0);
                array.Add(1);

                var item = array.RemoveItem(-1);

                Assert.False(true);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void Array_RemoveItem_Test()
        {
            var array = new Array.Array();
            array.Add(0);
            array.Add(1);
            array.Add(2);
            array.Add(3);
            array.Add(4);

            var item1 = array.RemoveItem(2);
            var item2 = array.GetItem(2);
            array.RemoveItem(3);

            Assert.Equal(item1, 2);
            Assert.Equal(item2, 3);
            Assert.Equal(4, array.Capacity);
        }
        [Fact]
        public void Array_Remove_Test()
        {
            try
            {
                var array = new Array.Array();
                array.Add("Ahmet");
                array.Add("Fatma");

                var item1 = array.Remove();
                var item2 = array.Remove();

                Assert.Equal(item1, "Fatma");
                Assert.Equal(item2, "Ahmet");
            }
            catch (Exception)
            {
                Assert.True(true);
            }
        }

        [Fact]
        public void Array_Remove_Exception_Test()
        {
            try
            {
                var array = new Array.Array();
                array.Add(0);

                var item1 = array.Remove();

                Assert.False(false);
            }
            catch (Exception)
            {
                Assert.True(true);
            }
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
        public void Array_Counter_Test()
        {
            //Arrange
            var array = new Array.Array(36, 23, 55, 44, 61);
            //Act
            var result = array.Capacity;//5 beklerim çıktı olarak
            var result2 = String.Empty;
            foreach (var item in array)
            {
                result2 = string.Concat(result2, item);
            }
            //Assert
            Assert.Equal(5, result);
            Assert.Equal("3623554461", result2);
        }

        [Fact]
        public void Array_SetItem_Test()
        {
            //Arrange
            var numbers = new Array.Array(2, 5, 7, 9);
            //Act
            numbers.SetItem(2, 53);
            //Assert
            Assert.Equal(53, numbers.GetItem(2));
            Assert.True((int)numbers.GetItem(2) == 53);//veya numbers.GetItem(2).Equals(55)));

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