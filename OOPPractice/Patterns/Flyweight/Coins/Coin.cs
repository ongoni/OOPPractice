namespace OOPPractice.Patterns.Flyweight.Coins {

    public class Coin {

        private double _weight;
        public CoinType _coinType;

        public Coin(CoinType type, double weight) {
            _coinType = type;
            _weight = weight;
        }

        public void Mint(double weight) {
            _coinType.Mint(weight);
        }

        public override string ToString() {
            return _coinType + " weighing " + _weight + "g.";
        }

    }

}