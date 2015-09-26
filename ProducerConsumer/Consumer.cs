using System;
using System.Collections.Concurrent;
using System.Threading;

namespace ProducerConsumerBlocking
{
    public class Consumer
    {
        public Guid Id { get; private set; }

        public Consumer()
        {
            Id = Guid.NewGuid();
        }

        // Checks the TaskQueue for items and processes if any available
        // Blocks when the TaskQueue is empty, ends when CompleteAdding() is called
        // and the TaskQueue is empty
        public void ConsumeTasks(BlockingCollection<TaskItem> taskQueue, int consumerHandicap)
        {
            foreach (TaskItem taskItem in taskQueue.GetConsumingEnumerable())
            {
                try
                {
                    Console.WriteLine("Consumer {0} - {1}", Id, taskItem.ToString());
                    Thread.Sleep(taskItem.Duration + consumerHandicap);
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Task consumption failed");
                }
            }
        }
    }
}
