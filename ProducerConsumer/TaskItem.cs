using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProducerConsumer
{
    class TaskItem
    {
        public int Id { get; private set; }
        public int Duration { get; private set; }

        private static Random rand = new Random();

        public TaskItem(int id)
        {
            Id = id;
            Duration = rand.Next(50, 100);
        }

        public override string ToString()
        {
            return String.Format("Task id {0}, duration: {1}", Id, Duration);
        }
    }
}
