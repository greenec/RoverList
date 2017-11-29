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

        public RoverList()
        {

        }

        public override int Count
        {
            get
            {
                int count = 0;
                current = head;
                while (current != null)
                {
                    count++;
                    current = current.Next;
                }
                return count;
            }
        }

        public override void Add(object data)
        {
            if (head == null)
            {
                head = new Node(data);
                tail = head;
            }
            else
            {
                tail.Next = new Node(data);
                tail = tail.Next;
            }

            tail.Next = null;
        }

        public override void Add(int Position, object data)
        {
            if (Position == 0)
            {
                Node oldHead = head;
                head = new Node(data);
                head.Next = oldHead;
                return;
            }
            
            current = ElementAt(Position - 1);
            Node oldNode = current.Next;
            current.Next = new Node(data);
            current.Next = oldNode;
        }

        public override void Clear()
        {
            head = null;
        }

        public override Node ElementAt(int Position)
        {
            current = head;
            for (int i = 0; i < Position; i++)
            {
                current = current.Next;
            }
            return current;
        }

        public override void ListNodes()
        {
            current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }

        public override bool RemoveAt(int Position)
        {
            if (Position >= Count || Position < 0)
            {
                return false;
            }

            if (Position == 0)
            {
                head = head.Next;
            }
            else
            {
                current = ElementAt(Position - 1);
                current.Next = current.Next.Next;
            }

            return true;
        }
    }
}
