using System;

namespace OOPPractice.Patterns.Flyweight.Coins {

    public class CoinType {

        private string _type;

        public CoinType(string type) {
            _type = type;
        }

        public void Mint(double weight) {
            Console.WriteLine("Minted " + _type + " coin wighing " + weight + "g.");
        }

        public override string ToString() {
            return _type + " coin";
        }

    }

}