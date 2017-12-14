using OOPPractice.Patterns.Adapter.Animal;

namespace OOPPractice.Patterns.Adapter.AdaptedTransport {

    public class HorseTransportAdapter: Transport.Transport {

        private Horse _horse;

        public HorseTransportAdapter(Horse horse) {
            _horse = horse;
        }

        public void Travel() {
            _horse.Move();
        }

    }

}