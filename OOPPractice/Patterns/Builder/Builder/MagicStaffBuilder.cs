namespace OOPPractice.Patterns.Builder.Builder {

    public abstract class MagicStaffBuilder {

        public MagicStaff.MagicStaff MagicStaff { get; set; }

        public void CreateMagicStaff() {
            MagicStaff = new MagicStaff.MagicStaff();
        }

        public abstract void SetMagicArtifact();
        public abstract void SetStaff();
        public abstract void SetArcaneDust();

    }

}