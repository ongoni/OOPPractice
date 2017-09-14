namespace OOPPractice.CountingRhyme {

    /// <summary>
    /// Узел списка
    /// </summary>
    public class Node {

        /// <summary>
        /// Конструктор для создания узла с указанным значением
        /// </summary>
        /// <param name="value">Значение</param>
        public Node(string value) {
            Value = value;
        }

        /// <summary>
        /// Конструкто для создания узла с указанным сначением и связью с указанным узлами
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="next">Предыдущий узел</param>
        /// <param name="previous">Следующий узел</param>
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