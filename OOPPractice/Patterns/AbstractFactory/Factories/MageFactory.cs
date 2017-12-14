using OOPPractice.Patterns.AbstractFactory.Movements;
using OOPPractice.Patterns.AbstractFactory.Weapons;

namespace OOPPractice.Patterns.AbstractFactory.Factories {

    public class MageFactory: HeroFactory {

        public override Weapon CreateWeapon() {
            return new MagicStaff();
        }

        public override Movement CreateMovement() {
            return new TeleportationMovement();
        }

    }

}