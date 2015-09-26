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
        static void Main(string[] args)
        {
            int numTasks = 100;

            var taskQueue = new BlockingCollection<string>();
            
            Task.Factory.StartNew(() =>
            {
                for (int i = 0; i < numTasks; i++)
                {
                    Console.WriteLine("Producer\tTask: " + i);
                    taskQueue.Add("task: " + i);
                    Thread.Sleep(100);
                }
            });

            Task.Factory.StartNew(() =>
            {
                foreach (string value in taskQueue.GetConsumingEnumerable())
                {
                    Console.WriteLine("Consumer\t Task: " + value);
                    Thread.Sleep(150);
                }   
            });

            Task.WaitAll();
            Console.ReadLine();
        }
    }
}
