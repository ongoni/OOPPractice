using System;

namespace OOPPractice.Patterns.AbstractFactory.Weapons {

    public class Dagger: Weapon {

        public override void Hit() {
            Console.WriteLine("Hitting with dagger");
        }

    }

}