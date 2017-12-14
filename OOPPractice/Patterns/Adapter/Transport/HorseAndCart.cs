using System;

namespace OOPPractice.Patterns.Adapter.Transport {

    public class HorseAndCart: Transport {

        public void Travel() {
            Console.WriteLine("Traveling in cart");
        }

    }

}