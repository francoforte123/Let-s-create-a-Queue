using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Let_s_create_a_Queue
{
    public class MyQueue<T>
    {
        protected Queue<T> arrayQueue= new Queue<T>();

        public void Queue(T value)        
        {
            arrayQueue.Enqueue(value);
        }

        public T Dequeue()    
        {
            return arrayQueue.Dequeue();
        }

        public T Peek()       
        {
            return arrayQueue.Peek();
        }
    }
}
