using System;

namespace OOPPractice.Patterns.AbstractFactory.Weapons {

    public class Sword: Weapon {

        public override void Hit() {
            Console.WriteLine("Hitting with sword");
        }

    }

}