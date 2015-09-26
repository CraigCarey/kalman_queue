using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class Program
    {
        private const int NumTasks = 10;
        private static BlockingCollection<TaskItem> TaskQueue = new BlockingCollection<TaskItem>();

        // used to make consuming slower than producing, to force a queue
        private const int ConsumerHandicap = 50;

        static void Main(string[] args)
        {   
            var producerThread = Task.Run(() => RunProducer(NumTasks));
            var consumerThread = Task.Run(() => RunConsumer());

            Task.WaitAll(producerThread, consumerThread);
            Console.WriteLine("\r\n\tConsumer finished\r\n");
        }

        private static void RunProducer(int numTasks)
        {
            for (int i = 0; i < numTasks; i++)
            {
                TaskItem taskItem = new TaskItem(i);
                Console.WriteLine("Producer - Task: " + i);
                TaskQueue.Add(taskItem);
                Thread.Sleep(taskItem.Duration);
            }
            
            // Mark the Queue as closed to let the Consumer know that we're finished producing
            TaskQueue.CompleteAdding();
            Console.WriteLine("\r\n\tProducer finished\r\n");
        }

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
