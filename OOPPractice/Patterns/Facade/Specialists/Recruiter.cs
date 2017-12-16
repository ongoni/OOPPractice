using System;
using System.Collections.Generic;
using OOPPractice.Patterns.Facade.UsualPeople;

namespace OOPPractice.Patterns.Facade.Specialists {

    public class Recruiter {

        public List<Recruit> Recruit() {
            Console.WriteLine("Recruiting men");
            return new List<Recruit>();
        }

    }

}