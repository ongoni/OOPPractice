using System;
using System.Collections.Generic;
using OOPPractice.Patterns.Flyweight.Coins;

namespace OOPPractice.Patterns.Flyweight {

    public class Coffers {

        private List<Coin> _coins = new List<Coin>();

        public void Replenish(string coinType, double coinWeight) {
            CoinType type = CoinFactory.GetCoin(coinType);
            Coin coin = new Coin(type, coinWeight);
            _coins.Add(coin);
        }

        public void Show() {
            foreach (Coin coin in _coins) {
                Console.WriteLine(coin);
            }
        }

    }

}