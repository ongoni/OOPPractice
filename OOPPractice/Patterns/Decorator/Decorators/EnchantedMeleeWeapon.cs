using OOPPractice.Patterns.Decorator.Weapons;

namespace OOPPractice.Patterns.Decorator.Decorators {

    public class EnchantedMeleeWeapon: MeleeWeaponDecorator {

        public EnchantedMeleeWeapon(MeleeWeapon meleeWeapon) 
            : base("Enchanted " + meleeWeapon.GetType(), meleeWeapon.GetDamage() + 10, meleeWeapon) { }

        public override string GetType() {
            return "Enchanted " + _meleeWeapon.GetType();
        }

        public override int GetDamage() {
            return _meleeWeapon.GetDamage() + 10;
        }

    }

}