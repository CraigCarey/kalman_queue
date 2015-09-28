using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProducerConsumerBlocking;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ProducerConsumerBlockingTests
{
    [TestClass]
    public class UnitTestProducerConsumerBlocking
    {
        [TestMethod]
        public void TestRunProducerConsumer()
        {
            BlockingCollection<TaskItem> testQueue = new BlockingCollection<TaskItem>(new ConcurrentQueue<TaskItem>());
            Producer testProducer = new Producer();
            Consumer testConsumer = new Consumer();
                        
            // ensure the correct amount of tasks have been produced
            testProducer.ProduceTasks(testQueue, 35);
            Assert.AreEqual(testQueue.Count, 35);
                                    
            // ensure all tasks in queue have been consumed
            testConsumer.ConsumeTasks(testQueue, 0);
            Assert.AreEqual(testQueue.Count, 0);
        }
    }
}
