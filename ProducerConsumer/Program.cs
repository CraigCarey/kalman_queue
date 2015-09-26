using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumerBlocking
{
    class Program
    {
        // Number of tasks to add to the TaskQueue for processing
        private const int NumTasks = 100;

        private static BlockingCollection<TaskItem> TaskQueue = new BlockingCollection<TaskItem>(new ConcurrentQueue<TaskItem>());

        // Used to make Consumer faster or slower than Producer, forcing a queue (value in ms)
        // if the Consumer is faster than the Producer, it will run out of TaskItems to process, and will block until TaskItems
        // become available. This is more efficient than spinning
        private const int ConsumerHandicap = 25;

        static void Main(string[] args)
        {   
            var producerThread = Task.Run(() => RunProducer(NumTasks));
            var consumerThread = Task.Run(() => RunConsumer());

            Task.WaitAll(producerThread, consumerThread);
            Console.WriteLine("\r\n\tConsumer finished\r\n");
        }

        
        // The method assigned to the Producer thread
        // Generates a specified number of TaskItems and adds them to the TaskQueue
        private static void RunProducer(int numTasks)
        {
            for (int i = 0; i < numTasks; i++)
            {
                // Each TaskItem has Id = i and a random Duration of between 50 and 100ms
                TaskItem taskItem = new TaskItem(i);
                Console.WriteLine("Producer - Task: " + i);
                TaskQueue.Add(taskItem);
                Thread.Sleep(taskItem.Duration);
            }

            // lets the Consumer thread know that no more tasks will be added to the queue
            TaskQueue.CompleteAdding();
            Console.WriteLine("\r\n\tProducer finished\r\n");
        }

        // The method assigned to the Consumer thread
        // Checks the TaskQueue for items and processes if any available
        // Blocks when the TaskQueue is empty, ends when CompleteAdding() is called
        // and the TaskQueue is empty
        private static void RunConsumer()
        {
            foreach (TaskItem taskItem in TaskQueue.GetConsumingEnumerable())
            {
                Console.WriteLine("Consumer - " + taskItem.ToString());
                Thread.Sleep(taskItem.Duration + ConsumerHandicap);
            }   
        }
    }
}
