using Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueTests
{
    public class QueueTests
    {
        [Theory]
        [InlineData(5)]
        public void LinkedListQueue_EnQueue(int item)
        {
            //Arrange
            var queue = new Queue.Queue<int>();
            //Act
            queue.EnQueue(10);
            queue.EnQueue(item);
            //Assert
            Assert.Equal(2, queue.Count);
        }
        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(25)]
        [InlineData(35)]
        [InlineData(45)]
        public void LinkedListQueue_DeQueue(int item)
        {
            //Arrange
            var queue = new Queue.Queue<int>();
            //Act
            queue.EnQueue(10);
            queue.EnQueue(item);
            var result = queue.DeQueue();
            //Assert
            Assert.Equal(1, queue.Count);
            Assert.Equal(result, 10);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(15)]
        [InlineData(25)]
        [InlineData(35)]
        [InlineData(45)]
        public void LinkedListQueue_Peek(int item)
        {
            //Arrange
            var queue = new Queue.Queue<int>();
            //Act
            queue.EnQueue(10);
            queue.EnQueue(item);
            var result = queue.Peek();
            //Assert
            Assert.Equal(2, queue.Count);
            Assert.Equal(result, 10);
        }

        [Fact]
        public void LinkedList_IEnumerable_Constructor()
        {
            //a-h-m-e-t
            var queue = new Queue.Queue<char>("ahmet".ToArray());

            Assert.Equal(5, queue.Count);
            Assert.Equal('a', queue.Peek());


        }
    }

}
