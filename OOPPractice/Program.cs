using System;
using System.IO;
using OOPPractice.CountingRhyme;

namespace OOPPractice {

    internal class Program {

        public static void Main(string[] args) {
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());

            LoopedDoubleLinkedList list = new LoopedDoubleLinkedList();
            using (StreamReader sr = new StreamReader("../../input.txt")) {
                foreach (string item in sr.ReadToEnd().Split(' ')) {
                    list.Add(item);
                }
            }

            int counter = 1;
            foreach (var item in list) {
                if (counter == k) {
                    list.Remove((string)item);
                    counter = 0;
                }
                counter++;
                if (list.Count == 1) break;
            }
            
            Console.WriteLine("Not deleted element - " + list.First);
        }
        
    }

}