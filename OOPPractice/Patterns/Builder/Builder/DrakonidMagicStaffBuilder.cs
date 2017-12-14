using OOPPractice.Patterns.Builder.Constituens;

namespace OOPPractice.Patterns.Builder.Builder {

    public class DrakonidMagicStaffBuilder: MagicStaffBuilder {

        public override void SetMagicArtifact() {
            MagicStaff.Artifact = new MagicArtifact {
                Type = "Dragon's heart"
            };
        }

        public override void SetStaff() {
            MagicStaff.Staff = new Staff {
                Type = "Oak"
            };
        }

        public override void SetArcaneDust() {
            MagicStaff.ArcaneDust = new ArcaneDust {
                Type = "Usual arcane dust"
            };
        }

    }

}