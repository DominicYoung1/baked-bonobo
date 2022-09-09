namespace MUD.Multithreading.Tests
{
    [TestClass()]
    public class ListPriorityQueueTests
    {
        [TestMethod()]
        public void ListPriorityQueueTest()
        {
            ListPriorityQueue q = new ListPriorityQueue();
            Assert.IsTrue(q.IsEmpty());
            q.Enqueue(new PrintEvent("hi"), 2000);
            q.Enqueue(new PrintEvent("hello"), 1000);
            q.Enqueue(new PrintEvent("hola"), 3000);
            Assert.IsFalse(q.IsEmpty());
            Assert.AreEqual(1000, q.Peek().time);
            PriorityQueueElement f = q.Dequeue();
            Assert.AreEqual("hello", (f.evt as PrintEvent).GetString());
            PriorityQueueElement g = q.Dequeue();
            Assert.AreEqual("hi", (g.evt as PrintEvent).GetString());
            PriorityQueueElement h = q.Dequeue();
            Assert.AreEqual("hola", (h.evt as PrintEvent).GetString());


        }
    }
}