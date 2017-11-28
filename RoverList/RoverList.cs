using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    class RoverList : RoverListBase
    {
        // Add any variables you need here
        Node tail;
        
        public RoverList ()
        {

        }

        public override int Count => throw new NotImplementedException();

        public override void Add(object data)
        {
            if(this.head == null)
            {
                this.head = new Node(data);
                this.tail = this.head;
                this.tail.Next = null;
            } else
            {
                this.tail.Next = new Node(data);
                this.tail = this.tail.Next;
                this.tail.Next = null;
            }
        }

        public override void Add(int Position, object data)
        {
            this.current = this.head;
            for(int i = 0; i < Position; i++)
            {
                this.current = this.current.Next;
            }
            this.current.Next = new Node(data);
            this.tail = this.current.Next;
            this.tail.Next = null;
        }

        public override void Clear()
        {
            this.head = null;
        }

        public override Node ElementAt(int Position)
        {
            this.current = this.head;
            for (int i = 0; i < Position; i++)
            {
                this.current = this.current.Next;
            }
            return this.current;
        }

        public override void ListNodes()
        {
            this.current = this.head;
            while(this.current.Next != null)
            {
                Console.WriteLine(this.current.Data);
                this.current = this.current.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
            throw new NotImplementedException();
        }
    }
}
