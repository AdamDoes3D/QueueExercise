using System;
using System.Collections.Generic;
using System.Text;

namespace QueueExercise
{
    class Queue
    {
        private readonly List<object> _queueOfObjects;

        public Queue()
        {
            _queueOfObjects = new List<object>();
            //Console.WriteLine("New queue has been created.");
        }

        public void Enqueue(object obj)
        {
            if (obj == null)
            {
                throw new NullReferenceException();
            }
            _queueOfObjects.Add(obj);
            //Console.WriteLine($"{obj} has been added to the queue.");
            PrintQueue();

        }

        public void Dequeue()
        {
            var dequeueThisObject = _queueOfObjects[0];
            _queueOfObjects.RemoveAt(0);
            //Console.WriteLine($"{dequeueThisObject} has been removed from the queue.");
            PrintQueue();
        }

        public void Clear()
        {
            if (_queueOfObjects.Count == 0)
            {
                Console.WriteLine("Cannot clear an empty queue.");
            }
            else
            {
                _queueOfObjects.Clear();
                Console.WriteLine("Queue has been cleared");
            }
        }

        public void PrintQueue()
        {
            _queueOfObjects.ForEach(x => Console.Write(x + ","));
            Console.WriteLine();
        }
    }
}
