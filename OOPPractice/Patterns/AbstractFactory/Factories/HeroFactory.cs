using OOPPractice.Patterns.AbstractFactory.Movements;
using OOPPractice.Patterns.AbstractFactory.Weapons;

namespace OOPPractice.Patterns.AbstractFactory.Factories {

    public abstract class HeroFactory {

        public abstract Weapon CreateWeapon();
        public abstract Movement CreateMovement();

    }

}