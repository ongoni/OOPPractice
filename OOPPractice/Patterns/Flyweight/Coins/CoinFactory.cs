using System.Collections.Generic;

namespace OOPPractice.Patterns.Flyweight.Coins {

    public class CoinFactory {

        private static Dictionary<string, CoinType> _coinTypes = new Dictionary<string, CoinType>();

        public static CoinType GetCoin(string key) {
            CoinType type;
            if (_coinTypes.ContainsKey(key)) {
                type = _coinTypes[key];
            } else {
                type = new CoinType(key);
                _coinTypes.Add(key, type);
            }
            
            return type;
        }

    }

}