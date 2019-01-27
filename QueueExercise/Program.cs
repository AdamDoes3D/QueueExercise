using System;

namespace QueueExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);


            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();

            //queue.Clear();
            //queue.Clear();

            Console.ReadKey();
        }
    }
}
