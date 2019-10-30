using System;
using System.Collections;

namespace code_challenges
{
    public class CircularBuffer<T>
    {
        public int capacity;
        public Queue buffer = new Queue();
        public CircularBuffer(int capacity)
        {
            this.capacity = capacity;
        }

        public T Read()
        {
            if (buffer.Count < 1) throw new InvalidOperationException();
            return (T)buffer.Dequeue();
        }

        public void Write(T value)
        {
            if (buffer.Count == capacity) throw new InvalidOperationException();
            buffer.Enqueue(value);
        }

        public void Overwrite(T value)
        {
            if (buffer.Count == capacity) buffer.Dequeue();
            buffer.Enqueue(value);
        }

        public void Clear()
        {
            while (buffer.Count > 0)
            {
                buffer.Dequeue();
            }
        }
    }
}
