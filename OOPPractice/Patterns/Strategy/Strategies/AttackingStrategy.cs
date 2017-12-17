using System;

namespace OOPPractice.Patterns.Strategy.Strategies {

    public class AttackingStrategy: Strategy {

        public void Use() {
            Console.WriteLine("Applying attacking strategy");
        }

    }

}