using OOPPractice.Patterns.AbstractFactory.Factories;
using OOPPractice.Patterns.AbstractFactory.Movements;
using OOPPractice.Patterns.AbstractFactory.Weapons;

namespace OOPPractice.Patterns.AbstractFactory {

    public class Hero {

        private Weapon _weapon;
        private Movement _movement;

        public Hero(HeroFactory factory) {
            _weapon = factory.CreateWeapon();
            _movement = factory.CreateMovement();
        }

        public void Move() {
            _movement.Move();
        }

        public void Hit() {
            _weapon.Hit();
        }
        
    }

}