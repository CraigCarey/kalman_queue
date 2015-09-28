using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ProducerConsumerBlocking
{
    public class Program
    {
        private const int NumTasks = 100;

        // Used to make Consumer faster or slower than Producer, forcing a queue (value in ms)
        // if the Consumer is faster than the Producer (handicap is -ve), it will run out of TaskItems
        // to process, and will block until TaskItems become available. This is more efficient than spinning
        private const int ConsumerHandicap = 25;

        static void Main(string[] args)
        {
            // Blocking Collection encapsulates ConcurrentQueue by default, but can wrap
            // anything that implements IProducerConsumerCollection<T>
            BlockingCollection<TaskItem> taskQueue = new BlockingCollection<TaskItem>(new ConcurrentQueue<TaskItem>());

            Producer producer1 = new Producer();
            Consumer consumer1 = new Consumer();

            var producerThread1 = Task.Run(() => producer1.ProduceTasks(taskQueue, NumTasks));
            var consumerThread1 = Task.Run(() => consumer1.ConsumeTasks(taskQueue, ConsumerHandicap));

            Task.WaitAll(producerThread1, consumerThread1);
            Console.WriteLine("\r\n\tConsumer finished\r\n");
        }       
    }
}
