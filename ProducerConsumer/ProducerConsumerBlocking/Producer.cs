using System;
using System.Collections.Concurrent;
using System.Threading;

namespace ProducerConsumerBlocking
{
    public class Producer
    {
        public Guid Id { get; private set; }

        public Producer()
        {
            Id = Guid.NewGuid();
        }

        // Generates a specified number of TaskItems and adds them to the TaskQueue
        public void ProduceTasks(BlockingCollection<TaskItem> taskQueue, int numTasks)
        {
            for (int i = 0; i < numTasks; i++)
            {
                try
                {
                    // Each TaskItem has auto-generated Id and a random Duration of between 50 and 100ms                    
                    TaskItem taskItem = new TaskItem();
                    Console.WriteLine("Producer {0} - Task: {1}", Id, i);
                    taskQueue.Add(taskItem);
                    Thread.Sleep(taskItem.Duration);
                }
                catch (Exception)
                {
                    Console.WriteLine("ERROR: Task {1} creation failed", i);
                }
            }

            // Lets the Consumer thread know that no more tasks will be added to the queue
            taskQueue.CompleteAdding();
            Console.WriteLine("\r\n\tProducer finished\r\n");
        }
    }
}
