﻿using Advanced.Algorithms.DataStructures;
using Advanced.Algorithms.DataStructures.Queues;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Advanced.Algorithms.Tests.DataStructures.Queues
{
    [TestClass]
    public class CircularQueue_Tests
    {

        [TestMethod]
        public void CircularQueue_Test()
        {
            var Queue = new CircularQueue<int>(7);

            Queue.Enqueue(1);
            Queue.Enqueue(2);

            Queue.Enqueue(3);
            Queue.Enqueue(4);
            Queue.Enqueue(5);
            Queue.Enqueue(6);
            Queue.Enqueue(7);
            Queue.Enqueue(8);
            Queue.Enqueue(9);

            Assert.AreEqual(Queue.Count, 7);
            Assert.AreEqual(3, Queue.Dequeue());

            Assert.AreEqual(Queue.Count, 6);
            Assert.AreEqual(Queue.Dequeue(), 4);

            Assert.AreEqual(Queue.Count, 5);
            Assert.AreEqual(Queue.Dequeue(), 5);

            Assert.AreEqual(Queue.Count, 4);
            Assert.AreEqual(Queue.Dequeue(), 6);

            Assert.AreEqual(Queue.Count, 3);
            Assert.AreEqual(Queue.Dequeue(), 7);

            Assert.AreEqual(Queue.Count, 2);
            Assert.AreEqual(Queue.Dequeue(), 8);

            Assert.AreEqual(Queue.Count, 1);
            Assert.AreEqual(Queue.Dequeue(), 9);

            Assert.AreEqual(Queue.Count, 0);

            Queue.Enqueue(1);
            Queue.Enqueue(2);

            Assert.AreEqual(Queue.Count, 2);
            Assert.AreEqual(1, Queue.Dequeue());

            Assert.AreEqual(Queue.Count, 1);
            Assert.AreEqual(Queue.Dequeue(), 2);
        }

 
    }
}
