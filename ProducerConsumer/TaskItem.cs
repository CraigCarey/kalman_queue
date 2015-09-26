using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumerBlocking
{
    // A simple representation of a work item
    class TaskItem
    {
        public int Id { get; private set; }

        // Defines how long the TaskItem will take to process
        public int Duration { get; private set; }

        private static Random rand = new Random();

        public TaskItem(int id)
        {
            Id = id;
            // values in ms
            Duration = rand.Next(50, 100);
        }

        public override string ToString()
        {
            return String.Format("Task id {0}, duration: {1}", Id, Duration);
        }
    }
}
