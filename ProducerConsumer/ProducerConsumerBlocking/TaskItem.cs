using System;

namespace ProducerConsumerBlocking
{
    // A simple representation of a piece of work
    public class TaskItem
    {
        public Guid Id { get; private set; }

        // Defines how long the TaskItem will take to process
        public int Duration { get; private set; }

        private static Random rand = new Random();

        public TaskItem()
        {
            Id = Guid.NewGuid();
            Duration = rand.Next(50, 100); // values in ms
        }

        public override string ToString()
        {
            return String.Format("Task id {0}, duration: {1}", Id, Duration);
        }
    }
}
