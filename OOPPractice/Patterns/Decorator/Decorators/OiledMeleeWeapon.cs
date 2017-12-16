using OOPPractice.Patterns.Decorator.Weapons;

namespace OOPPractice.Patterns.Decorator.Decorators {

    public class OiledMeleeWeapon: MeleeWeaponDecorator {

        public OiledMeleeWeapon(MeleeWeapon meleeWeapon) 
            : base("Oiled " + meleeWeapon.GetType(), meleeWeapon.GetDamage() + 3, meleeWeapon) { }

        public override string GetType() {
            return "Oiled " + _meleeWeapon.GetType();
        }

        public override int GetDamage() {
            return _meleeWeapon.GetDamage() + 3;
        }

    }

}