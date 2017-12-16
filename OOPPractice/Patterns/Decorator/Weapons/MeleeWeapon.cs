namespace OOPPractice.Patterns.Decorator.Weapons {

    public abstract class MeleeWeapon {

        protected string Type { get; set; }
        protected int Damage { get; set; }
        
        public MeleeWeapon(string type, int damage) {
            Type = type;
            Damage = damage;
        }

        public new abstract string GetType();

        public abstract int GetDamage();

        public override string ToString() {
            return GetType() + ", " + GetDamage() + " dps";
        }
        
    }

}