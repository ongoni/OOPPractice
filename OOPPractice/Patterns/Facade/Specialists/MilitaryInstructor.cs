using System;
using System.Collections.Generic;
using OOPPractice.Patterns.Facade.UsualPeople;

namespace OOPPractice.Patterns.Facade.Specialists {

    public class MilitaryInstructor {

        public List<Soldier> Teach(List<Recruit> recruit) {
            Console.WriteLine("Teaching men how to fight");
            return new List<Soldier>();
        }

    }

}