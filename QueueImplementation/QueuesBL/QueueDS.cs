using System;

namespace QueuesBL
{
    public class QueueDS
    {
        private int[] queue;
        private int front;
        private int rear;
        private int capacity;
        private int count;

        
        public int Front { get; set; }
        public int Rear { get; set; }
        public int Capacity { get; set; }
        public int Count { get; set; }
        public int[] Queue { get; set; }

        public QueueDS(int size = 70)
        {
            Queue = new int[size];
            Capacity = size;
            Front = 0;
            Rear = -1;
            Count = 0;
        }

        public void Enqueue(int n)
        {
            if (Count == Capacity)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            Rear = (Rear + 1) % Capacity;
            Queue[Rear] = n;
            Count++;
        }

        public int Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            int n = Queue[Front];
            Front = (Front + 1) % Capacity;
            Count--;
            return n;
        }

        public int Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            return Queue[Front];
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public int GetFront()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            return Queue[Front];
        }

        public int GetRear()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            return Queue[Rear];
        }
        public int GetMax()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            int max = Queue[Front];
            int i = Front;
            while (i != Rear)
            {
                max = Math.Max(max, Queue[i]);
                i = (i + 1) % Capacity;
            }
            max = Math.Max(max, Queue[Rear]);
            return max;
        }

        public int GetMin()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                return -1;
            }

            int min = Queue[Front];
            int i = Front;
            while (i != Rear)
            {
                min = Math.Min(min, Queue[i]);
                i = (i + 1) % Capacity;
            }
            min = Math.Min(min, Queue[Rear]);
            return min;
        }
    }

}
