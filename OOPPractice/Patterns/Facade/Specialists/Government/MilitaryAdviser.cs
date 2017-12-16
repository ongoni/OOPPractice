using OOPPractice.Patterns.Facade.AbstractEntities;

namespace OOPPractice.Patterns.Facade.Specialists.Government {

    public class MilitaryAdviser {
        
        public Crusade AssembleCrusade() {
            Trader trader = new Trader();
            Recruiter recruiter = new Recruiter();
            MilitaryInstructor instructor = new MilitaryInstructor();

            trader.FindNecessaryEquipment("*list of equipment*");
            
            return new Crusade(
                trader.SellEquipent(),
                instructor.Teach(recruiter.Recruit())
            );
        }

        public void StartCrusade(Crusade crusade) {
            crusade.Start();
        }
        
        public void StopCrusade(Crusade crusade) {
            crusade.Stop();
        }

    }

}