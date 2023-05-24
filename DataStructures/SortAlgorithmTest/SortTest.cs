using SortAlgorithm;

namespace SortAlgorithmTest
{
    public class SortTest
    {
        [Fact]
        public void BubbleSortTest()
        {
            //Arrange
            var list = new int[] { 1,2,3,4,5,6 };

            //Act
            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.Sort(ref list);
            BubbleSort<int>.Sort(list);
            //Assert
            Assert.Collection(list,
                item => Assert.Equal(1, item),
                item => Assert.Equal(2, item),
                item => Assert.Equal(3, item),
                item => Assert.Equal(4, item),
                item => Assert.Equal(5, item),
                item => Assert.Equal(6, item))
                ;
        }
    }
}