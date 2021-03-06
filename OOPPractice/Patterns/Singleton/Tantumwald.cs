﻿using OOPPractice.Patterns.Facade.Specialists.Government;

namespace OOPPractice.Patterns.Singleton {

    public class Tantumwald {
        
        private static readonly Tantumwald _instance = new Tantumwald();

        public King CurrentKing { get; set; }

        private Tantumwald() {
            CurrentKing = new King("Kojima I");
        }

        public static Tantumwald GetInstance() {
            return _instance;
        }

        public override string ToString() {
            return "Tantumwald Kingdom, king - " + CurrentKing.Name;
        }

    }

}