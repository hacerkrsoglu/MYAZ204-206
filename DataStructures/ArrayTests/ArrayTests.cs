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

    }
}