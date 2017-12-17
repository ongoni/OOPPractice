using System;

namespace OOPPractice.Patterns.Strategy.Strategies {

    public class RetreatStrategy: Strategy {

        public void Use() {
            Console.WriteLine("Applying retreat strategy");
        }

    }

}