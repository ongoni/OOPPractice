namespace OOPPractice.Patterns.Decorator.Weapons {

    public class Dagger: MeleeWeapon {

        public Dagger() : base("Dagger", 15) { }

        public override string GetType() {
            return Type;
        }

        public override int GetDamage() {
            return Damage;
        }

    }

}