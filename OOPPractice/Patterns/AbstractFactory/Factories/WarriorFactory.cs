using OOPPractice.Patterns.AbstractFactory.Movements;
using OOPPractice.Patterns.AbstractFactory.Weapons;

namespace OOPPractice.Patterns.AbstractFactory.Factories {

    public class WarriorFactory: HeroFactory {

        public override Weapon CreateWeapon() {
            return new Sword();
        }

        public override Movement CreateMovement() {
            return new RunMovement();
        }

    }

}