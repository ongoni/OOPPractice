using OOPPractice.Patterns.Decorator.Weapons;

namespace OOPPractice.Patterns.Decorator.Decorators {

    public class SharpenedMeleeWeapon: MeleeWeaponDecorator {

        public SharpenedMeleeWeapon(MeleeWeapon meleeWeapon) 
            : base("Sharp " + meleeWeapon.GetType(), meleeWeapon.GetDamage() + 3, meleeWeapon) { }

        public override string GetType() {
            return "Sharp " + _meleeWeapon.GetType();
        }

        public override int GetDamage() {
            return _meleeWeapon.GetDamage() + 3;
        }

    }

}