namespace OOPPractice.Patterns.Decorator.Weapons {

    public class Sword: MeleeWeapon {

        public Sword() : base("Sword", 20) { }

        public override string GetType() {
            return Type;
        }

        public override int GetDamage() {
            return Damage;
        }

    }

}