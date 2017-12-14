using OOPPractice.Patterns.AbstractFactory.Movements;
using OOPPractice.Patterns.AbstractFactory.Weapons;

namespace OOPPractice.Patterns.AbstractFactory.Factories {

    public class RogueFactory: HeroFactory {

        public override Weapon CreateWeapon() {
            return new Dagger();
        }

        public override Movement CreateMovement() {
            return new RunMovement();
        }

    }

}