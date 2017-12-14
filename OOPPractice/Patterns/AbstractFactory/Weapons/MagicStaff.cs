using System;

namespace OOPPractice.Patterns.AbstractFactory.Weapons {

    public class MagicStaff: Weapon {

        public override void Hit() {
            Console.WriteLine("Casting fireball");
        }

    }

}