using OOPPractice.Patterns.Builder.Constituens;

namespace OOPPractice.Patterns.Builder.MagicStaff {

    public class MagicStaff {

        public MagicArtifact Artifact { get; set; }
        public Staff Staff { get; set; }
        public ArcaneDust ArcaneDust { get; set; }

        public override string ToString() {
            return "Constituens: " 
                   + Artifact.Type + ", " 
                   + Staff.Type + ", " 
                   + ArcaneDust.Type + ";";
        }

    }

}