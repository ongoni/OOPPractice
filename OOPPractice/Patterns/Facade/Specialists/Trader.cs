using System;
using OOPPractice.Patterns.Facade.AbstractEntities;

namespace OOPPractice.Patterns.Facade.Specialists {

    public class Trader {

        protected Equipment _equipment;
        
        public void FindNecessaryEquipment(string listOfNecessaryEquipment) {
            Console.WriteLine("Searching necessary equipment");
            _equipment = new Equipment();
        }
        
        public Equipment SellEquipent() {
            Console.WriteLine("Getting equipment from trader");
            return _equipment;
        }

    }

}