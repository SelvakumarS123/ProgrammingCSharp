using QueuesBL;

namespace QueuesPL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FrontMiddleBack fmb = new FrontMiddleBack();
            fmb.PushFront(10);
            fmb.PushMiddle(20);
            fmb.PushBack(30);
            fmb.PushMiddle(15);

            Console.WriteLine($"Pop Front: {fmb.PopFront()}");
            Console.WriteLine($"Pop Middle: {fmb.PopMiddle()}");
            Console.WriteLine($"Pop Back: {fmb.PopBack()}");

            Console.WriteLine();

            QueueOps queueOps = new QueueOps();
            queueOps.Enqueue(5);
            queueOps.Enqueue(10);
            queueOps.Enqueue(15);
            Console.WriteLine($"Dequeue: {queueOps.Dequeue()}");
            Console.WriteLine($"Front: {queueOps.GetFront()}");
            Console.WriteLine($"Rear: {queueOps.GetRear()}");

            Console.WriteLine();

            QueueDS queueDS = new QueueDS();
            queueDS.Enqueue(100);
            queueDS.Enqueue(200);
            queueDS.Enqueue(300);
            Console.WriteLine($"Dequeue: {queueDS.Dequeue()}");
            Console.WriteLine($"Max: {queueDS.GetMax()}");
            Console.WriteLine($"Min: {queueDS.GetMin()}");
            Console.WriteLine($"Peek: {queueDS.Peek()}");
            Console.WriteLine($"Pop Front: {queueDS.Dequeue()}");
            Console.WriteLine($"Pop Front: {queueDS.Dequeue()}");
            Console.WriteLine($"Pop Front: {queueDS.Dequeue()}");
        }
    }
}


