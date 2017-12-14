using OOPPractice.Patterns.Builder.Constituens;

namespace OOPPractice.Patterns.Builder.Builder {

    public class FireMagicStaffBuilder: MagicStaffBuilder {

        public override void SetMagicArtifact() {
            MagicStaff.Artifact = new MagicArtifact {
                Type = "Phoenix's feather"
            };
        }

        public override void SetStaff() {
            MagicStaff.Staff = new Staff {
                Type = "Larch"
            };
        }

        public override void SetArcaneDust() {
            MagicStaff.ArcaneDust = new ArcaneDust {
                Type = "Fire dust"
            };
        }

    }

}