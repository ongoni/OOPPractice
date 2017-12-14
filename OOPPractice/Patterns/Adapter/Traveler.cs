namespace OOPPractice.Patterns.Adapter {

    public class Traveler {

        public void Travel(Transport.Transport transport) {
            transport.Travel();
        }

    }

}