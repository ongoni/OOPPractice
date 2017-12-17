using System.Collections.Generic;
using OOPPractice.Patterns.AbstractFactory;
using OOPPractice.Patterns.AbstractFactory.Factories;

namespace OOPPractice.Patterns.Strategy.Squads {

    public class AdventureSquad {

        private List<Hero> _heroes = new List<Hero>();
        
        public AdventureSquad() {
            _heroes.Add(new Hero(new MageFactory()));
            _heroes.Add(new Hero(new WarriorFactory()));
            _heroes.Add(new Hero(new RogueFactory()));
        }

        public AdventureSquad(List<Hero> heroes) {
            _heroes = heroes;
        }

        public void Apply(Strategies.Strategy strategy) {
            strategy.Use();
        }

    }

}