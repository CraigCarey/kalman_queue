using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProducerConsumerBlocking;

namespace ProducerConsumerBlockingTests
{
    [TestClass]
    public class UnitTestTaskItem
    {
        [TestMethod]
        public void TestTaskItemCreation()
        {
            TaskItem task = new TaskItem();
            Assert.IsTrue(task.Duration >= 50 && task.Duration <= 100);
        }
    }
}
