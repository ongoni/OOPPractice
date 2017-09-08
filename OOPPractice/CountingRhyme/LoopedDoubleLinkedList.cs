using System;
using System.Collections;

namespace OOPPractice.CountingRhyme {

    public class LoopedDoubleLinkedList : IEnumerable {
        
        public LoopedDoubleLinkedList() {
            Count = 0;
            Head = null;
        }

        private Node Head { get; set; }
        public Node First { get; }
        public int Count { get; private set; }

        public void Add(string value) {
            if (Head == null) {
                Head = new Node(value);
                Head.Next = Head;
                Head.Previous = Head;
            } else {
                Node node = new Node(value, Head, Head.Previous);
                Head.Previous.Next = node;
                Head.Previous = node;
            }
            Count++;
        }

        public bool Remove(string value) {
            if (Head == null) {
                return false;
            }

            Node toRemove = null, 
                 current = Head;

            do {
                if (current.Value == value) {
                    toRemove = current;
                    break;
                }
                current = current.Next;
            } while (current != Head);

            if (toRemove != null) {
                if (Count == 1) {
                    Head = null;
                } else {
                    if (toRemove == Head) Head = Head.Next;
                    toRemove.Next.Previous = toRemove.Previous;
                    toRemove.Previous.Next = toRemove.Next;
                }
                Count--;
                return true;
            }

            return false;
        }

        public void Show() {
            Node current = Head;
            do {
                Console.Write(current.Value + " ");
                current = current.Next;
            } while (current != Head) ;
        }
 
        IEnumerator IEnumerable.GetEnumerator() {
            int stepCounter = 0;
            Node current = Head;
            do
            {
                if (current != null)
                {
                    yield return current.Value;
                    current = current.Next;
                }

                stepCounter++;
            }
            while (stepCounter != 100);
        }

    }
}