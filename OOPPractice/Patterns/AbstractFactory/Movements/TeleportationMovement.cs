using System;

namespace OOPPractice.Patterns.AbstractFactory.Movements {

    public class TeleportationMovement: Movement {

        public override void Move() {
            Console.WriteLine("Teleportation");
        }

    }

}