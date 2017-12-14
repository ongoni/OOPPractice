using OOPPractice.Patterns.Builder.Builder;

namespace OOPPractice.Patterns.Builder {

    public class Mage {

        public MagicStaff.MagicStaff CreateMagicStaff(MagicStaffBuilder magicStaffBuilder) {
            magicStaffBuilder.CreateMagicStaff();
            magicStaffBuilder.SetMagicArtifact();
            magicStaffBuilder.SetStaff();
            magicStaffBuilder.SetArcaneDust();

            return magicStaffBuilder.MagicStaff;
        }

    }

}