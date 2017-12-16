using System;
using System.Collections.Generic;

namespace OOPPractice.Patterns.Facade.AbstractEntities {

    public class Crusade {

        public Equipment Equipment { get; set; }
        public List<Soldier> Soldiers { get; set; }

        public Crusade(Equipment equipment, List<Soldier> soldiers) {
            Equipment = equipment;
            Soldiers = soldiers;
        }
        
        public void Start() {
            Console.WriteLine("Crusade!");
        }

        public void Stop() {
            Console.WriteLine("Go back home");
        }

        
        
    }

}