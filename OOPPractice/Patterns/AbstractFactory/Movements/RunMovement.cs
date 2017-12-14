using System;

namespace OOPPractice.Patterns.AbstractFactory.Movements {

    public class RunMovement: Movement {

        public override void Move() {
            Console.WriteLine("Run");
        }

    }

}