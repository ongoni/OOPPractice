using OOPPractice.Patterns.Decorator.Weapons;

namespace OOPPractice.Patterns.Decorator.Decorators {

    public abstract class MeleeWeaponDecorator: MeleeWeapon {

        protected MeleeWeapon _meleeWeapon;

        public MeleeWeaponDecorator(string type, int damage, MeleeWeapon meleeWeapon) : base(type, damage) {
            _meleeWeapon = meleeWeapon;
        }

    }

}