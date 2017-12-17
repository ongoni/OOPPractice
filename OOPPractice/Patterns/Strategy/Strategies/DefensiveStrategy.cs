using System;

namespace OOPPractice.Patterns.Strategy.Strategies {

    public class DefensiveStrategy: Strategy {

        public void Use() {
            Console.WriteLine("Applying defensive strategy");
        }

    }

}