using System;
using System.Collections.Generic;

namespace QueuesBL
{
    public class FrontMiddleBack
    {
        private List<int> queue;

        public FrontMiddleBack()
        {
            queue = new List<int>();
        }

        public void PushFront(int n)
        {
            queue.Insert(0, n);
        }

        public void PushMiddle(int n)
        {
            int mid = queue.Count / 2;
            queue.Insert(mid, n);
        }

        public void PushBack(int n)
        {
            queue.Add(n);
        }

        public int PopFront()
        {
            if (queue.Count == 0)
                return -1;

            int frontValue = queue[0];
            queue.RemoveAt(0);
            return frontValue;
        }

        public int PopMiddle()
        {
            if (queue.Count == 0)
                return -1;

            int m = (queue.Count - 1) / 2;
            int mid = queue[m];
            queue.RemoveAt(m);
            return mid;
        }

        public int PopBack()
        {
            if (queue.Count == 0)
                return -1;

            int back = queue[queue.Count - 1];
            queue.RemoveAt(queue.Count - 1);
            return back;
        }
    }


}

