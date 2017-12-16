using OOPPractice.Patterns.Facade.AbstractEntities;

namespace OOPPractice.Patterns.Facade.Specialists.Government {

    public class King {

        public string Name { get; set; }
        protected MilitaryAdviser _militaryAdviser;
        protected Crusade _crusade;
        
        public void OrderToStartCrusade() {
            _militaryAdviser = new MilitaryAdviser();
            
            _crusade = _militaryAdviser.AssembleCrusade();
            _militaryAdviser.StartCrusade(_crusade);
        }

        public void OrderToStopCrusade() {
            _militaryAdviser.StopCrusade(_crusade);
        }

    }

}