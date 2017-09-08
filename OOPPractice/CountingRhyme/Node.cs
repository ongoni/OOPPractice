namespace OOPPractice.CountingRhyme {

     public class Node {

        public Node(string value) {
            Value = value;
        }

        public Node(string value, Node next, Node previous) {
            Value = value;
            Next = next;
            Previous = previous;
        }

        public string Value { get; set; }
        public Node Next { get; set; }
        public Node Previous { get; set; }
    }

}